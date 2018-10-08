using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {


    Animator animator;

    bool running = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            if (!running)
            {
                animator.SetTrigger("Run");
                running = true;
            }
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            animator.SetTrigger("Idle");
            running = false;
        }

    }
}
