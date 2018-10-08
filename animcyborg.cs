using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcyborg : MonoBehaviour {

    //Fetch the Animator
    Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    bool m_Jump;

    bool Isjumping = false;
    //102534

    bool Ispistol = false;

    bool Ispresswall = false;

    void Start()
    {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        // The GameObject cannot jump
        m_Jump = false;
    }


	
	// Update is called once per frame
	void Update () {


        //Click the mouse or tap the screen to change the animation
        //if (Input.GetMouseButtonDown(0))
        //{
        //    m_Jump = true;
        //    Debug.Log("i am jumping");
        //}
        ////Otherwise the GameObject cannot jump.
        //else m_Jump = false;

        //if (m_Jump==true)
        //Debug.Log(m_Jump);

        //If the GameObject is not jumping, send that the Boolean “Jump” is false to the Animator. The jump animation does not play.
        //if (m_Jump == false)
        //    m_Animator.SetBool("Isjumping", false);

        //The GameObject is jumping, so send the Boolean as enabled to the Animator. The jump animation plays.
        //if (m_Jump == true)
          //  m_Animator.SetBool("Isjumping", true);


        if (Input.GetKeyDown(KeyCode.Keypad2))
        {

            Isjumping = true;
            m_Animator.SetBool("Isjumping", Isjumping);

            Isjumping = false;

        }

        ////if (Input.GetKeyDown(KeyCode.Keypad1))
        ////{
        ////    m_Animator.SetBool("Ispresswall", true);

        ////}

        if (Input.GetKey(KeyCode.Space))
        {
            Ispistol = true;
            m_Animator.SetBool("Ispistol", Ispistol);
            Ispistol = false;

        }

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            //Ispresswall = true;
            m_Animator.SetBool("Ispresswall", true);

            Debug.Log("I am playing press wall");
            if (m_Animator.GetBool("Idle"))
            {
                //If the "Crouch" parameter is enabled, disable it as the Animation should no longer be crouching
                m_Animator.SetBool("Ispresswall", false);
                Debug.Log("I have disabled the animation");
            }
            
            //Ispresswall = false;

        }


        if (Input.GetKeyUp(KeyCode.Space))
            print("space key was released");

        //anim.SetBool("Kicking", Kicking);
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Kicking = true;
        //}



        //if (Input.GetButtonDown("Jump"))
        //{

        //    m_Animator.SetBool("Jump", true);

        //}


	}
}
