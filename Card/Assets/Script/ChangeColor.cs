using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[3];
    public Color color;

    void callBackFunction() {
        foreach( var obj in gameObjects ) {
            var renderer = obj.GetComponent<Renderer>( );
            renderer.material.color = color;
        }
    }
}
