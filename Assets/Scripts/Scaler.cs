using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scalingPercentPerSecond;

    private Vector3 _scaleValueVector;

    private void Start()
    {
        _scaleValueVector = _scalingPercentPerSecond.ConvertToFraction() * transform.localScale;
    }

    private void Update()
    {
        Transform();
    }

    private void Transform()
    {
        transform.localScale += _scaleValueVector * Time.deltaTime;
    }
}
