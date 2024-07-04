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

    public bool HaveWeapon { get => haveWeapon; set => haveWeapon = value; }

    void Start()
    {
        //UI
        InitializeStats();
        HpBar.fillAmount = (float)CurrentHealthPoints / HealthPoints;

    }

}
