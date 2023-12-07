using System;
using UnityEngine;

internal class Projectile : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] private float lifeTime;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
    internal void SetVelocity(Transform anchor, float shootingPower)
    {
        rigidbody2D.velocity = anchor.right * shootingPower;
    }
    
}
