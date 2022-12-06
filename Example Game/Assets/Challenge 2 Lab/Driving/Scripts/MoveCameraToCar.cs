using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToCar : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = car.transform.position + new Vector3(0, 4, -7);
    }
}
