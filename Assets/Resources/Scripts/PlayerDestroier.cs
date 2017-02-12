using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroier : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.SetActive(false);
            Application.LoadLevel("death_scene");
        }
    }
}
