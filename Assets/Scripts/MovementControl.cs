using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

    Transform myTransform;
    //Rigidbody2D myRigidbody;
    public float speed;

    void Start () {
        //myRigidbody = GetComponent<Rigidbody2D>();
        myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        //myTransform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") ));
        myTransform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime));
        //myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, myRigidbody.velocity.y);
        // Input.GetAxisRaw("Vertical") * speed * Time.deltaTime
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collide");
        
    }


}
