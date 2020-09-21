using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement3 : MonoBehaviour
{
    private Color hoverColor = Color.red;
    private Renderer renderer;
    
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            renderer.material.color = hoverColor;
        }
        
    }

    void Update()
    {  
    }
}
