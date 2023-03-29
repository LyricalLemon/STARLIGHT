using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject RightEnemyType1Prefab;
    [SerializeField] GameObject RightEnemyType2Prefab;
    [SerializeField] GameObject RightEnemyType3Prefab;
    [SerializeField] GameObject RightEnemyType4Prefab;
    
    float EnemyType1_SpawnInterval = 2f;
    float EnemyType2_SpawnInterval = 3f;
    float EnemyType3_SpawnInterval = 4f;
    float EnemyType4_SpawnInterval = 5f; 
    void Start()
    {
        StartCoroutine(spawnEnemyRight(EnemyType1_SpawnInterval, RightEnemyType1Prefab));
        StartCoroutine(spawnEnemyRight(EnemyType2_SpawnInterval, RightEnemyType2Prefab));
        StartCoroutine(spawnEnemyRight(EnemyType3_SpawnInterval, RightEnemyType3Prefab));
        StartCoroutine(spawnEnemyRight(EnemyType4_SpawnInterval, RightEnemyType4Prefab));
    }
    private IEnumerator spawnEnemyRight(float SpawnInterval, GameObject enemy)
    {
        yield return new WaitForSeconds(SpawnInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(10,Random.Range(1,4f),0), Quaternion.identity);
        StartCoroutine(spawnEnemyRight(SpawnInterval, enemy));
    }
}
