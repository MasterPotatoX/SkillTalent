using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textName;

    private Skill _skill;
    private bool isConsumed = false; //Used to prevent UI updating if skill is in ready state

    private void Update()
    {
        if (!isConsumed)
            return;

        if(_skill.GetCooldownTime() > 0)
        {
            _skill.UpdateCooldown(Time.deltaTime);
            UpdateText(Mathf.CeilToInt(_skill.GetCooldownTime()).ToString());
        }
        else
        {
            UpdateText(_skill.GetSkillName());
            isConsumed = false;
        }
        
    }

    public void SetSkill(Skill skill)
    {
        _skill = skill;
        UpdateText(_skill.GetSkillName());
    }

    private void UpdateText(string newText)
    {
        textName.text = newText;
    }

    public void SkillSelected()
    {
        if(isConsumed)
        {
            return;
        }

        isConsumed = true;
        _skill.ExecuteSkill();
    }
}
