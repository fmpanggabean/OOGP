using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAction : MonoBehaviour, IAction
{
    [SerializeField] private float jumpPower;
    private Rigidbody2D Rigidbody2D;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Execute()
    {
        Vector2 jumpVelocity = Rigidbody2D.velocity;
        jumpVelocity.y = jumpPower;
        Rigidbody2D.velocity = jumpVelocity;
    }
}
