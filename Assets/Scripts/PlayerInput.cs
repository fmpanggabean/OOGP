using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement movement;
    private JumpAction jumpAction;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        jumpAction = GetComponent<JumpAction>();
    }

    private void Update()
    {
        movement.SetDirection(Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            jumpAction.Execute();
        }
    }
}
