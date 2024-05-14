using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private List<GameObject> _objectsToSpawn = new List<GameObject>();
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _minTimeSpawn;
    [SerializeField] private float _maxTimeSpawn;

    void Start()
    {
        InvokeRepeating(nameof(CreateObject), _timeSpawn, Random.Range(_minTimeSpawn, _maxTimeSpawn));
    }

    private void CreateObject()
    {
        Instantiate(_objectsToSpawn[Random.Range(0, _objectsToSpawn.Count)], transform.position, Quaternion.identity);
    }
}
