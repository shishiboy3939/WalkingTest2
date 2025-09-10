using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDuplicate : MonoBehaviour
{
    public GameObject objectToDuplicate; // 複製したいオブジェクトをInspectorから設定
    public int numberOfDuplicates = 10;  // 複製する個数
    public Vector3 spawnRadius = new Vector3(10, 0, 10); // 複製する範囲半径

    private void Start()
    {
        Vector3 spawnPosition = transform.position; // アタッチしたゲームオブジェクトの位置を取得

        for (int i = 0; i < numberOfDuplicates; i++)
        {
            Vector3 randomOffset = new Vector3(
                Random.Range(-spawnRadius.x, spawnRadius.x),
                Random.Range(-spawnRadius.y, spawnRadius.y),
                Random.Range(-spawnRadius.z, spawnRadius.z)
            );

            Vector3 randomPosition = spawnPosition + randomOffset;

            Instantiate(objectToDuplicate, randomPosition, Quaternion.identity);
        }
    }

}