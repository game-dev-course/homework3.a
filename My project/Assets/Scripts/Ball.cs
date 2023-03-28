/*

Description: This script controls the growth and shrinkage of a ball GameObject in the scene
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Serialized Fields
    [SerializeField] private float growthRate = 0.5f; // rate at which the ball grows
    [SerializeField] private float shrinkRate = 0.5f; // rate at which the ball shrinks
    [SerializeField] private float maxSize = 3f; // maximum size of the ball
    [SerializeField] private float minSize = 1f; // minimum size of the ball

    // Private Fields
    private bool isGrowing = true; // whether the ball is currently growing or shrinking

    // Update is called once per frame
    void Update()
    {
        // Calculate the size change based on whether the ball is growing or shrinking
        float sizeChange = isGrowing ? growthRate * Time.deltaTime : -shrinkRate * Time.deltaTime;

        // Update the scale of the ball
        transform.localScale += new Vector3(sizeChange, sizeChange, sizeChange);

        // Check if the ball has reached its maximum size and should start shrinking
        if (transform.localScale.x >= maxSize)
        {
            isGrowing = false;
        }
        // Check if the ball has reached its minimum size and should start growing again
        else if (transform.localScale.x <= minSize)
        {
            isGrowing = true;
        }
    }
}

