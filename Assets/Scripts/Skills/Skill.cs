using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName ="Custom/New Skill")]
public class Skill : ScriptableObject
{
    [SerializeField] private string _skillName;
    [SerializeField] private string _description;
    [SerializeField] private float _manaCost;
    [SerializeField] private float _cooldownTime;

    [Header("Effects")]
    [SerializeField] private float _damageAmount;
    [SerializeField] private float _healAmount;
    [SerializeField] private float _cooldownSpeedIncrease;

    public BaseEffect[] fx;

     float _currentCooldownTime = 0;

    //Todo: add parameter for skill effects

     //Update cooldown timers
    public void UpdateCooldown(float deltaTime)
    {
        if(_currentCooldownTime > 0)
        {
            _currentCooldownTime -= deltaTime;
        }
        else
        {
            _currentCooldownTime = 0;
        }
    }

    public void ExecuteSkill()
    {
        _currentCooldownTime = _cooldownTime;
    }

    public float GetCooldownTime()
    { 
        return _currentCooldownTime; 
    }

    public string GetSkillName()
    {
        return _skillName;
    }
}


