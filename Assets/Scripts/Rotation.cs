using UnityEngine;

public class Rotation : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    [SerializeField] private float _minRotation = 0;
    [SerializeField] private float _maxRotation = 60;
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        float input = -Input.GetAxis(Horizontal);

        float newRotation = transform.rotation.eulerAngles.z + input * _speed;

        float clampedRotation = Mathf.Clamp(newRotation, _minRotation, _maxRotation);

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, clampedRotation);
    }
}
