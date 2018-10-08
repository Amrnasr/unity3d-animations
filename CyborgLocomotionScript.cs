using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyborgLocomotionScript : MonoBehaviour {


    //Fetch the Animator
    Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    bool m_Jump;

	// Use this for initialization
	void Start () {
        m_Animator = gameObject.GetComponent<Animator>();
        // The GameObject cannot jump
        m_Jump = false;
	}
	
	// Update is called once per frame
	void Update () {


        m_Jump = Input.GetKey(KeyCode.Q);

        if(m_Jump)
        Debug.Log(m_Jump);


        m_Animator.SetBool("Isjumping", m_Jump);

	}
}
