using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player1"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Player2Win");
        }
        else if (collision.CompareTag("Player2"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Player1Win");
        }
    }
}
