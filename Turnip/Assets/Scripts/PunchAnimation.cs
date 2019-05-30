using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAnimation : MonoBehaviour
{
    Animator animator;
    RuntimeAnimatorController idle;
    RuntimeAnimatorController punch;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        idle = Resources.Load("turnip_controller") as RuntimeAnimatorController;
        punch = Resources.Load("turnip_punch") as RuntimeAnimatorController;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            animator.runtimeAnimatorController = punch;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            animator.runtimeAnimatorController = idle;
        }
    }
}
