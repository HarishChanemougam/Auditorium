using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletReciver : MonoBehaviour
{
    [SerializeField] int _bulletMax; // max score bullet
    [SerializeField] int _idleduration; // time delay to my object
    [SerializeField] int _reductionSpeedInSecondes; // speed reduction

    [Header("Audio")]
    [SerializeField] AudioSource _audio; //the audo we gonna mix with the game object


    [SerializeField] Color _onSprite; // color 
    [SerializeField] Color _offSprite; //color


    [SerializeField] SpriteRenderer[] _gauge; // filling bars

    [Header("Event")]
    [SerializeField] UnityEvent _onBulletRecevied;
    [SerializeField] UnityEvent _onObjectifComplet;
    [SerializeField] UnityEvent _onLevelFinished;

    float _oldDate; // to find last recived bullet
    float _newDate;


    int _currentScore;

    void Start()
    {
        _currentScore = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)


    //bullet firing movement
    {



        BulletMovement bullet = collision.GetComponentInParent<BulletMovement>();
        if (bullet != null)
        {
            _currentScore = Mathf.Min(_currentScore + 1, _bulletMax);
            Debug.Log($"current Score {_currentScore}");
            _oldDate = Time.time;

            if (_currentScore < _bulletMax)
            {

            }




            _onBulletRecevied.Invoke();
            if (_oldDate < _bulletMax && _currentScore >= _bulletMax)
            {

            }




            if (_currentScore >= _bulletMax)
            {

                _onObjectifComplet.Invoke();

            }



            //if(_currentScore < _bulletMax)
            //{
            //_currentScore = _currentScore + 1;
            //}
        }

        Debug.Log("Filling");

    }
    private void Update()
    {
        //bullet lowing section
        _newDate = _oldDate + _idleduration;
        if (Time.time > _oldDate + _idleduration)
        {
            // to low the score
            _currentScore = (int)Mathf.Max(_currentScore - (_reductionSpeedInSecondes * Time.deltaTime), 0);
            Debug.Log($"low Score {_idleduration}");

        }

        //compteur update
        for (int i = 0; i < _gauge.Length; i++)
        {
            //combien on rempli notre objectif?
            float percent = (float)_currentScore / (float)_bulletMax;
            _audio.volume = percent;
            //en prenant ce pourcentage, ca represente combien de slot chez nous ?
            float gaugecompletion = percent * _gauge.Length;


            if (i < gaugecompletion)
            {
                _gauge[i].color = _offSprite;
            }


            else
            {
                _gauge[i].color = _onSprite;
            }
        }

    }
    public bool IsValidated()


    {
        if (_currentScore >= _bulletMax)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}




