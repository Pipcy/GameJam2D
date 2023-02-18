using UnityEngine;
using UnityEngine.SceneManagement;
public class FlippedGravMovement : MonoBehaviour
{

    [SerializeField]private float speed;
    private Rigidbody2D body;
    private bool grounded; 
    private bool levelEnd; 

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2 (horizontalInput * -speed, body.velocity.y);

        Debug.Log(grounded);
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        
            if (levelEnd) 
            SceneManager.LoadScene(sceneName: "Ending");
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

    
    
}

