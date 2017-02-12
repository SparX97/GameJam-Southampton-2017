using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour {

    Transform myTransform;
    public float speed;
    public int bombNumber = 5;
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
        
        if (Input.GetKeyDown("space") && bombNumber >0)
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
            bombNumber--;
            bomb.transform.position = transform.position;
           // bomb.GetComponent<Animation>().Play("Explosion");
            Instantiate(bomb);

            //Debug.Log(bomb.GetComponent<Animation>().IsPlaying("Explosion"));
        }

    }

    //void OnCollisionEnter(Collision2D col)
    //{
        //if (col.gameObject.tag == "Enemy")
       // {
           // gameObject.SetActive(false);
           // Application.LoadLevel("Death_scene");
       // }
   // }

    void OnDestroy()
    {
        Application.LoadLevel("death_scene");
    }

}
