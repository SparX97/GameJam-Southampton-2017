using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float timer = 3f;
    //public Animation anim;

    //public Animation boom;
    //private GameObject childObj;

    // Use this for initialization
    void Start () {
        //anim.enabled = false;
    }

    void OnEnable()
    {
        //childObj = GameObject.Find("BombAlarm");
        //childObj.SetActive(false);
        //explosionRadius = GetComponent<Collider2D>();
        //explosionRadius.enabled = false;
        //boom = GetComponent<Animation>();
        //Invoke("Explode", 3f);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (timer > 0f)
        {
            timer = timer - Time.deltaTime;
        } else
        {
            //anim.enabled = true

            Collider2D[] hits = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), 2);

            foreach (Collider2D col in hits)
            {
                if (col.tag != "BedRock")
                {
                    Destroy(col.gameObject);
                }
            }
            
            Destroy(gameObject);
        }
	}

    //void Explode()
    //{
        // boom.Play();
        //explosionRadius.enabled = true;
        //childObj.SetActive(true);

        //shockWave.transform.position = transform.position;
       // Instantiate(shockWave);
        //shockWave.transform.position = transform.position;
        //gameObject.SetActive(false);
    //}
    

    //void OnDisable()
   // {
       // CancelInvoke();
   // }
    
    //void OnTriggerStay2D (Collider2D other)
    //{
       // if (other.tag != "BedRock")
       // {
          //  other.gameObject.SetActive(false);
      //  }
  //  }
}
