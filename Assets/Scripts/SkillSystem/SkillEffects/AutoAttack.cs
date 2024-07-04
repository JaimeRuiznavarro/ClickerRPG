using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AutoAttack", menuName = "Effect/AutoAttack")]
public class AutoAttack : SkillEffect
{

    public override void ActivateEffect(Stats user, Stats target)
    {

        PassiveManager.Instance.AutoAttackPassive = true;


    }


}
