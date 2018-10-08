using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcyborg2 : MonoBehaviour {


    Animator animator;

    bool jumping = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            jumping = true;



            animator.SetBool("Isjumping", true);

  //          Debug.Log("I am jumping");
           // WaitAndJump();

           
        }
       /// Debug.Log(animator.GetCurrentAnimatorStateInfo(0).IsName("Idle")); outputs false

        if (animator.GetBool("Idle"))
        {
            //If the "Crouch" parameter is enabled, disable it as the Animation should no longer be crouching
            animator.SetBool("Crouch", false);
        }




        if (jumping)
        {
            Debug.Log("Jumping");
            //Debug.Log(animator.GetCurrentAnimatorClipInfo(0));
        }


        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Isjumping"))
        //{

        //    Debug.Log("Animation is playing");
        //   // animator.SetBool("Isjumping", false);
            
        //}else
        //{
        //    //Debug.Log("animation Stopped");
        //}


    }


    IEnumerator WaitAndJump()
    {
        yield return new WaitForSeconds(0.5f);

        animator.SetBool("Isjumping", false);
    }

    void SetAnimateFalse()
    {
        animator.SetBool("Isjumping", false);
    } 
}
