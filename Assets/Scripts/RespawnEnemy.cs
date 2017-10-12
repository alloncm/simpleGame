using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour {

    public Rigidbody rbPlayer;
    public Rigidbody rbEnemy;
    public int Respawn = 20;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (rbPlayer.transform.position.z <= rbEnemy.transform.position.z) 
        {
            int x = Random.Range(-10, 10);
            Vector3 pos = new Vector3(x, rbPlayer.position.y, rbPlayer.position.z+Respawn);
            Debug.Log(pos);
            transform.position = pos;
        }
	}
}
