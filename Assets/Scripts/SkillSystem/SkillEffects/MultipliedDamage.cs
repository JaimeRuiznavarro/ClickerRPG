using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MultipliedDMGEffect", menuName = "Effect/MultipliedDMG")]
public class MultipliedDamage : SkillEffect
{


    [SerializeField]
    private int percentajeOfDamage;

    [SerializeField]
    private Data.DamageType damageType;

    public override void ActivateEffect(Stats user,Stats target)
    {
        switch (damageType)
        {
            case Data.DamageType.Physic:

                Debug.Log("Daño fisico");

                break;

            case Data.DamageType.Magic:

                Debug.Log("Daño magico");
                break;

            case Data.DamageType.True:

                Debug.Log("Daño verdadero");
                break;

        }
    }
}
