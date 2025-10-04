using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        ScaleSelf();
    }

    private void ScaleSelf()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale * _scaleSpeed, _scaleSpeed * Time.deltaTime);
    }
}
