using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostSystem : MonoBehaviour
{
    public int cost = -1;

    void callBackFunction() {
        var karmaSystem = GameObject.Find("KarmaSystem");
        karmaSystem.GetComponent<Karma>( ).ChangeKarma(cost);
    }
}
