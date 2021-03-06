﻿using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Vector2 velocity = new Vector2(-5, 0);
    float range = 3.5f;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y + range * Random.Range(-1.0F, 1.0F), transform.position.z);
    }
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -3)
        {
            Destroy(this.gameObject);
        }
    }
    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Destroy(this.gameObject);
        Health.health = Health.health - 10f;
        
        
    }
}