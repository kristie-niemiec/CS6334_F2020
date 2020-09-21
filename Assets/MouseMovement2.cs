using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement2 : MonoBehaviour
{
    public float spinForce = 30;
    
    void Start()
    {

    }
    void OnMouseOver()
    {
            if (Input.GetMouseButton(0))
            {
                        (GameObject.Find("Cube2")).transform.Rotate(spinForce, 0, 0);     
            }
    }
    void Update()
    {
    }
}
