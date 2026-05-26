using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void GoToGame()
    {
        GameManager.Instance.health = GameManager.Instance.maxHealth;
        SceneManager.LoadScene(1);
    }
}
