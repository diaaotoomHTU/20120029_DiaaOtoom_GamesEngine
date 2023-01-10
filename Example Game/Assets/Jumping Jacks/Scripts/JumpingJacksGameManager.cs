using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingJacksGameManager : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject particles;
    Animator animatorController;
    

    // Start is called before the first frame update
    void Start()
    {
        animatorController = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animatorController.SetBool("Run", !animatorController.GetBool("Run"));
            particles.SetActive(!particles.activeInHierarchy);
        }
        
    }
}
