using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;


    void Start()
    {
        _rb.velocity = new Vector2(1, 0) * _speed;
    }

    


    void Update()
    {

    }
}

    /* [SerializeField] _spawner;
     [SerializeField] _Bullet;
     public object Victor3 { get; private set; }

     void Awake(Func<UnityEngine.GameObject> GameObject)
     {
         GameObject = transform.GameObject;

         object direction = objectGame.Transform.random.direction;

     }
     Vector2 RandomDirection = Random.insideUnityCircle(Circle);

     if(Time.time =_Bullet + _spawner)*/





