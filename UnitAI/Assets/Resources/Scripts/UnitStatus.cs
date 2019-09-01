using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UnitStatus : MonoBehaviour
{
    //Unit models
    public GameObject hair;
    public GameObject face;

    [SerializeField, TextArea(0, 3)]
    private string IdleLine;

    //status property
    public float AttackDmg { get; set; }
    public float HP { get; set; }
    public float DP { get; set; }
    public float karma { get; set; }
    public float Productivity { get; set; }
    public string Unitname { get; set; }

    public string[] names = { "여친쓰", "혁진쓰", "회민쓰", "웅연쓰", "빵훈쓰" };
    // Start is called before the first frame update
    void Start()
    {
        AttackDmg = 0;
        HP = 0;
        DP = 0;
        karma = 0;
        Productivity = 0;
        Unitname = names[Random.Range(0, names.Length)];
        hair.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
    }

    private void OnDrawGizmos()
    {
        Handles.Label(transform.position, Unitname);
    }
}
