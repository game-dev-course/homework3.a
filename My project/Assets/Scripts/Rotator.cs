/*

Description: This script rotates an object around a fixed point
using a sinusoidal function. This can be used to simulate
circular motion, such as planets orbiting a star.
This version is adapted to Arduino Mode and uses functions from
the Arduino Library to control the rotation.
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rotator : MonoBehaviour
{
    // Serialized Fields
    [SerializeField] private float rotationSpeed = 3f; // speed of the rotation in radians per second
    [SerializeField] private float radius = 2f; // radius of the rotation circle in meters

    private Vector3 center;
    private float angle;

    // Update is called once per frame
    private void Start()
    {

        center = transform.position;
        angle = 0f;
    }

    // Update rotation angle
    private void Update()
    {
        // Calculate new position of the object
        angle += rotationSpeed * Time.deltaTime;
        float x = center.x + radius * Mathf.Sin(angle);
        float y = center.y + radius * Mathf.Cos(angle);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}

