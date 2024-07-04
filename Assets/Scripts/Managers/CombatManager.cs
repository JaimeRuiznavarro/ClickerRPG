using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    public static event Action OnPlayerGetDMG;


    private static CombatManager _instance;
    public static CombatManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;

    }


    public void PhysicAttack(Stats target, int dmg)
    {

        int damage = CalculatorManager.CalculatePhysicDMG(dmg, target.CurrentPhysicArmor);

        target.RecieveDamage(damage);

    }
    public void MagicAttack(Stats target, int dmg)
    {

        int damage = Mathf.Clamp(dmg - target.CurrentPhysicArmor, 1, 9999);

        target.RecieveDamage(damage);


    }


}
