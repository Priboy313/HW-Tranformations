using UnityEngine;

public class CapsuleTransformations : MonoBehaviour
{
    [SerializeField] private float _transformationSpeed;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;

    [SerializeField] private float _tranformationEqualOffset = 0.2f;

    private Vector3 _maxScaleVector;
    private Vector3 _minScaleVector;

    private Vector3 _currentTarget;

    private void Start()
    {
        _maxScaleVector = new Vector3(_maxScale, _maxScale, _maxScale);
        _minScaleVector = new Vector3(_minScale, _minScale, _minScale);

        _currentTarget = _maxScaleVector;
    }

    private void Update()
    {
        Scaling();
    }

    private void Scaling()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _currentTarget, Time.deltaTime * _transformationSpeed);

        if (Vector3.Distance(transform.localScale, _currentTarget) < _tranformationEqualOffset)
        {
            if (_currentTarget == _maxScaleVector)
            {
                _currentTarget = _minScaleVector;
            }
            else
            {
                _currentTarget = _maxScaleVector;
            }
        }
    }
}
