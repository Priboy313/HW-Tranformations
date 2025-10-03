using UnityEngine;

public class SphereTransformations : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        Moving();
    }

    private void Moving()
    {
        transform.position += transform.forward * _moveSpeed * Time.fixedDeltaTime;
    }
}
