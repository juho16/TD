using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemy;
    float timer = 0;


    private void Update()

    {
        timer = timer + Time.deltaTime;

        if (timer >= 1f)



        {
            Instantiate(enemy, transform.position, Quaternion.identity);

            timer = 0;
        }



    }




}




