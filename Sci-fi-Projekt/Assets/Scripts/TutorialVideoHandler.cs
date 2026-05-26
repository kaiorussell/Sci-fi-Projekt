using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class TutorialVideoHandler : MonoBehaviour
{
    private VideoPlayer player;

    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
        player.Play();
        StartCoroutine("Skibidi");
    }

    private IEnumerator Skibidi()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(2);
    }


}
