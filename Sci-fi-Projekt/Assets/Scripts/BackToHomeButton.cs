using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHomeButton : MonoBehaviour
{
   public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }
}
