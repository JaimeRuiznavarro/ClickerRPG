using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PlayerStats : Stats
{

    [SerializeField]
    private bool haveWeapon;
    
    void Start()
    {
        //UI
        InitializeStats();
        hpBar.fillAmount = (float)currentHealthPoints / healthPoints;

    }
    public void WeaponAttack(Stats target)
    {
        if (!haveWeapon)
        {
            target.RecievePhysicDamage(currentStrength);
        }
    }

}
