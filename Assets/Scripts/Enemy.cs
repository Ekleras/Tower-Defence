using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    public float jumpVelocity;
    


    private void Start()
    {
        target = WayPoints.points[0];

        
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
 
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World ); // kad speedas butu vienodas, delta time skirtas tam, kad veiktu nors ir ant letai frame turimu kompiuteriu
        transform.Translate(Vector3.up * jumpVelocity * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        }
        
    }

    void GetNextWayPoint()
    {
        if (wavepointIndex >= WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = WayPoints.points[wavepointIndex];
    }
}
