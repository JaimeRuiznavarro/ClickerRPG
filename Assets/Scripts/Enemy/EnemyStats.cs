using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : Stats
{
    [Header("Exclusive Base Stats")]
    [SerializeField]
    private float timeBetweenAttacks;
    [Header("Exclusive Current Stats")]
    [SerializeField]
    public float currentTimeBetweenAttacks;


    [Header("References")]
    private Loot.LootData[] lootList;


    // Utility
    private bool canAttack = false;

    public bool CanAttack { get => canAttack; set => canAttack = value; }
    public Loot.LootData[] LootList { get => lootList; set => lootList = value; }

    public void ResetAttackCooldown()
    {
        currentTimeBetweenAttacks = timeBetweenAttacks;
    }

    public void SetUpEnemy(Enemy enemy)
    {
        //UI
        HpBar.fillAmount = enemy.healthPoints / enemy.healthPoints;
        //Current Stats
        CurrentHealthPoints = enemy.healthPoints;
        CurrentStrength = enemy.strength;
        CurrentMagic = enemy.magic;
        CurrentDexterity = enemy.dexterity;
        CurrentPhysicArmor = enemy.physicArmor;
        CurrentMagicArmor = enemy.magicArmor;
        CurrentAccuracy = enemy.accuracy;
        CurrentEvasion = enemy.evasion;
        currentTimeBetweenAttacks = enemy.timeBetweenAttacks;
        //Base stats
        HealthPoints = enemy.healthPoints;
        Strength = enemy.strength;
        Magic = enemy.magic;
        Dexterity = enemy.dexterity;
        PhysicArmor = enemy.physicArmor;
        MagicArmor = enemy.magicArmor;
        accuracy = enemy.accuracy;
        evasion = enemy.evasion;
        timeBetweenAttacks = enemy.timeBetweenAttacks;

        //Loot
        LootList = enemy.lootList;

        //Utility
        currentTimeBetweenAttacks = timeBetweenAttacks;
        CanAttack = true;
    }



}
