using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRandomer : MonoBehaviour
{

    [SerializeField] private float _minScaleFactor;
    [SerializeField] private float _maxScaleFactor;

    void Start()
    {
        transform.localScale = transform.localScale * Random.Range(_minScaleFactor, _maxScaleFactor);
    }
}
