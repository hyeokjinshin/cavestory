using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private static GameManager instance;
    //public static GameManager Instance
    //{
    //    get
    //    {
    //        if(!instance)
    //        {
    //            instance = new GameManager();
    //        }
    //        return instance;
    //    }
    //}

    public GameObject TileMap;
    public Transform[] road;

    // Start is called before the first frame update
    void Start()
    {
        //if (!instance)
        //    instance = new GameManager();
        //int roadcount = 0;
        //for(int i=0; i<TileMap.transform.childCount; i++)
        //{
        //    if (TileMap.transform.GetChild(i).GetComponent<TileStatus>().Type == TileStatus.Tiletypes.road)
        //    {
        //        road[roadcount] = TileMap.transform.GetChild(i);
        //        roadcount++;
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
