using UnityEngine;
using UnityEngine.SceneManagement;
public class MouseyMovements : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5;
    private bool levelEnd; 
     void Start()
    {
    
        
    }
    void Update()
    {
        // makes the fake cursor sprite follow the real cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);

        if (levelEnd) 
         SceneManager.LoadScene(sceneName: "Ending");
    }
    private void OnCollisionStay2D(Collision2D collision)
    { 

        if (collision.gameObject.tag == "EndWall")
        { 
            levelEnd = true; 
        }
    }
}

