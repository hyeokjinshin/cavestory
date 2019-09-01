using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSystem : MonoBehaviour
{
    public GameObject cardObject = null;

    private const int CARDCOUNT = 3;
    private GameObject[] cards = new GameObject[CARDCOUNT];

    // Start is called before the first frame update
    void Start() {
        for (var i = 0; i < CARDCOUNT; i++) {
            cards[i] = cardObject;

            var tmpObj = Instantiate(cards[i]) as GameObject;
            tmpObj.transform.parent = this.transform;
            tmpObj.transform.localPosition = new Vector3(4 * (i - 1), -0.4f, 15);
        }
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
