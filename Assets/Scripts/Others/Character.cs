using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Basic implementation of character to show effects on it

public class Character : MonoBehaviour
{
    [SerializeField] private float _hitPoints;

    private float _currentHitPoints;

    private void Start()
    {
        _currentHitPoints = _hitPoints;
    }

    public void TakeDamage(float damage)
    {
        _currentHitPoints -= damage;
        Debug.Log(gameObject.name + " - Take Damage: " + damage + " , Current Health:" + _currentHitPoints);
    }
}
