using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [Header("Stats")]
    [Header("MainStast")]
    [SerializeField][Tooltip("Estadistica que indica la vida")]
    protected int healthPoints;
    [SerializeField][Tooltip("Estadistica que aumenta el daño fisico")]
    protected int strength;
    [SerializeField][Tooltip("Estadistica que aumenta el daño magico")]
    protected int magic;
    [SerializeField][Tooltip("Estadistica que aumenta la probabilidad de critico")]
    protected int dexterity;
    [SerializeField][Tooltip("Estadistica que aumenta la defensa fisica")]
    protected int physicArmor;
    [SerializeField][Tooltip("Estadistica que aumenta la defensa magica")]
    protected int magicArmor;

    [Header("SecondaryStast")]
    [SerializeField][Tooltip("Estadistica que indica la probabilidad de acertar un golpe")]
    protected int accuracy;
    [SerializeField]
    [Tooltip("Estadistica que indica la probabilidad esquivar un golpe")]
    protected int evasion;


    [Header("CurrentStats")]
    [Header("MainStats")]
    [SerializeField]
    protected int currentHealthPoints;
    [SerializeField]
    protected int currentStrength;
    [SerializeField]
    protected int currentMagic;
    [SerializeField]
    protected int currentDexterity;
    [SerializeField]
    protected int currentPhysicArmor;
    [SerializeField]
    protected int currentMagicArmor;

    [Header("SecondaryStast")]
    [SerializeField]
    protected int currentAccuracy;
    [SerializeField]
    protected int currentEvasion;

    [Header("References")]
    [SerializeField]
    protected Image hpBar;
    public void InitializeStats()
    {
        currentHealthPoints = healthPoints;
        currentStrength = strength;
        currentMagic = magic;
        currentDexterity = dexterity;
        currentPhysicArmor = physicArmor;
        currentMagicArmor = magicArmor;
        currentAccuracy = accuracy;
        currentEvasion = evasion;
    }

    public void RecieveDamage(int damage)
    {
        currentHealthPoints -= damage;
        hpBar.fillAmount = (float)currentHealthPoints / healthPoints;

    }

    public void RecievePhysicDamage(int dmg)
    {

        int damage = Mathf.Clamp(dmg - currentPhysicArmor, 1, 9999);

        RecieveDamage(damage);

    }
    public int GetPhysicDamage()
    {
        return currentStrength ;
    }


}
