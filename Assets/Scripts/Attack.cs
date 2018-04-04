using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Attack : MonoBehaviour
{
    public Transform tower;
    public NavMeshAgent navMesh;

    [SerializeField]
    float speed;
    void Start()
    {
        navMesh.SetDestination(GameObject.FindGameObjectWithTag("Tower").transform.position);   
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tower")
        {
            Destroy(gameObject);
            //Debug.Log("hit");
        }
    }
}
