using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingAnimalsGameManager : MonoBehaviour
{
    [SerializeField] GameObject[] animals;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimal()
    {
        Instantiate(animals[Random.Range(0, 7)], new Vector3(Random.Range(-15, 16), 0, 30), Quaternion.Euler(0, 180, 0));
    }
}
