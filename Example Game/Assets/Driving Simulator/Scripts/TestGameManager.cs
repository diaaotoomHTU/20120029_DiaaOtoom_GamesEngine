using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    public GameObject cube;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
     
        Instantiate(cube, new Vector3(0, 0, 1), Quaternion.identity, parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
