using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Heal", menuName = "Effect/Heal")]
public class Heal : SkillEffect
{


    [SerializeField]
    private int percentajeOfDamage;

    [SerializeField]
    private Data.DamageType damageType;

    public override void ActivateEffect(Stats user, Stats target)
    {
        switch (damageType)
        {
            case Data.DamageType.Physic:

                Debug.Log("Cura fisica");

                break;

            case Data.DamageType.Magic:

                Debug.Log("Cura magica");
                break;

        }
    }
}
