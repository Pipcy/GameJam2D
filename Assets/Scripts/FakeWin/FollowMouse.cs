//3.1
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Start()
    {
        // Hides the actual cursor...
        Cursor.visible = false; 
    }
    void Update()
    {
        // makes the fake cursor sprite follow the real cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}