using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    public GameObject Sun;
    Vector3 SunPos;
    float angle;

    // Start is called before the first frame update
    void Start()
    {
        SunPos = Sun.transform.position;
        angle = Random.Range(0.1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(SunPos, Vector3.up, angle);
    }
}
