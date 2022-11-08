using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    public GameObject Sun;
    Vector3 SunPos;

    // Start is called before the first frame update
    void Start()
    {
        SunPos = Sun.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(SunPos, 90);
    }
}
