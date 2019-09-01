using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileStatus : MonoBehaviour
{
    public enum Tiletypes { build, road };
    [SerializeField]
    private Tiletypes type;
    public Tiletypes Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
