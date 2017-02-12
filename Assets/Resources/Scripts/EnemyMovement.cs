using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


   public  Transform myTransform;
    public bool collision = false;
    BoxCollider2D boxCollider;
    Rigidbody2D rigidBody;
    CircleCollider2D circle;

    Transform[] path;

    public Direction direction;
    public int speed;

    public enum Direction
    {
        NORTH,
        SOUTH,
        WEST,
        EAST
    }


	// Use this for initialization
	void Start () {

        direction = Direction.NORTH;
        myTransform = GetComponent<Transform>();
        boxCollider = GetComponent <BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
        circle = GetComponent<CircleCollider2D>();
    }
	public Vector2 aPosition1 = new Vector2(3, 3);
	// Update is called once per frame
	void Update () {
        GetComponent<SpriteRenderer>().color = Color.green;
         if(direction==Direction.EAST)
         myTransform.Translate(new Vector2(1*Time.deltaTime *speed,0*Time.deltaTime));
         else if(direction==Direction.WEST)
             myTransform.Translate(new Vector2(-1 * Time.deltaTime * speed, 0 * Time.deltaTime));
         else if (direction == Direction.NORTH)
             myTransform.Translate(new Vector2(0 * Time.deltaTime, 1 * Time.deltaTime * speed));
         else if (direction == Direction.SOUTH)
             myTransform.Translate(new Vector2(0 * Time.deltaTime, -1 * Time.deltaTime * speed));
        //Vector2 test = new Vector2(myTransform.position.x, myTransform.position.y);
        //Debug.Log(test);
        //Collider2D[] hitColliders = Physics2D.OverlapCircleAll(new Vector2(myTransform.position.x,myTransform.position.y), 2);
        // Debug.Log(hitColliders[1]);
        //Destroy(hitColliders[1]);
        /*foreach (Collider2D col in hitColliders)
        {
            if (col.tag == "Wall")
            {
                Destroy(col.gameObject);
            }
        }
        Debug.DrawLine(new Vector3(myTransform.position.x, myTransform.position.y, 0), new Vector3(myTransform.position.x +2, myTransform.position.y+2 , 0));*/

        // myTransform.position = Vector2.MoveTowards(new Vector2(myTransform.position.x, myTransform.position.y), aPosition1, 3 * Time.deltaTime);

       // bool test = Physics2D.Raycast(myTransform.position, new Vector3(myTransform.position.x+1, 0, 0));
       // Debug.DrawRay(myTransform.position, new Vector3(myTransform.position.x , 0 ,0), Color.blue,2,false);

       // if (test)
           // Debug.Log("dddddddd");
    }
   
    

void OnCollisionEnter2D(Collision2D col)
    {
       
        /* Direction newDir = Direction.WEST;

         float randomVal = Random.value * 10;

         if (randomVal <= 2)
         {
             newDir = Direction.NORTH;
         }
         else if (randomVal >= 3 && randomVal < 5)
         {
             newDir = Direction.SOUTH;
         }
         else if (randomVal >= 5 && randomVal < 7)
         {
             newDir = Direction.EAST;
         }
         else if (randomVal >= 9)
         {
             newDir = Direction.WEST;
         }

         if (newDir == direction)
         {

         }
         else direction = newDir;*/
        Collider2D collider = col.collider;

       


        Vector3 contactPoint = col.contacts[0].point;
        Vector3 center = collider.bounds.center;

        bool right = contactPoint.y > center.y;
        bool top = contactPoint.x > center.x;

       // Debug.Log(right + " " + top);
       if(top==true && direction == Direction.NORTH)
        {
            myTransform.Translate(new Vector2(0 * Time.deltaTime * speed, -10 * Time.deltaTime));
            Debug.Log("North");
            direction = Direction.EAST;
        }
        else if(top==false && direction == Direction.SOUTH)
        {
            myTransform.Translate(new Vector2(0 * Time.deltaTime * speed, 10 * Time.deltaTime));
            Debug.Log("South");
            direction = Direction.WEST;
        }
        else if (right == true && direction == Direction.EAST)
        {
            myTransform.Translate(new Vector2(-10 * Time.deltaTime * speed, 0 * Time.deltaTime));
            Debug.Log("East");
            direction = Direction.SOUTH;
        }
        else if (top == false && direction == Direction.WEST)
        {
            myTransform.Translate(new Vector2(10 * Time.deltaTime * speed, 0 * Time.deltaTime));
            Debug.Log("West");
            direction = Direction.NORTH;
        }
        /* if(top && direction == Direction.NORTH)
         {
             myTransform.Translate(new Vector2(0 * Time.deltaTime, -5 * Time.deltaTime * speed));
             Debug.Log("NORTH TOP GOING RIGHT");
             direction = Direction.EAST;
             return;
         }
         else if(!top && direction == Direction.SOUTH)
         {
             myTransform.Translate(new Vector2(0 * Time.deltaTime,  5* Time.deltaTime * speed));
             Debug.Log("SOUTH BOTTOM GOING WEST");
             direction = Direction.WEST;
             return;
         }
         else if(right && direction == Direction.EAST)
         {
             myTransform.Translate(new Vector2(-5 * Time.deltaTime * speed, 0 * Time.deltaTime));
             Debug.Log("EAST RIGHT GOING DOWN");
             direction = Direction.SOUTH;
             return;
         }
         else if(!right && direction == Direction.WEST)
         {
             myTransform.Translate(new Vector2(5 * Time.deltaTime * speed, 0 * Time.deltaTime));
             Debug.Log("WEST LEFT GOING UP");
             direction = Direction.NORTH;
         }*/



        /*if (!top && direction==Direction.NORTH)
        {
            myTransform.Translate(new Vector2(0 * Time.deltaTime, -1 * Time.deltaTime * speed));
            direction = Direction.EAST;
            Debug.DrawLine(contactPoint, center, new Color(0.5f, 0.5f, 0.5f));
        }
        else if(top && direction == Direction.SOUTH)
        {
            myTransform.Translate(new Vector2(0 * Time.deltaTime, 1 * Time.deltaTime * speed));
            direction = Direction.WEST;
            Debug.DrawLine(contactPoint, center, new Color(0.5f, 0.5f, 0.5f));
        }

       else if (!right && direction == Direction.EAST)
        {
            myTransform.Translate(new Vector2(-2 * Time.deltaTime * speed, 0 * Time.deltaTime));

            direction = Direction.SOUTH;
            Debug.DrawLine(contactPoint, center, new Color(0.5f, 0.5f, 0.5f));
        }
        else if(right && direction == Direction.WEST)
        {
            myTransform.Translate(new Vector2(2 * Time.deltaTime * speed, 0 * Time.deltaTime));

            direction = Direction.NORTH;
            Debug.DrawLine(contactPoint, center, new Color(0.5f, 0.5f, 0.5f));
        }*/
    }

    private Direction randomDirection (Direction newDir)
    {
        float randomVal = Random.value * 10;
        Debug.Log(randomVal);
        if (randomVal < 3)
        {
            newDir = Direction.NORTH;
        }
        else if (randomVal >= 3 && randomVal < 5)
        {
            newDir = Direction.SOUTH;
        }
        else if (randomVal >= 5 && randomVal < 7)
        {
            newDir = Direction.EAST;
        }
        else if (randomVal >= 7)
        {
            newDir = Direction.WEST;
        }
        return newDir;
    }
}
