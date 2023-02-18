using UnityEngine;
using UnityEngine.SceneManagement;
public class FlippedPathMovement : MonoBehaviour
{

    private float speed = 7;
    private float moveSpeed = 10;
    private Rigidbody2D body;
    private bool grounded; 
    private bool levelEnd; 
    private bool controlChange;
    //for checkpoint
    private Transform currentCheckpoint;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * -speed, body.velocity.y);

            if (Input.GetKey(KeyCode.Space) && grounded)
            {
                Jump();
            }

            if (controlChange)
            {
                speed = 0;
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
                transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
            }
            if (levelEnd) 
            SceneManager.LoadScene(sceneName: "GameError");

            //die when fall
            if (transform.position.y < -5f)
            {
                Debug.Log("die");
                transform.position = currentCheckpoint.position + new Vector3(0,3,0);
            }


    }   
   
    private void Jump()
        {
             body.velocity = new Vector2(body.velocity.x,speed);
             grounded = false; 
        } 

   
    private void OnCollisionStay2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }

        if (collision.gameObject.tag == "EndWall")
        { 
            levelEnd = true; 
        }
        if (collision.gameObject.tag == "ControlChange")
        { 
            controlChange = true; 
        }
    }

    private void OnTriggerEnter(Collider other)
    { 
        controlChange = true;
    }

    //detect checkpoint
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.transform.tag == "checkpoint") 
        {
            Debug.Log("checkpoint detected");
            currentCheckpoint = collision.transform; 
        }
    }

    
    
}

