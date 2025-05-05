using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoScenes: MonoBehaviour

    //Burdaki fonksiyon ile sahneler aras�nda ge�i� sa�lan�yor.
{
    public void goToScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
 
}
