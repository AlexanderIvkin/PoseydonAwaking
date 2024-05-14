using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _waves;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _minTime;
    [SerializeField] private float _maxTime;

    void Start()
    {
        InvokeRepeating(nameof(CreateWave), _timeSpawn,Random.Range(_minTime, _maxTime));
    }

    private void CreateWave()
    {
        Instantiate(_waves[Random.Range(0, _waves.Count)], transform.position, Quaternion.identity);
    }
}
