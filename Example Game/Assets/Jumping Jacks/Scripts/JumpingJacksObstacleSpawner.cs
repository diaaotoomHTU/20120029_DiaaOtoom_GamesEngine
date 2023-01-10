using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingJacksObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles = new GameObject[7];

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObstacle()
    {
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], this.transform.position, Quaternion.identity);
    }
}
