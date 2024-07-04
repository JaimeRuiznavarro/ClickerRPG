using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{

    [Header("Stats")]
    [Header("MainStast")]
    [SerializeField]
    [Tooltip("Estadistica que indica la vida")]
    private int healthPoints;
    [SerializeField]
    [Tooltip("Estadistica que aumenta el daño fisico")]
    private int strength;
    [SerializeField]
    [Tooltip("Estadistica que aumenta el daño magico")]
    private int magic;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la probabilidad de critico")]
    private int dexterity;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la defensa fisica")]
    private int physicArmor;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la defensa magica")]
    private int magicArmor;

    [Header("SecondaryStast")]
    [SerializeField][Tooltip("Estadistica que indica la probabilidad de acertar un golpe")]
    protected int accuracy;
    [SerializeField]
    [Tooltip("Estadistica que indica la probabilidad esquivar un golpe")]
    protected int evasion;


    [Header("CurrentStats")]
    [Header("MainStats")]
    [SerializeField]
    private int currentHealthPoints;
    [SerializeField]
    private int currentStrength;
    [SerializeField]
    private int currentMagic;
    [SerializeField]
    private int currentDexterity;
    [SerializeField]
    private int currentPhysicArmor;
    [SerializeField]
    private int currentMagicArmor;

    [Header("SecondaryStast")]
    [SerializeField]
    private int currentAccuracy;
    [SerializeField]
    private int currentEvasion;

    [Header("References")]
    [SerializeField]
    private Image hpBar;

    public int CurrentHealthPoints { get => currentHealthPoints; set => currentHealthPoints = value; }
    public int CurrentMagicArmor { get => currentMagicArmor; set => currentMagicArmor = value; }
    public int CurrentPhysicArmor { get => currentPhysicArmor; set => currentPhysicArmor = value; }
    public int CurrentDexterity { get => currentDexterity; set => currentDexterity = value; }
    public int CurrentMagic { get => currentMagic; set => currentMagic = value; }
    public int CurrentStrength { get => currentStrength; set => currentStrength = value; }
    public int CurrentAccuracy { get => currentAccuracy; set => currentAccuracy = value; }
    public int CurrentEvasion { get => currentEvasion; set => currentEvasion = value; }
    public Image HpBar { get => hpBar; set => hpBar = value; }
    public int HealthPoints { get => healthPoints; set => healthPoints = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Magic { get => magic; set => magic = value; }
    public int Dexterity { get => dexterity; set => dexterity = value; }
    public int PhysicArmor { get => physicArmor; set => physicArmor = value; }
    public int MagicArmor { get => magicArmor; set => magicArmor = value; }

    public void InitializeStats()
    {
        currentHealthPoints = HealthPoints;
        CurrentStrength = Strength;
        CurrentMagic = Magic;
        CurrentDexterity = Dexterity;
        CurrentPhysicArmor = PhysicArmor;
        CurrentMagicArmor = MagicArmor;
        CurrentAccuracy = accuracy;
        CurrentEvasion = evasion;
    }

    public void RecieveDamage(int damage)
    {
        currentHealthPoints -= damage;
        HpBar.fillAmount = (float)currentHealthPoints / HealthPoints;

    }


}
