using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    [SerializeField] private float _frequence;
    [SerializeField] private float _amplitude;

    private Vector3 _startPosition;
    private float _time;
    private float _offset;

    void Start()
    {
        _offset = 0f;
        _time = 0f;
        _startPosition = transform.position;
    }

    void Update()
    {
        _time += Time.deltaTime;
        _offset = _amplitude * Mathf.Sin(_time * _frequence);

        transform.position = _startPosition + new Vector3(0, _offset, 0);
    }
}
