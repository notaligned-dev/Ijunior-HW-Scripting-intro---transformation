using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        Transform();
    }

    private void Transform()
    {
        transform.position = transform.position + _movingSpeed * Time.deltaTime * transform.forward.normalized;
    }
}
