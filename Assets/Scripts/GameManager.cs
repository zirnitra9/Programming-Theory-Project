using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const float height = 0.5f;
    private const float basePosition = -10f;

    private const float cylinderBaseHeight = 4.5f;
    private const float cylinderZPosition = 5f;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject redBallPrefab;
    [SerializeField] private GameObject cylinderPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        SpawnBalls(3);
        SpawnRedBalls(3);
        SpawnCylinders(3);

    }

    private void SpawnCylinders(int var)
    {
        for (int i = 0; i < var; i++)
        {
            Instantiate(cylinderPrefab, new Vector3(basePosition + 10 * i, cylinderBaseHeight, cylinderZPosition), cylinderPrefab.transform.rotation);
        }
    }

    void SpawnBalls(int var)
    {
        for (int i = 0; i < var; i++)
        {
            Instantiate(ballPrefab, new Vector3(0, height, basePosition + 10*i), ballPrefab.transform.rotation);
        }
    }

    void SpawnRedBalls(int var)
    {        
        for (int i = 0; i < var; i++)
        {
            Instantiate(redBallPrefab, new Vector3(basePosition + 10 * i, height, 5), redBallPrefab.transform.rotation);
        }
    }
}
