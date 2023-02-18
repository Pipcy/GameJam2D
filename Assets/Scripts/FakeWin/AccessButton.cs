using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessButton : MonoBehaviour
{
    public Button Access;
    //public Menu menu;
    PlayerMovementFlat PMF;
    

    void Start()
    {
        Access.interactable = false;
        PMF = GameObject.Find("Player").GetComponent<PlayerMovementFlat>();
    }
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PMF.hoverOnFile);
        if (PMF.hoverOnFile == true)
        {
            AccessGranted();
        }
        else
        {
            AccessDenied();
        }
    }

    void AccessGranted()
    {
        Access.interactable = true;
        //Debug.Log("access granted.");
    }

        void AccessDenied()
    {
        Access.interactable = false;
        //Debug.Log("access denied.");
    }

}
