﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

    public void takeDamage()
    {
        health--;
        GameObject heart3 = GameObject.Find("Heart 3");
        GameObject heart2 = GameObject.Find("Heart 2");
        GameObject heart1 = GameObject.Find("Heart 1");
        if (heart3 != null && health < 3)
        {
            Destroy(heart3);
        }
        if (heart2 != null && health < 2)
        {
            Destroy(heart2);
        }
        if (heart1 != null && health < 1)
        {
            Destroy(heart1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

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
