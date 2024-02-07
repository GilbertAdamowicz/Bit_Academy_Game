using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool TargetPractice;
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
        if (TargetPractice)
        {
            health = defaulthealth;
            gameObject.transform.position = new Vector3(Random.Range(-9, 9), Random.Range(4, 5), Random.Range(-10, 10));
        }
        else 
        {
            Destroy(gameObject);
        }
        Debug.Log("Target geschoten");
    }
}
