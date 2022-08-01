using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonComposant : MonoBehaviour
{
    [SerializeField] int _life;
    // Start is called before the first frame update
    void Start()
    {
        if (_life < 0)
        {
            Debug.Log(" life is not correct");
        }
        if (_life > 250)
        {
           Debug.Log("hight rate life");
        }       
    }

    private void Update()
    {
        _life = _life - 1;
        if (_life == 0)
        {
        Debug.Log("well well go to hell");           
        }

        if (_life==50)
        {
            Debug.Log("heal");
        }
    }

}


