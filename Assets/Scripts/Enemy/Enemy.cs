using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New enemy", menuName = "Create enemy")]
public class Enemy : ScriptableObject
{

    [Header("Stats")]
    [Header("MainStast")]
    [SerializeField]
    [Tooltip("Estadistica que indica la vida")]
    public int healthPoints;
    [SerializeField]
    [Tooltip("Estadistica que aumenta el daño fisico")]
    public int strength;
    [SerializeField]
    [Tooltip("Estadistica que aumenta el daño magico")]
    public int magic;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la probabilidad de critico")]
    public int dexterity;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la defensa fisica")]
    public int physicArmor;
    [SerializeField]
    [Tooltip("Estadistica que aumenta la defensa magica")]
    public int magicArmor;

    [Header("SecondaryStast")]
    [SerializeField]
    [Tooltip("Estadistica que indica la probabilidad de acertar un golpe")]
    public int accuracy;
    [SerializeField]
    [Tooltip("Estadistica que indica la probabilidad esquivar un golpe")]
    public int evasion;

    [SerializeField]
    [Tooltip("Tiempo entre ataques del enemigo")]
    public int timeBetweenAttacks;

    [Header("Art")]
    [SerializeField]
    public Sprite sprite;

    [Header("Skills")]
    [SerializeField]
    private Skill[] skillsList;

    [Header("Loot")]
    [SerializeField][Tooltip("Lista de recompensas posibles al matar al enemigo")]
    public Loot.LootData[] lootList;

}
