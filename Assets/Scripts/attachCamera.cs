using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachCamera : MonoBehaviour {

    public Transform Player;
    public Vector3 pos=new Vector3(0,1,-6);
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.position+pos;
	}
}
