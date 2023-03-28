/*

Description: This script controls the visibility of a GameObject with a SpriteRenderer component
The object can be hidden or shown by pressing the "P" key on the keyboard
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    // Private Fields
    private bool isHidden = false; // whether the object is currently hidden or not

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code goes here
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the "P" key has been pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Toggle the isHidden flag
            isHidden = !isHidden;

            // Set the visibility of the object based on the isHidden flag
            GetComponent<SpriteRenderer>().enabled = !isHidden;
        }
    }

}
