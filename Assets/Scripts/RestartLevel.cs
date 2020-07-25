using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour{
    public float gravityStrength;


    public void restartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Fixing increased gravity on restart.
        gravityStrength -= 12;

        // Restore normal gravity
        Physics2D.gravity = new Vector2(0, -gravityStrength);
    }
}
