using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{

    public enum LootType
    {

        currency,
        material,
        equip

    }
    [System.Serializable]
    public struct LootData
    {

        public LootType type;
        public string lootName;
        public int minAmount;
        public int maxAmount;
        public float percentajeToObtain;

        public void GetLoot()
        {
            if (Random.Range(0, 100) <= percentajeToObtain)
            {
                Debug.Log("Loot conseguido");
                if (type == LootType.currency)
                {
                    InventoryDataBase.instance.currency += Random.Range(minAmount, maxAmount + 1);
                }
            }
            else
            {
                Debug.Log("Loot no conseguido");
            }
        }

    }

}
