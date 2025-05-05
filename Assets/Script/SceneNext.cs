using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class SceneNext : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Inspector'dan atayabilirsin
    public string nextSceneName;    // Geçmek istediğin sahnenin adı

    void Start()
    {
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        // Video bittiğinde "OnVideoEnd" fonksiyonunu çağır
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
