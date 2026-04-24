using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    [SerializeField] private Score score;
    void Start()
    {
        textMesh.text = $"Score: {score.currentScore}\r\nYou're Fired!";
    }
}
