using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipliedDamage : SkillEffect
{


    [SerializeField]
    private int percentajeOfDamage;

    [SerializeField]
    private SkillData.DamageType damageType;

    public override void ACtivateEffect(Stats user,Stats target)
    {
        switch (damageType)
        {
            case SkillData.DamageType.Physic:

                

                break;

            case SkillData.DamageType.Magic:
                break;

            case SkillData.DamageType.True:
                break;

        }
    }
}
