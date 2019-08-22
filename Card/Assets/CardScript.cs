using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    private Color highlightColor;
    private Renderer rend = null;

    private Material[] originMat = new Material[4];
    private Transform[] edges = new Transform[4];

    // Start is called before the first frame update
    void Start() {
        highlightColor = Color.red;

        edges[0] = this.transform.Find("edges").transform.Find("left");
        edges[1] = this.transform.Find("edges").transform.Find("right");
        edges[2] = this.transform.Find("edges").transform.Find("top");
        edges[3] = this.transform.Find("edges").transform.Find("bottom");

        Debug.Log(edges);
    }

    private void OnMouseOver() {
        for(var i = 0; i < 4; i++) {
            var tmpRender = edges[i].GetComponent<Renderer>();
            originMat[i] = tmpRender.sharedMaterial;
            
            var tmpMat = new Material(originMat[i]);
            tmpRender.material = tmpMat;
            tmpRender.material.color = highlightColor;
        }
    }

    private void OnMouseExit() {
        for ( var i = 0; i < 4; i++ ) {
            var tmpRender = edges[i].GetComponent<Renderer>();
            tmpRender.material = originMat[i];
            tmpRender.material.color = Color.white;
        }
    }

    private void OnMouseUpAsButton() {
        Debug.Log("click");
    }
}
