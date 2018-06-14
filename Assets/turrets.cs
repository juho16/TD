using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrets : MonoBehaviour
{
    public Transform target;
    public float range = 15f;

    public string enemyTag = "enemy";


   void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy 
        }
    }


    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }



}



