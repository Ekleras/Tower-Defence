using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float speed = 10f;
    public float startHealth = 100;
    private float health;
    public int reward = 20;

    private Transform target;
    private int wavepointIndex = 0;
    public float jumpVelocity;

    [Header("IMPORTANT")]
    public Image healthBar;

    private bool isDead = false;

    private void Start()
    {
        target = WayPoints.points[0];
        health = startHealth;

        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        if(health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        PlayerStats.Money += reward;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
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
            EndPath();
            return;
        }

        wavepointIndex++;
        target = WayPoints.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
