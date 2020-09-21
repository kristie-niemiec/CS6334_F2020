using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float speed = 0.5f;
    public float gravity = 15.0f;
    
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            (GameObject.Find("Cube")).transform.Translate(0, 0, -0.5f * Time.deltaTime * speed * gravity);
        }
    }
    
    void Update()
    {
       
    }
}
