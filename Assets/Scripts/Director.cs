using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Director : MonoBehaviour
{
    [SerializeField] private List<GameObject> _slides;
    [SerializeField] private float _showTime;

    [SerializeField] private GameObject _musicSource;
    [SerializeField] private GameObject _titriSlide;


    private void Start()
    {
        StartCoroutine(ShowSlides());
        StartCoroutine(StartMusic());
    }

    IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(_showTime - 2f);

        if (SceneManager.GetActiveScene().name != "Finish")
        {
            _musicSource.GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator ShowSlides()
    {
        foreach (GameObject slide in _slides)
        {
            Instantiate(slide);

            yield return new WaitForSeconds(_showTime);
        }

        if (SceneManager.GetActiveScene().name != "Finish")
        {
            LoadGameLevel();
        }

    }

    private void LoadGameLevel()
    {
        DontDestroyOnLoad(_musicSource);
        SceneManager.LoadScene("Game");
    }
}
