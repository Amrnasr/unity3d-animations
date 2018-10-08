using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkkeysOnce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("up arrow key is held down");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("down arrow key is held down");
        }
	}
}
