using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitmovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;
    private int TargetX;
    private int TargetY;
    private int normalX;
    private int normalY;
    private float distance;
    public int[,] Tilestate = new int[6, 6];

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
        for(int i=0; i<6; i++)
        {
            for(int j=0; j<6; j++)
            {
                Tilestate[i, j] = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Move()
    {
        while (true)
        {
            distance = 0;
            SetTarget(ref TargetX, ref TargetY);
            if (transform.position.x > TargetX)
                normalX = -1;
            else
                normalX = 1;
            if (transform.position.y > TargetY)
                normalY = -1;
            else
                normalY = 1;
            while (distance < 2)
            {
                transform.Translate(normalX * speed * Time.deltaTime, 0, 0);
                distance += normalX * speed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            distance = 0;
            while (distance < 2)
            {
                transform.Translate(0, 0, normalY * speed * Time.deltaTime);
                distance += normalX * speed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            transform.position = new Vector3((int)transform.position.x, 1, (int)transform.position.z);
            if (TargetX == transform.position.x && TargetY == transform.position.y)
            {
                yield return new WaitForSeconds(3.0f);
                SetTarget(ref TargetX, ref TargetY);
            }
        }
    }

    void SetTarget(ref int Tx, ref int Ty)
    {
        int x, y;
            //x = Random.Range(0, 5);
            //y = Random.Range(0, 5);
            x = 3;
            y = 3;
            if (Tilestate[x, y] == 0)
            {
                Tx = x;
                Tx = y;
            }
            else
            {
                x = Random.Range(0, 6);
                y = Random.Range(0, 6);
            Debug.Log("A");
            return;
            }
        return;
    }
}
