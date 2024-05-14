using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private ParticleSystem _bloodySplash;
    [SerializeField] private float _maxLifeTime;

    private float _timer;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _timer = 0;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _maxLifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _bloodySplash.Play();
        Deactivate();
        Invoke(nameof(SelfDestroy), 1f);
    }

    private void SelfDestroy()
    {
        Destroy(gameObject);
    }

    private void Deactivate()
    {
        GetComponent<Renderer>().enabled = false;
        _rigidbody2D.simulated = false;
    }
}
