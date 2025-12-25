using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationDegreePerSecond;

    private void Update()
    {
        Transform();
    }
    private void Transform()
    {
        transform.Rotate(0, _rotationDegreePerSecond * Time.deltaTime, 0);
    }
}
