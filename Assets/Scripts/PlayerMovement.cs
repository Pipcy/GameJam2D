 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{

    [SerializeField]private float speed;
    private Rigidbody2D body;
    private bool grounded; 
    private bool levelEnd; 

    //for checkpoint
    private Transform currentCheckpoint;

    //for animation
    private Animator anim;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
         anim = GetComponent<Animator>();//**
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * speed, body.velocity.y);

        //Debug.Log(grounded);
        if (Input.GetKey(KeyCode.Space) && (grounded))
        {
            Jump();
        }
    
        if (levelEnd) 
            SceneManager.LoadScene(sceneName: "FakeWin");

        //die when fall
        if (transform.position.y < -5f)
        {
            Debug.Log("die");
            transform.position = currentCheckpoint.position + new Vector3(0,3,0);
        }
        //animation
        anim.SetBool("run", horizontalInput != 0);
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

