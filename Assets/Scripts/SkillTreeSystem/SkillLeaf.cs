using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLeaf : MonoBehaviour
{

    [SerializeField]
    private int idSkillLeaf;
    [SerializeField]
    private SkillLeaf previousSkillLeaf;
    [SerializeField]
    private SkillLeaf nextSkillLeaf;
    [SerializeField]
    private bool isActivated;

    [SerializeField]
    private Skill skill;

    public bool IsActivated { get => isActivated; set => isActivated = value; }


    public void LearnSkill()
    {

        if(previousSkillLeaf != null && previousSkillLeaf.isActivated)
        {

            if(skill.type == Skill.SkillType.Passive)
            {
                //skill.UseSkill(GameManager.playerStas);
            }

            isActivated = true;

        }else if(previousSkillLeaf == null)
        {


            isActivated = true;

        }

    }


}
