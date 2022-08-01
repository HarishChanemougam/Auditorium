using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonSphere : MonoBehaviour

{
    [SerializeField] int _position;

    // Start is called before the first frame update
    void Update()
    {
        Debug.Log($"Start Position {transform.position.y==(10)}");

         if (_position==10)
         {
             Debug.Log("Correct Position");
        }
         
          if (_position > 0)
         {
            Debug.Log("rip");
            GameObject.Destroy(gameObject);
       }
    }
}
