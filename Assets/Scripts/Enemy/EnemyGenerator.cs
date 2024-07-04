using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    [SerializeField]
    private Enemy[] enemyList;

    [Header("References")]
    [SerializeField]
    private EnemyStats targetEnemy;
    [SerializeField]
    private EnemyManager enemyManager;
    [SerializeField]
    private SpriteRenderer enemySprite;

    private static EnemyGenerator _instance;
    public static EnemyGenerator Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;

    }

    private void Start()
    {
        SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        Enemy aux = enemyList[Random.Range(0, enemyList.Length)];
        targetEnemy.SetUpEnemy(aux);
        enemySprite.sprite = aux.sprite;
        enemyManager.SkillsList = aux.skillsList;
    }

}
