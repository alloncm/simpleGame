using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvement : MonoBehaviour {
    
    public Rigidbody rb;    //it is public so we get access to it through unity
                            //then we must ad to it a Rigigtbody component
    public float forwardMovement = 2000f;

    public float sideMovement = 500f;

    bool moveRight = false;

    bool moveLeft = false;

	// Use this for initialization
	void Start () {
        
    }
	
    void Update()
    {
        moveLeft = false;
        moveRight = false;
        /*
        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        */
        foreach(Touch t in Input.touches)
        {
            if (t.position.x > (Screen.width / 2))
            {
                moveRight = true;
            }
            if (t.position.x < (Screen.width / 2))
            {
                moveLeft = true;
            }
        }
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }

    }
	// Update is called once per frame
    //we are using fixedupdate and not update cause fixed update works better with physics
	void FixedUpdate ()
    {
        //rb.AddForce(0, 0, forwardMovement * Time.deltaTime);

        if (moveRight)
        {
            rb.AddForce(sideMovement * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (moveLeft)
        {
            rb.AddForce(-sideMovement * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
