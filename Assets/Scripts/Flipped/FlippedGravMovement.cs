using UnityEngine;
using UnityEngine.SceneManagement;
public class FlippedGravMovement : MonoBehaviour
{

    [SerializeField]private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded; 
    private bool levelEnd; 
    private Transform currentCheckpoint;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * speed, body.velocity.y);
        anim.SetBool("run", horizontalInput != 0);

        Debug.Log(grounded);
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        
            if (levelEnd) 
            SceneManager.LoadScene(sceneName: "Frownu Terminal");

            if (transform.position.y > 34f)
            {
                Debug.Log("die");
                transform.position = currentCheckpoint.position + new Vector3(0,3,0);
            }
    }   
   
    private void Jump()
        {
             body.velocity = new Vector2(body.velocity.x,-speed);
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

