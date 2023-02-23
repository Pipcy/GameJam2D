using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursonVisible : MonoBehaviour
{
     private bool controlChange;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        // Hides the actual cursor...
        Cursor.visible = false; 
    }

    // Update is called once per frame

    void Update()
    {
        // makes the fake cursor sprite follow the real cursor
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;

        if(controlChange)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        } 

    void OnTriggerEnter(Collider other)
    { 
        controlChange = true;
    }
    }
}

