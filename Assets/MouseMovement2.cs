using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement2 : MonoBehaviour
{
    public float spinForce = 30;
    public bool keepRunning = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseOver()
    {
        //while (keepRunning) { 
            if (Input.GetMouseButtonDown(0))
            {
                    /*keepRunning = true;
                    while (keepRunning)
                    {*/
                        Debug.Log("Mouse Click Down!!!");
                        (GameObject.Find("Cube2")).transform.Rotate(spinForce, 0, 0);
                    //}        
            }
            if (Input.GetMouseButtonUp(0))
            {
                    Debug.Log("Mouse Click Up!!!");
                    keepRunning = false;
            }

        //}

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
