using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Road Gate"))
        {
            Instantiate(road, new Vector3(0, 0, other.gameObject.transform.parent.position.z + 100), Quaternion.identity);
        }
    }
}
