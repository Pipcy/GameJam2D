using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//3.3
public class Player2Movement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;
    public bool hoverOnFile;

    private Animator anim;

    public int maxHealth = 100;
    public int currentHealth;

    //public healthbar healthBar;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        hoverOnFile = false;
        anim = GetComponent<Animator>();

        //currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector2 (horizontalInput * speed, verticalInput * speed);
        if(horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        } else if(horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        anim.SetBool("run", horizontalInput != 0);

        anim.SetBool("run", horizontalInput != 0 || verticalInput != 0);

        if(Input.GetKey(KeyCode.Space))
        {
            //TakeDamage(20);
        }
    }

    // void TakeDamage(int damage)
    // {
    //     currentHealth -= damage;
    //     healthBar.SetHealth(currentHealth);
    // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collide!");
        if(collision.transform.tag == "Frownu")
        {
            SceneManager.LoadScene("Frownu Terminal");

            Debug.Log("Frownu");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hoverOnFile = false;
    }
}