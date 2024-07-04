using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveManager : MonoBehaviour
{

    private static PassiveManager instance;



    private bool autoAttackPassive = false;

    public bool AutoAttackPassive { get => autoAttackPassive; set => autoAttackPassive = value; }
    public static PassiveManager Instance { get => instance; set => instance = value; }


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
            
    }


}
