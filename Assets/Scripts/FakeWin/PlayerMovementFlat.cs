using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//3.3
public class PlayerMovementFlat : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;
    public bool hoverOnFile;

    private Animator anim;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        hoverOnFile = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector2 (horizontalInput * speed, verticalInput * speed);

        anim.SetBool("run", horizontalInput != 0 || verticalInput != 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collide!");
        if(collision.transform.tag == "File")
        {
            hoverOnFile = true;
            Debug.Log("File!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hoverOnFile = false;
    }
}