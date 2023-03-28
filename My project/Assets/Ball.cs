using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test
public class Ball : MonoBehaviour
{
    [SerializeField] private float growthRate = 0.5f;
    [SerializeField] private float shrinkRate = 0.5f;
    [SerializeField] private float maxSize = 3f;
    [SerializeField] private float minSize = 1f;

    private bool isGrowing = true;

    void Update()
    {
        float sizeChange = isGrowing ? growthRate * Time.deltaTime : -shrinkRate * Time.deltaTime;
        transform.localScale += new Vector3(sizeChange, sizeChange, sizeChange);

        if (transform.localScale.x >= maxSize)
        {
            isGrowing = false;
        }
        else if (transform.localScale.x <= minSize)
        {
            isGrowing = true;
        }
    }
}

