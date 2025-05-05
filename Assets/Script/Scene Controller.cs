using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;

    [SerializeField] private Animator transitionAnim;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void NextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    private IEnumerator LoadLevel()
    {
        // Ge�i� animasyonunu ba�lat
        transitionAnim.SetTrigger("End");

        // Animasyonun s�resine g�re bekle (varsay�lan 1 saniye)
        yield return new WaitForSeconds(1f);

        // Yeni sahneyi y�kle (asenkron �ekilde)
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);

        // Yeni sahnede ba�lang�� animasyonu oynat
        transitionAnim.SetTrigger("Start");
    }
}
