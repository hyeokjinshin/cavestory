using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma : MonoBehaviour
{
    // Start is called before the first frame update
    public int karma = 0;
    private TextMesh tm;

    void Start() {
        var cost = transform.Find("cost");
        tm = cost.GetComponent<TextMesh>();
        tm.text = karma.ToString();
    }

    internal void ChangeKarma( int cost ) {
        karma -= cost;
        if ( karma < 0 ) { karma += cost; }
        tm.text = karma.ToString( );
    }
}
