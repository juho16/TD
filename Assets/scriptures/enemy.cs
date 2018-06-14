using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 10f;

    public Transform target;
    public int wavepointIndex = 0;

    void Start()
    {
        target = waypoints.points[0];

    }


    void Update()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);


        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        
        }

    }

    void GetNextWayPoint()

    {
        if(wavepointIndex>= waypoints.points.Length - 1)

        {
            Destroy(gameObject);
            return;
        }
       
            wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }








}

	
