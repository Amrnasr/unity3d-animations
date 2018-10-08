using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animjump : MonoBehaviour {

    //Fetch the Animator
    Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    bool m_Jump;

	// Use this for initialization
	void Start () {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        // The GameObject cannot jump
        m_Jump = false;
	}
	
	// Update is called once per frame
	void Update () {
        //Click the mouse or tap the screen to change the animation
        if (Input.GetKeyDown(KeyCode.Q))
            m_Jump = true;

        //Otherwise the GameObject cannot jump.
        else m_Jump = false;

        //If the GameObject is not jumping, send that the Boolean “Jump” is false to the Animator. The jump animation does not play.
        //if (m_Jump == false)
        //    m_Animator.SetBool("Isjumping", false);

        //The GameObject is jumping, so send the Boolean as enabled to the Animator. The jump animation plays.
        if (m_Jump == true)
            m_Animator.SetBool("Isjumping", m_Jump);


        //if (!m_Animator.isPlaying("Isjumping"))
        //{
        //    m_Animator.SetBool("Isjumping", false);
        //}


        if (m_Jump)
            Debug.Log(m_Jump);
	}
}
