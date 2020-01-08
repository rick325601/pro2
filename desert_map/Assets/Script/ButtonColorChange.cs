using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorChange : MonoBehaviour
{
    //changes the color of the button when the mouse goes over it
    void Start(){
        GetComponent<Renderer>().material.color = Color.black;
    }
 
    void OnMouseEnter(){
        GetComponent<Renderer>().material.color = Color.red;
    }
 
    void OnMouseExit() {
        GetComponent<Renderer>().material.color = Color.black;
    }
     
     
}
