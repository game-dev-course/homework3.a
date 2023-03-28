using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 3f;
    [SerializeField] private float radius = 2f;

    private Vector3 center;
    private float angle;

    private void Start()
    {
        center = transform.position;
        angle = 0f;
    }

    private void Update()
    {
        angle += rotationSpeed * Time.deltaTime;
        float x = center.x + radius * Mathf.Sin(angle);
        float y = center.y + radius * Mathf.Cos(angle);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}

