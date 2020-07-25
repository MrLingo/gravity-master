using UnityEngine;

public class CompleteLevel : MonoBehaviour{
    public GameObject exitLevelIcon;
    public GameObject levelCompletedPopUp;
    public Joystick joystick;
    public GravityManipulator gm;


    void Start(){
        Time.timeScale = 1f;
        exitLevelIcon.SetActive(false);
    }


    private void Update(){       
        // If player has reached the door and clicked down and the gravity is pulling downwards - Level completed!
        if (exitLevelIcon.activeSelf && Input.GetKeyDown(KeyCode.DownArrow) && gm.isGravityDown()){
            levelCompletedPopUp.gameObject.SetActive(true);
            // Freeze level.
            Time.timeScale = 0f;
            Debug.Log("Level completed");
        }
    }


    public void CompleteOnBtnClicked(){
        if(exitLevelIcon.activeSelf && gm.isGravityDown()){
            levelCompletedPopUp.gameObject.SetActive(true);
            // Freeze level.
            Time.timeScale = 0f;
            Debug.Log("Level completed");
        }
    }


    private void OnTriggerEnter2D(Collider2D collider){
        exitLevelIcon.SetActive(true);
    }


    private void OnTriggerExit2D(Collider2D collider){
        exitLevelIcon.SetActive(false);
    }
}
