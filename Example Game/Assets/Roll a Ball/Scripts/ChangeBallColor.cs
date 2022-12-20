using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBallColor : MonoBehaviour
{
    public void ChangeColor(GameObject ball)
    {
        ball.GetComponent<MeshRenderer>().material.color = this.GetComponent<Image>().color;
    }
}
