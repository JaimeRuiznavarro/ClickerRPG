using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public EnemyStats stats;


    [SerializeField]
    private Skill[] skillsList;

    public Skill[] SkillsList { get => skillsList; set => skillsList = value; }


    void Start()
    {
    
        

    }
    void Update()
    {
        // Ver si se puede poner en mejor sitio
        stats.currentTimeBetweenAttacks -= Time.deltaTime;
        if (stats.currentTimeBetweenAttacks <= 0)
        {
            stats.ResetAttackCooldown();
            PhysicAttack();

        }

    }


    private void OnMouseDown()
    {
        //Debug.Log("Clicado");
        PlayerManager.Instance.WeaponAttack(stats);
        CheckDeath();
    }


    public void CheckDeath()
    {
        if (stats.CurrentHealthPoints <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        //Debug.Log("Enemigo Muerto");
        DropLoot();
        stats.CanAttack = false;
        EnemyGenerator.Instance.SpawnEnemy();
    }

    private void DropLoot()
    {
        foreach (Loot.LootData item in stats.LootList)
        {
            item.GetLoot();
        }
    }

    public void PhysicAttack()
    {
        
        CombatManager.Instance.PhysicAttack(PlayerManager.Instance.playerStats, stats.CurrentStrength);
        PlayerManager.Instance.CheckDeath();
        
    }

    public void UpdateHPBar()
    {
        stats.HpBar.fillAmount = (float)stats.CurrentHealthPoints / stats.HealthPoints;
    }

}
