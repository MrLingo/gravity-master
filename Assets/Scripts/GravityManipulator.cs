using UnityEngine;

public class GravityManipulator : MonoBehaviour{
    public Camera mainCamera;  
    public float jumpForce;
    public float gravityStrength;
    public float moveForce;
    private Joystick joystick;

    private Rigidbody2D _rigidbody;
    private bool _gravityUp;
    private bool _gravityDown;
    private bool _gravityRight;
    private bool _gravityLeft;  
    private float _joyStickPosition;
    
    // TODO: Prevent infinite jump

    void Start(){
        // Init gravitational pull is downards.
        _gravityDown = true;
        Physics2D.gravity = new Vector2(0, -gravityStrength);
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Used in CompleteLevel.cs
    public bool isGravityDown(){
        return this._gravityDown;
    }


    void Update(){       
        // Jump settings
        if (Input.GetButtonDown("Jump") && _gravityDown)
        {
            _rigidbody.velocity = Vector3.up * jumpForce;
        }

        if (Input.GetButtonDown("Jump") && _gravityRight)
        {
            _rigidbody.velocity = Vector3.left * jumpForce;
        }

        if (Input.GetButtonDown("Jump") && _gravityUp)
        {
            _rigidbody.velocity = Vector3.down * jumpForce;
        }

        if (Input.GetButtonDown("Jump") && _gravityLeft)
        {
            _rigidbody.velocity = Vector3.right * jumpForce;
        }

        /*
         *  Gravity directions helpful notes: (Example gravity force: 25f)
         *  DOWN - new Vector(0, -25f)
         *  UP - new Vector(0, 25f)
         *  LEFT - new Vector(-25f, 0)
         *  RIGHT - new Vector(25f, 0)
         */

        // Rotation settings.

        // =============== TEST WITH KEYBOARD KEYS ===============
        if (Input.GetKeyDown(KeyCode.E)){   
            // First time pressed
            if (_gravityDown){
                // RIGHT
                _gravityDown = false;
                Physics2D.gravity = new Vector2(gravityStrength, 0);

                transform.rotation = Quaternion.Euler(0, 0, 90);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 90);

                _gravityRight = true;
            }
            else if (_gravityRight){
                // UP
                _gravityRight = false;
                Physics2D.gravity = new Vector2(0, gravityStrength);

                transform.rotation = Quaternion.Euler(0, 0, 180);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 180);

                _gravityUp = true;
            }
            else if (_gravityUp){
                // LEFT
                _gravityUp = false;
                Physics2D.gravity = new Vector2(-gravityStrength, 0);

                transform.rotation = Quaternion.Euler(0, 0, 270);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 270);

                _gravityLeft = true;
            }
            else if (_gravityLeft){
                // DOWN
                _gravityLeft = false;
                Physics2D.gravity = new Vector2(0, -gravityStrength);

                transform.rotation = Quaternion.Euler(0, 0, 360);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 360);

                _gravityDown = true;
            }
        } // KeyCode E


        if (Input.GetKeyDown(KeyCode.Q)){           
            // First time pressed
            if (_gravityDown){
                // LEFT
                _gravityDown = false;
                Physics2D.gravity = new Vector2(-gravityStrength, 0);

                transform.rotation = Quaternion.Euler(0, 0, 270);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 270);

                _gravityLeft = true;
            }
            else if (_gravityLeft){
                // UP
                _gravityLeft = false;
                Physics2D.gravity = new Vector2(0, gravityStrength);

                transform.rotation = Quaternion.Euler(0, 0, 180);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 180);

                _gravityUp = true;
            }
            else if (_gravityUp){
                // RIGHT
                _gravityUp = false;
                Physics2D.gravity = new Vector2(gravityStrength, 0);

                transform.rotation = Quaternion.Euler(0, 0, 90);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 90);

                _gravityRight = true;
            }
            else if (_gravityRight){
                // DOWN
                _gravityRight = false;
                Physics2D.gravity = new Vector2(0, -gravityStrength);

                transform.rotation = Quaternion.Euler(0, 0, 360);
                mainCamera.transform.rotation = Quaternion.Euler(0, 0, 360);

                _gravityDown = true;
            }
        } // keyCode Q    
    } // Update


    // ==================== Jump on UI button clicked ====================

    public void JumpOnBtnClicked(){
        // Jump settings
        if (_gravityDown)
        {
            _rigidbody.velocity = Vector3.up * jumpForce;
        }

        if (_gravityRight)
        {
            _rigidbody.velocity = Vector3.left * jumpForce;
        }

        if (_gravityUp)
        {
            _rigidbody.velocity = Vector3.down * jumpForce;
        }

        if (_gravityLeft)
        {
            _rigidbody.velocity = Vector3.right * jumpForce;
        }

    } // JumpOnBtnClicked


    // ==================== Rotate on UI buttons clicked ====================
    public void RotateE(){
        // First time pressed
        if (_gravityDown){
            // RIGHT
            _gravityDown = false;
            Physics2D.gravity = new Vector2(gravityStrength, 0);

            transform.rotation = Quaternion.Euler(0, 0, 90);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 90);
           
            _gravityRight = true;
        }
        else if (_gravityRight){
            // UP
            _gravityRight = false;
            Physics2D.gravity = new Vector2(0, gravityStrength);

            transform.rotation = Quaternion.Euler(0, 0, 180);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 180);

            _gravityUp = true;
        }
        else if (_gravityUp){
            // LEFT
            _gravityUp = false;
            Physics2D.gravity = new Vector2(-gravityStrength, 0);

            transform.rotation = Quaternion.Euler(0, 0, 270);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 270);

            _gravityLeft = true;
        }
        else if (_gravityLeft){
            // DOWN
            _gravityLeft = false;
            Physics2D.gravity = new Vector2(0, -gravityStrength);

            transform.rotation = Quaternion.Euler(0, 0, 360);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 360);

            _gravityDown = true;
        }
    } // rotateE


    public void RotateQ(){
        // First time pressed
        if (_gravityDown){
            // LEFT
            _gravityDown = false;
            Physics2D.gravity = new Vector2(-gravityStrength, 0);

            transform.rotation = Quaternion.Euler(0, 0, 270);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 270);

            _gravityLeft = true;
        }
        else if (_gravityLeft){
            // UP
            _gravityLeft = false;
            Physics2D.gravity = new Vector2(0, gravityStrength);

            transform.rotation = Quaternion.Euler(0, 0, 180);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 180);

            _gravityUp = true;
        }
        else if (_gravityUp){
            // RIGHT
            _gravityUp = false;
            Physics2D.gravity = new Vector2(gravityStrength, 0);

            transform.rotation = Quaternion.Euler(0, 0, 90);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 90);

            _gravityRight = true;
        }
        else if (_gravityRight){
            // DOWN
            _gravityRight = false;
            Physics2D.gravity = new Vector2(0, -gravityStrength);

            transform.rotation = Quaternion.Euler(0, 0, 360);
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 360);

            _gravityDown = true;
        }
    } // rotateQ
}

