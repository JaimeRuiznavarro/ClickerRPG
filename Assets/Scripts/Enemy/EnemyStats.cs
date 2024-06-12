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
    private float currentTimeBetweenAttacks; 


    [Header("References")]
    private Loot.LootData[] lootList;


    // Utility
    private bool canAttack = false;


    void Update()
    {
        // Ver si se puede poner en mejor sitio
        CheckDeath();
        currentTimeBetweenAttacks -= Time.deltaTime;
        if(currentTimeBetweenAttacks <= 0)
        {
            currentTimeBetweenAttacks = timeBetweenAttacks;
            Attack();
            
        }

    }
    public void SetUpEnemy(Enemy enemy)
    {
        //UI
        hpBar.fillAmount = enemy.healthPoints / enemy.healthPoints;
        //Current Stats
        currentHealthPoints = enemy.healthPoints;
        currentStrength = enemy.strength;
        currentMagic = enemy.magic;
        currentDexterity = enemy.dexterity;
        currentPhysicArmor = enemy.physicArmor;
        currentMagicArmor = enemy.magicArmor;
        currentAccuracy = enemy.accuracy;
        currentEvasion = enemy.evasion;
        currentTimeBetweenAttacks = enemy.timeBetweenAttacks;
        //Base stats
        healthPoints = enemy.healthPoints;
        strength = enemy.strength;
        magic = enemy.magic;
        dexterity = enemy.dexterity;
        physicArmor = enemy.physicArmor;
        magicArmor = enemy.magicArmor;
        accuracy = enemy.accuracy;
        evasion = enemy.evasion;
        timeBetweenAttacks = enemy.timeBetweenAttacks;

        //Loot
        lootList = enemy.lootList;

        //Utility
        currentTimeBetweenAttacks = timeBetweenAttacks;
        canAttack = true;

    }
    
    private void CheckDeath()
    {
        if(currentHealthPoints <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        //Debug.Log("Enemigo Muerto");
        DropLoot();
        canAttack = false;
        EnemyGenerator.Instance.SpawnEnemy();
    }

    private void DropLoot()
    {
        foreach (Loot.LootData item in lootList)
        {
            item.GetLoot();
        }
    }

    private void OnMouseDown()
    {
        //Debug.Log("Clicado");
        PlayerManager.Instance.playerStats.WeaponAttack(this);
        
    }

    private void Attack()
    {
        PlayerManager.Instance.playerStats.RecievePhysicDamage(currentStrength);

    }


}
