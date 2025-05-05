using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameClass : MonoBehaviour
{
    private Scene _scene;

    private void Awake()
    {
        _scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
    }

    public void StartGame()
    {
        Debug.Log("StartGame fonksiyonu �a�r�ld�."); // Konsola yaz� yazar

        // T�m sesleri durdur
        StopAllAudio();

        // Yeni sahneyi y�kle
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    private void StopAllAudio()
    {
        // Sahnedeki t�m AudioSource bile�enlerini bul ve durdur
        AudioSource[] allAudioSources = Object.FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        foreach (AudioSource audio in allAudioSources)
        {
            audio.Stop();
        }
    }
}
