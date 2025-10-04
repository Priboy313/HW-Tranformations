using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        MoveSelf();
    }

    private void MoveSelf()
    {
        transform.position += transform.forward * _moveSpeed * Time.fixedDeltaTime;
    }
}
