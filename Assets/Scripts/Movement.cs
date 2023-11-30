using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IMovement
{
    private Rigidbody2D Rigidbody2D;
    private float direction;
    [SerializeField] private float speed;

    public void RotationUpdate(float direction)
    {
        if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void SetDirection(float direction)
    {
        this.direction = direction;
    }

    public void UpdatePosition()
    {
        Vector2 velocity = Rigidbody2D.velocity;
        velocity.x = direction * speed;
        RotationUpdate(direction);
        Rigidbody2D.velocity = velocity;
    }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    private void Update()
    {
        UpdatePosition();
    }

}
