using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject pausePopUp;
    public Joystick joystick;

    private Vector3 _characterScale;
    private Rigidbody2D _rigidbody;
    private Animator _anim;
    private float _horizontalMove = 0f;

    void Start(){
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _anim.speed -= 0.90f;
    }


    void Update()
    {
        //IsGamePaused();

        // Player movement.
        transform.Translate(Input.GetAxis("Horizontal") * 200f * Time.deltaTime, 0f, 0f);

        _horizontalMove = joystick.Horizontal * 200f;

        // Init walking/running_animation 
        if (Input.GetAxisRaw("Horizontal") == 0 && !Input.GetButtonDown("Jump"))
        {
            _anim.speed = 0.5f;
            _anim.SetBool("isRunning", false);
        }

        // Jumping is taken care of in the GravityManipulator script, because it's highly correlated with gravity.

        // Flip player sprite and activate walking/running animation when right or left keys are triggered.
        _characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0 || _horizontalMove <= -.2f) {

            // Increase animator speed when walking/running.
            _anim.speed = 1.0f;
            _anim.SetBool("isRunning", true);
            _characterScale.x = -35;
        }

        if (Input.GetAxis("Horizontal") > 0 || _horizontalMove >= .2f)
        {
            _anim.speed = 1.0f;
            _anim.SetBool("isRunning", true);
            _characterScale.x = 35;
        }

        transform.localScale = _characterScale;
    }
}