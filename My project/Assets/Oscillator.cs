using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float amplitude = 7f;
    [SerializeField] private float frequency = 1f;
    [SerializeField] private float speedChangeRate = 1f;
    [SerializeField] private Vector3 axis = Vector3.left;

    private float speed;
    private float timeElapsed;

    private Vector3 source;

    private void Start()
    {
        source = transform.position;
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        float location = Mathf.Sin(timeElapsed * frequency) * amplitude;

        Vector3 newPosition = source + axis * location;

        speed = Mathf.Lerp(speed, Mathf.Sign(location) * Mathf.Abs(speed - speedChangeRate * Time.deltaTime), Time.deltaTime);

        transform.position = newPosition;

    }
}
