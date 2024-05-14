using UnityEngine;

public class AppeareInTime : MonoBehaviour
{
    private float _timer;

    private Renderer _renderer;
    private Color _currentColor;
    private Color _finalColor;
    private float _lerpFactor;

    private void Start()
    {
        _timer = 0f;

        _renderer = GetComponent<Renderer>();

        _currentColor = _renderer.material.color;

        _finalColor = new Color(_currentColor.r, _currentColor.g, _currentColor.b, 255f);
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        _lerpFactor = _timer / 5f;

        

            _renderer.material.color = Color.Lerp(_currentColor, _finalColor, _lerpFactor);
        
    }
}
