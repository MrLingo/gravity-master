using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseGamePopUp;
    public GameObject player;
    public static bool GameIsPaused = false;


    void Start(){
        Time.timeScale = 1f;
    }


    // Resume game and unfreeze level.
    public void ResumeGame(){
        pauseGamePopUp.gameObject.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("Game resumed");
    }


    void Update(){
        // On pause execute the following snippet.
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Game paused");
            // Freeze level.
            Time.timeScale = 0f;
            pauseGamePopUp.gameObject.SetActive(true);
        }

    }


    public void PauseGameOnButtonPress(){
        Debug.Log("Game paused");
        Time.timeScale = 0f;
        pauseGamePopUp.gameObject.SetActive(true);
    }


    public void GoToMainMenu(){
        SceneManager.LoadScene(0);
    }
}
