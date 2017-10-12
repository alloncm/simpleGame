
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    public bool GameEnded;
    public float DelayTime = 1f;
	// Use this for initialization
	void Start ()
    {
        GameEnded = false;
	}
	
    public void EndGame()
    {
        if(!GameEnded)
        {
            GameEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", DelayTime);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
