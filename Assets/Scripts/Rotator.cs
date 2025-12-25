using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationDegreePerSecond;

    private void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        transform.Rotate(0, _rotationDegreePerSecond * Time.deltaTime, 0);
    }
}
