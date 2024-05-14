using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private ParticleSystem _bloodySplash;
    [SerializeField] private float _frequence;
    [SerializeField] private float _amplitude;
    [SerializeField] private float _maxLifeTime;

    private Vector3 _startPosition;
    private float _time;
    private float _offsetY;
    private float _offsetX;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _offsetY = 0f;
        _offsetX = 0f;
        _time = 0f;
        _startPosition = transform.position;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Fish>() != null)
        {
            _bloodySplash.Play();
            _renderer.enabled = false;
            Invoke(nameof(DestroyOnCollision), 2);
        }
    }

    private void DestroyOnCollision()
    {
        Destroy(gameObject);
    }
}
