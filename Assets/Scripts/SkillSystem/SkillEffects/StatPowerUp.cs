using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatPowerUp", menuName = "Effect/StatPowerUp")]
public class StatPowerUp : SkillEffect
{

    [SerializeField]
    private int amount;


    [SerializeField]
    private Data.Stat stat;

    public override void ActivateEffect(Stats user, Stats target)
    {

        switch (stat)
        {
            case Data.Stat.strength:
                user.Strength += amount;
                break;
            default:
                break;
        }


    }
}