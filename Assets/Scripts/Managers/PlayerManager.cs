using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    public PlayerStats playerStats;


    private static PlayerManager _instance;
    public static PlayerManager Instance
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

    void Update()
    {

        if (PassiveManager.Instance.AutoAttackPassive)
        {

        }

    }

    public void WeaponAttack(Stats target)
    {
        if (!playerStats.HaveWeapon)
        {
            CombatManager.Instance.PhysicAttack(target, playerStats.CurrentStrength);
        }
    }

    public void CheckDeath()
    {
        if(playerStats.CurrentHealthPoints <= 0)
        {

            Death();

        }
    }

    public void Death()
    {
        Debug.Log("Jugador muerto");
        playerStats.CurrentHealthPoints = playerStats.HealthPoints;
        // QUITAR DINERO POR PENALIZACION DE MUERTE? PENSAR PENALIZACIONES
        // OTRA PENALIZACION SERIA BAJAR DURABILIDAD DE EQUIPAMIENTO 
    }
}
