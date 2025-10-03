using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Transformations : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    [SerializeField] private float _rotationSpeed;

    [SerializeField] private float _transformationSpeed;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;

    [SerializeField] private float _tranformationEqualOffset = 0.2f;

    private Vector3 _maxScaleVector;
    private Vector3 _minScaleVector;

    private Vector3 _currentScaleTarget;

    private void Start()
    {
        _maxScaleVector = new Vector3(_maxScale, _maxScale, _maxScale);
        _minScaleVector = new Vector3(_minScale, _minScale, _minScale);

        _currentScaleTarget = _maxScaleVector;
    }

    private void Update()
    {
        Scaling();
        Rotating();
    }

    private void FixedUpdate()
    {
        Moving();
    }

    private void Moving()
    {
        transform.position += transform.forward * _moveSpeed * Time.fixedDeltaTime;
    }

    private void Rotating()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    private void Scaling()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _currentScaleTarget, Time.deltaTime * _transformationSpeed);

        if (Vector3.Distance(transform.localScale, _currentScaleTarget) < _tranformationEqualOffset)
        {
            if (_currentScaleTarget == _maxScaleVector)
            {
                _currentScaleTarget = _minScaleVector;
            }
            else
            {
                _currentScaleTarget = _maxScaleVector;
            }
        }
    }
}
