using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Collider2D[] hits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), 2);

        foreach (Collider2D col in hits)
        {
            if (col.tag != "BedRock" && col.tag != "Player")
            {
                col.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

}
