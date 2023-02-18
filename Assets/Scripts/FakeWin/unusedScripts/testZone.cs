using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testZone : MonoBehaviour
{
    // Start is called before the first frame update
    public bool hoverOnFile;
    void Start()
    {
        hoverOnFile = false;
    }
    void Update()
    {
        //Debug.Log(hoverOnFile);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.transform.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            hoverOnFile = true;
        }
    }
}
