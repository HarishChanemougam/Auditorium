using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGameplay : MonoBehaviour

{
    [SerializeField] BulletReciver _objectif;
    [SerializeField] string _nextScene;

    private void Update()
    {
        if(_objectif.IsValidated())
        {
            Debug.Log("heeeee");

            SceneManager.LoadScene(_nextScene);
        }
    }


}

   