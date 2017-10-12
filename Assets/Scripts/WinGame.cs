using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {

    public GameObject panel;
	void OnTriggerEnter()
    {
        FindObjectOfType<playerMvement>().enabled = false;
        panel.SetActive(true);
    }
}
