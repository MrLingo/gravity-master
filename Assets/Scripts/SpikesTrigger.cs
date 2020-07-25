using UnityEngine;

public class SpikesTrigger : MonoBehaviour{
    public GameObject gameOverPopUp;    


    void Start(){
        Time.timeScale = 1f;
    }


    private void OnTriggerEnter2D(Collider2D collider){   
	    // Freeze level.
        Time.timeScale = 0f;
        gameOverPopUp.gameObject.SetActive(true);
        Debug.Log("Game Over!");
    }
}
