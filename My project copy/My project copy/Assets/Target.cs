using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 10f;
    public float defaulthealth;

    void Start()
    {
        defaulthealth = health;
    }
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0 )
        {
            Die();
        }
    }
    void Die()
    { 
            health = defaulthealth;
            gameObject.transform.position = new Vector3(Random.Range(-5, 10), Random.Range(3, 6), Random.Range(10, 40));
            FindObjectOfType<ScoreManager>().AddPoint();
    }
}
