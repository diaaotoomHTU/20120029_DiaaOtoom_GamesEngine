using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerPlayer : MonoBehaviour
{
    public GameObject apple;
    public GameObject banana;
    public GameObject bone;
    public GameObject carrot;
    public GameObject cookie;
    public GameObject steak;
    List<GameObject> inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<GameObject>();
        inventory.Add(apple);
        inventory.Add(banana);
        inventory.Add(bone);
        inventory.Add(carrot);
        inventory.Add(cookie);
        inventory.Add(steak);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -20)
        {
            this.transform.Translate(-0.3f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < 20)
        {
            this.transform.Translate(0.3f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
