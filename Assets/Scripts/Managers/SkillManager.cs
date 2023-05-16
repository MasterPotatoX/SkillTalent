using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    [Header("UI Setup")]
    [SerializeField] private GameObject _skillUI;
    [SerializeField] private Transform _skillListHolder;
    [Space(5)]
    [Header("Skills Setup")]
    [SerializeField] private Skill[] _skills;
    
    private Skill _currentSkill; //Current skill that is being used


    private void Start()
    {
        SetupSkillUI();
    }

    private void Update()
    {
        ProcessCooldowns();
    }

    private void SetupSkillUI()
    {
        foreach(Skill skill in _skills)
        {
            GameObject uiSkill = Instantiate(_skillUI);
            uiSkill.GetComponent<SkillUI>().SetSkill(skill);
            uiSkill.transform.SetParent(_skillListHolder, false);
        }
    }

    private void ProcessCooldowns()
    {
        foreach (var skill in _skills)
        {
            Debug.Log(skill.GetSkillName() + " Cooldown:" + skill.GetCooldownTime());
        }
    }

    public void SetCurrentSkill(Skill skill)
    {
        _currentSkill = skill;
    }

    public void ExecuteCurrentSkill()
    {
        Debug.Log("Executing " + _currentSkill.GetSkillName());
    }

}
