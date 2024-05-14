using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _frequence;
    [SerializeField] private float _amplitude;
    [SerializeField] private float _maxLifeTime;

    private float _time;
    private float _offsetY;
    private float _offsetX;

    private void Start()
    {
        _offsetY = 0f;
        _offsetX = 0f;
        _time = 0f;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        _offsetY = _amplitude * Mathf.Sin(-_time * _frequence);
        _offsetX = _speed * Time.deltaTime;


        transform.position = transform.position + new Vector3(_offsetX, _offsetY, 0);

        if (_time >= _maxLifeTime)
        {
            Destroy(gameObject);
        }
    }
}
