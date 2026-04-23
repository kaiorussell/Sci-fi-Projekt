using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene(0);
    }
}
