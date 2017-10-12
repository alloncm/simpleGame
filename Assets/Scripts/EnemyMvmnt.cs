using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMvmnt : MonoBehaviour {

    public Rigidbody rb;            //add here a rigiybody
    public float forwardMovement = 500f;
    // Use this for initialization
    void Start () {
        rb.AddForce(0, 0, forwardMovement * Time.deltaTime, ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        
    }
}
