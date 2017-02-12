using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour {

    private Collider2D alertRadius;

	// Use this for initialization
	void OnEnable () {
        alertRadius = GetComponent<Collider2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //other.setAlerted(true);
        }
    }
}
