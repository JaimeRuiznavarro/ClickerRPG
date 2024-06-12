using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDataBase : MonoBehaviour
{


    public int currency;



    public static InventoryDataBase instance;

    void Awake()
    {
    
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }


        DontDestroyOnLoad(this);

    }


    public void AddCurrency(int currencyToAdd)
    {
        currency = currencyToAdd;
    }


}
