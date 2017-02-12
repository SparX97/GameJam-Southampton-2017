using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blowUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.5f);
	}

    void Update ()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), 2);

        foreach (Collider2D col in hits)
        {
            if(col.tag != "BedRock")
            {
                Destroy(col.gameObject);
            }
        }
    }


}
