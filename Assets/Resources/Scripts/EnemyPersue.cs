using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPersue : MonoBehaviour {

    private Vector2 rotatePoint;
    private Transform startPos;
    private float playerClose = 10f;
	// Use this for initialization
	void Start () {
        startPos = GetComponent<Transform>();
        rotatePoint = new Vector2(startPos.position.x - 2f, startPos.position.y - 2f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(rotatePoint, Vector3.down, 2f);
	}
}
