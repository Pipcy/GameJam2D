using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("Frowny"); 
        }

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Frowny"); 
        }
    }
}
