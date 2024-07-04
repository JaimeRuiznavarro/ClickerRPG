using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorManager : MonoBehaviour
{
    //private static CalculatorManager _instance;
    //public static CalculatorManager Instance
    //{
    //    get
    //    {
    //        return _instance;
    //    }
    //}

    //private void Awake()
    //{
    //    _instance = this;

    //}

    public static int CalculatePhysicDMG(int dmg, int phyDef)
    {
        int result = Mathf.Clamp(dmg - phyDef, 1, 9999);

        return result;
    }


}
