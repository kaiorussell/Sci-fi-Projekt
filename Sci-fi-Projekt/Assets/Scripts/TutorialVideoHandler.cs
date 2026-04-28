using UnityEngine;
using UnityEngine.Video;

public class TutorialVideoHandler : MonoBehaviour
{
    private VideoPlayer player;

    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
    }

    private void Start()
    {

    }
}
