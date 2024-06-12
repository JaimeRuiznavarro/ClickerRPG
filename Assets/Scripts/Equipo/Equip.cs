using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Helmet,
    Chest,
    Pants,
    Boots,
    Amulet,
    Ring,
    Weapon
}

public abstract class Equip : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public int defense;
    public int attack;
    // Puedes a�adir m�s estad�sticas seg�n necesites
}

[CreateAssetMenu(fileName = "NewHelmet", menuName = "Items/Helmet")]
public class Helmet : Equip
{
    // Puedes a�adir propiedades espec�ficas para el casco
}

[CreateAssetMenu(fileName = "NewChest", menuName = "Items/Chest")]
public class Chest : Equip
{
    // Puedes a�adir propiedades espec�ficas para el pecho
}

[CreateAssetMenu(fileName = "NewPants", menuName = "Items/Pants")]
public class Pants : Equip
{
    // Puedes a�adir propiedades espec�ficas para los pantalones
}

[CreateAssetMenu(fileName = "NewBoots", menuName = "Items/Boots")]
public class Boots : Equip
{
    // Puedes a�adir propiedades espec�ficas para las botas
}