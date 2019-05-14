using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public int speedMod = 1;
    public int jumpMod = 1;
    public int health = 3;
    public bool invincible = false;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    bool jump = false;

	// Update is called once per frame
	void Update()
    {
        if (invincible)
        {
            health = 3;
        }
        if (health == 0)
        {
            // die
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed *speedMod;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

	void FixedUpdate()
	{
        // Move, crouch, jump
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        if (jumpMod == 1)
        {
            jump = false;
        } else
        {
            jumpMod--;
        }
	}
}
