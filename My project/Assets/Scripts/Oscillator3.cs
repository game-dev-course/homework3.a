/*

Description: This script controls the oscillation of a GameObject along a specified axis
The oscillation speed and amplitude can be adjusted with public fields
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator3 : MonoBehaviour
{
    // Serialized Fields
    [SerializeField] private float amplitude = 7f; // amplitude of the oscillation
    [SerializeField] private float frequency = 2f; // frequency of the oscillation
    [SerializeField] private float speedChangeRate = 1f; // rate at which the oscillation speed changes
    [SerializeField] private Vector3 axis = Vector3.right; // axis along which the object oscillates

    // Private Fields
    private float speed; // current speed of the oscillation
    private float timeElapsed; // time elapsed since the oscillation started
    private Vector3 source; // initial position of the object

    // Start is called before the first frame update
    private void Start()
    {
        source = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        // Update the time elapsed since the oscillation started
        timeElapsed += Time.deltaTime;

        // Calculate the current location of the oscillation along the specified axis
        float location = Mathf.Sin(timeElapsed * frequency) * amplitude;

        // Calculate the new position of the object based on the current location and axis
        Vector3 newPosition = source + axis * location;

        // Calculate the new speed of the oscillation based on the current location and speedChangeRate
        speed = Mathf.Lerp(speed, Mathf.Sign(location) * Mathf.Abs(speed - speedChangeRate * Time.deltaTime), Time.deltaTime);

        // Update the position of the object
        transform.position = newPosition;
    }

}
