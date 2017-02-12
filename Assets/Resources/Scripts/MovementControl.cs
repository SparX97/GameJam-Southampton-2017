using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

    Transform myTransform;
    public float speed;
    public GameObject bomb;
    //private Transform playerPosition;

    //public int pooledBombs = 5;
    //private List<GameObject> bombs;

    void Start () {

        myTransform = GetComponent<Transform>();
    }
	
	void Update () {
        myTransform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime));

        //playerPosition = GetComponent<Transform>();
        
        if (Input.GetKeyDown("space"))
        {
            //for (int i = 0; i < bombs.Count; i++)
           // {
                //if (!bombs[i].activeInHierarchy)
                //{
                   // bombs[i].transform.position = transform.position;
                   // bombs[i].transform.rotation = transform.rotation;
                   // bombs[i].SetActive(true);
                   // break;
               // }
            //}
            
            bomb.transform.position = transform.position;
           // bomb.GetComponent<Animation>().Play("Explosion");
            Instantiate(bomb);

            //Debug.Log(bomb.GetComponent<Animation>().IsPlaying("Explosion"));
        }

    }

    

}
