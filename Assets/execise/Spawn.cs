using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] float _cooldown;

    [Header("Time Delay")]
    [SerializeField] float _cooldownremaining;

    private void Start()
    {
        _cooldownremaining = _cooldown;
    }
    private void Update()       
    {
        _cooldownremaining = _cooldownremaining - Time.deltaTime;

        if (_cooldownremaining < 0)
        {
            _cooldownremaining = _cooldown;
            GameObject.Instantiate(_prefab, transform.position, transform.rotation);
        }
    
    }

    
}

