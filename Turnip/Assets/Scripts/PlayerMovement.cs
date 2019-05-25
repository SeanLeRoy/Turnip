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
            Debug.Log("parker is dead");
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
        if (col.gameObject.name.Equals("lv2p1") || col.gameObject.name.Equals("lv2p2")
            || col.gameObject.name.Equals("lv2p3") || col.gameObject.name.Equals("lv4p1")
            || col.gameObject.name.Equals("lv4p2") || col.gameObject.name.Equals("lv5p1")
            || col.gameObject.name.Equals("lv5p2") || col.gameObject.name.Equals("lv5p3")
            || col.gameObject.name.Equals("lv5p4") || col.gameObject.name.Equals("lv6p1") 
            || col.gameObject.name.Equals("lv6p2") || col.gameObject.name.Equals("lv6p3") 
            || col.gameObject.name.Equals("lv6p4") || col.gameObject.name.Equals("lv6p5") 
            || col.gameObject.name.Equals("lv6p6") || col.gameObject.name.Equals("lv6p7")
            || col.gameObject.name.Equals("lv7p1") || col.gameObject.name.Equals("lv7p2") 
            || col.gameObject.name.Equals("lv7p3") || col.gameObject.name.Equals("lv7p4") 
            || col.gameObject.name.Equals("lv7p5"))
            this.transform.parent = col.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("lv2p1") || col.gameObject.name.Equals("lv2p2")
            || col.gameObject.name.Equals("lv2p3") || col.gameObject.name.Equals("lv4p1")
            || col.gameObject.name.Equals("lv4p2") || col.gameObject.name.Equals("lv5p1")
            || col.gameObject.name.Equals("lv5p2") || col.gameObject.name.Equals("lv5p3")
            || col.gameObject.name.Equals("lv5p4") || col.gameObject.name.Equals("lv6p1")
            || col.gameObject.name.Equals("lv6p2") || col.gameObject.name.Equals("lv6p3")
            || col.gameObject.name.Equals("lv6p4") || col.gameObject.name.Equals("lv6p5")
            || col.gameObject.name.Equals("lv6p6") || col.gameObject.name.Equals("lv6p7")
            || col.gameObject.name.Equals("lv7p1") || col.gameObject.name.Equals("lv7p2")
            || col.gameObject.name.Equals("lv7p3") || col.gameObject.name.Equals("lv7p4")
            || col.gameObject.name.Equals("lv7p5"))
            this.transform.parent = null;
    }
}
