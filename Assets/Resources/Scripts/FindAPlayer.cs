using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAPlayer : MonoBehaviour {

    private GameObject player;

    private float range;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	

	// Update is called once per frame
	void Update () {

        Vector3 dir = -player.transform.position + transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        range = Vector2.Distance(transform.position, player.transform.position);

        //transform.Translate(new Vector2(player.transform.position.x * Time.deltaTime * 0.1f, player.transform.position.y * Time.deltaTime * 0.1f));
        transform.Translate(Vector2.MoveTowards(transform.position, player.transform.position, range) * 0.3f * Time.deltaTime);

    }
}
