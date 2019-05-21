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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("snowy_dark_block") || col.gameObject.name.Equals("snowy_dark_block (1)")
        || col.gameObject.name.Equals("shiny_ice (5)") || col.gameObject.name.Equals("shiny_ice (11)")
            || col.gameObject.name.Equals("snowy_dark_block (2)"))
            this.transform.parent = col.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("snowy_dark_block") || col.gameObject.name.Equals("snowy_dark_block (1)")
        || col.gameObject.name.Equals("shiny_ice (5)") || col.gameObject.name.Equals("shiny_ice (11)")
            || col.gameObject.name.Equals("snowy_dark_block (2)"))
            this.transform.parent = null;
    }
}
