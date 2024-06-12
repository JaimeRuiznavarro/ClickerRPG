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
    // Puedes añadir más estadísticas según necesites
}

[CreateAssetMenu(fileName = "NewHelmet", menuName = "Items/Helmet")]
public class Helmet : Equip
{
    // Puedes añadir propiedades específicas para el casco
}

[CreateAssetMenu(fileName = "NewChest", menuName = "Items/Chest")]
public class Chest : Equip
{
    // Puedes añadir propiedades específicas para el pecho
}

[CreateAssetMenu(fileName = "NewPants", menuName = "Items/Pants")]
public class Pants : Equip
{
    // Puedes añadir propiedades específicas para los pantalones
}

[CreateAssetMenu(fileName = "NewBoots", menuName = "Items/Boots")]
public class Boots : Equip
{
    // Puedes añadir propiedades específicas para las botas
}