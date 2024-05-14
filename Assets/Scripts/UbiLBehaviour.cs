using UnityEngine;
using UnityEngine.SceneManagement;

public class UbiLBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _winMessage;

    private string _winCollisionTag = "Water";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _winCollisionTag)
        {
            Instantiate(_winMessage);
            Invoke(nameof(LoadFinishLevel), 4f);
        }
    }

    private void LoadFinishLevel()
    {
        SceneManager.LoadScene("Finish");
    }
}
