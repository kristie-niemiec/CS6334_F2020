using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement3 : MonoBehaviour
{
    //private Color basicColor = Color.green;
    private Color hoverColor = Color.red;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        //renderer.material.color = basicColor;
    }
    void OnMouseOver()
    {
        //renderer.material.color = hoverColor;
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Mouse Click Done!!!");
            renderer.material.color = hoverColor;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
