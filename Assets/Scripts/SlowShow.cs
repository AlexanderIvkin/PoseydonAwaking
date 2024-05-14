using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowShow : MonoBehaviour
{
    private float _timer;
    private SpriteRenderer _renderer;
    private Color _baseColor;
    private Color _finalColor;

    private void Start()
    {
        _timer = 0;
        _renderer = GetComponent<SpriteRenderer>();
        _baseColor = _renderer.color;

        _finalColor = new Color(_baseColor.r, _baseColor.g, _baseColor.b, 255f);
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        _renderer.color = Color.Lerp(_baseColor, _finalColor, _timer/200f);
    }
}
