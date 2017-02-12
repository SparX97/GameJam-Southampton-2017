using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingScript : MonoBehaviour {

    private Transform kingPos;
    public float speed;

	// Use this for initialization
	void Start () {
        kingPos = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        kingPos.Rotate(new Vector3(0,0,speed) * Time.deltaTime);
	}

    void OnCollisionEnter(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("youWin");
        }
    }
}
