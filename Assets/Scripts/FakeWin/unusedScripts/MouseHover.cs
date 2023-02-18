 using UnityEngine;

//3.1
//object will appear when mouse hover over
public class MouseHover : MonoBehaviour
{
    private void Start() {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
    void OnMouseOver()
    {
        // do mouse hover stuff
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Mouse is over GameObject.");
    }
 
   void OnMouseExit()
   {
       // reset to normal
       gameObject.GetComponent<SpriteRenderer>().enabled = false;
       Debug.Log("Mouse is no longer on GameObject.");
   }
}