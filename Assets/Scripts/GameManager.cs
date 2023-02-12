using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const float height = 0.5f;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject redBallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnBalls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBalls()
    {
        Instantiate(ballPrefab, new Vector3(0, height, 0), ballPrefab.transform.rotation);
        Instantiate(ballPrefab, new Vector3(0, height, 10), ballPrefab.transform.rotation);

        Instantiate(redBallPrefab, new Vector3(-10, height, 5), redBallPrefab.transform.rotation);
        Instantiate(redBallPrefab, new Vector3(10, height, 5), redBallPrefab.transform.rotation);
    }
}
