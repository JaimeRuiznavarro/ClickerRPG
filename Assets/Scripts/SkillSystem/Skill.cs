using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Skill : ScriptableObject
{

    public enum SkillType
    {
        Damage,
        Buff,
        Status
        
    }


    public string skillName;

    public float cooldDown;

    public float currentCoolDown;


    public SkillEffect[] effectsList;

    public abstract void UseSkill(Stats user, Stats target);



}
