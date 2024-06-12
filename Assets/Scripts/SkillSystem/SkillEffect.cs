using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class SkillEffect : MonoBehaviour
{


    public abstract void ACtivateEffect(Stats user, Stats target);



}
