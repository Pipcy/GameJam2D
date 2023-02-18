using UnityEngine;
using UnityEngine.SceneManagement;

public class HappyDogMovement : MonoBehaviour
{

    [SerializeField]private float speed;
    private Rigidbody2D body;
    private bool touchWall; 
    private bool levelEnd; 

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * speed, body.velocity.y);

        Debug.Log(touchWall);
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        
            if (levelEnd)
            SceneManager.LoadScene("Ending"); 
            Debug.Log(levelEnd);

            if (touchWall)
            SceneManager.LoadScene("Dead"); 
            Debug.Log(touchWall);
    }   
      private void Jump()
        {
             body.velocity = new Vector2(body.velocity.x,speed);
              
        } 

   
    private void OnCollisionStay2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "Ground")
        {
            touchWall = true;
        }

        if (collision.gameObject.tag == "EndWall")
        { 
            levelEnd = true; 
        }
    }

 
    
    
}

