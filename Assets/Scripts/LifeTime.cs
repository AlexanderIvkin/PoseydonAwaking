using UnityEngine;

public class LifeTime : MonoBehaviour
{
    [SerializeField] private float _maxValue;

    private float _currentValue;
    
    void Update()
    {
        _currentValue += Time.deltaTime;

        if (_currentValue >= _maxValue)
        {
            Destroy(gameObject);
        }
    }
}
