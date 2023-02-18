using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeExit : MonoBehaviour
{
    public int clickCount = 0;
    private Rigidbody2D body;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
        body.bodyType = RigidbodyType2D.Static;
    }
    
    public void fakeExitButton()
    {
        clickCount++;
        Debug.Log(clickCount);
        if(clickCount == 3)
        {
            body.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
