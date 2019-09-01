using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class UnitNav : MonoBehaviour
{
    public GameManager GM;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(UnitMove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UnitMove()
    {
        agent.destination =  GM.road[Random.Range(0, GM.road.Length)].position;
        while(agent.remainingDistance > 0.5f)
        {
            yield return null;
        }
        yield return new WaitForSeconds(Random.Range(2.0f, 3.0f));
        StartCoroutine(UnitMove());
    }
}
