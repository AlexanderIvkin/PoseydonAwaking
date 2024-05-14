using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject _powerAccumulationImage;
    [SerializeField] private GameObject _spawn;
    [SerializeField] private List<GameObject> _bullets;
    [SerializeField] private float _currentPower;
    [SerializeField] private float _minPower;
    [SerializeField] private float _maxPower;
    [SerializeField] private float _powerAccumulation;
    [SerializeField] private GameObject _calmar;
    private float _scaleY;
    private Vector3 _baseScale;

    private void Start()
    {
        _scaleY = 1f;
        _baseScale = transform.localScale;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_currentPower <= _maxPower)
            {
                _currentPower += _powerAccumulation;
                _calmar.transform.localScale = _calmar.transform.localScale + new Vector3(_powerAccumulation / 100, _powerAccumulation / 100, _powerAccumulation / 100);
            }

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(_bullets[Random.Range(0, _bullets.Count)], _spawn.transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)))).GetComponent<Rigidbody2D>().AddForce(_spawn.transform.up * _currentPower, ForceMode2D.Impulse);

            _currentPower = _minPower;
            _calmar.transform.localScale = _baseScale;
        }

        _powerAccumulationImage.transform.localScale = new Vector3(_currentPower/5f, _scaleY);

    }
}
