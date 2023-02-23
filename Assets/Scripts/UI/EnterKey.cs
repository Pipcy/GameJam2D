//2.13.1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class EnterKey : MonoBehaviour
{

    private void Update() 
    {
        
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("FlippedPath"); 
        }

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Frowny"); 
        }
    } 
}

