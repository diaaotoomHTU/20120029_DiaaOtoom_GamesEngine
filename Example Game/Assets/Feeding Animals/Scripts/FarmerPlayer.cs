using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerPlayer : MonoBehaviour
{

    [SerializeField] GameObject[] food;
    [SerializeField] Transform spawnPoint;
    GameObject clone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -20)
        {
            this.transform.Translate(-0.15f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < 20)
        {
            this.transform.Translate(0.15f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clone = Instantiate(food[Random.Range(0, 6)], spawnPoint.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().AddForce(0, 0, 500);
        }
    }
}
