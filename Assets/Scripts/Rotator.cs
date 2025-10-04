using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void FixedUpdate()
    {
        RotateSelf();
    }

    private void RotateSelf()
    {
        transform.Rotate(Vector3.up * _rotationSpeed);
    }
}
