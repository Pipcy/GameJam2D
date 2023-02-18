 using UnityEngine;

//3.1 
//Object with this code will disappear when mouse hover over or when player is here
public class MouseHoverOpposite : MonoBehaviour
{
    private Rigidbody2D body;
    private void Start() {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    void OnMouseOver()
    {
        // do mouse hover stuff
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Mouse is over GameObject.");
    }
   void OnMouseExit()
   {
       // reset to normal
       gameObject.GetComponent<SpriteRenderer>().enabled = true;
       Debug.Log("Mouse is no longer on GameObject.");
   }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.transform.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}