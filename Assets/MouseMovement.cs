using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float gravity = 15.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            (GameObject.Find("Cube")).transform.Translate(0, 0, -1.0f * Time.deltaTime * speed * gravity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //while (true) { 
       
            /*if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Mouse Click Done!!!");
                break;
            }*/
        //}
    }
}
