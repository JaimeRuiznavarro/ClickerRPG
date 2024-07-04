using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New skill", menuName = "Create skill")]
public class Skill : ScriptableObject
{

    public enum SkillType
    {
        Passive,
        Damage,
        Buff,
        Status
        
    }


    public string skillName;

    public float cooldDown;

    public float currentCoolDown;

    public SkillType type;

    public SkillEffect[] effectsList;

    public void UseSkill(Stats user, Stats target)
    {
        foreach (SkillEffect effect  in effectsList)
        {
            effect.ActivateEffect(user, target);
        }
    }

    public void AddSkill()
    {

    }

}
