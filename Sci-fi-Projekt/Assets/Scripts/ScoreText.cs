using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private TextMeshPro textMesh;
    [SerializeField] private Score score;
    private void Awake()
    {
        textMesh = GetComponent<TextMeshPro>();
    }
    void Start()
    {
        //SKAL FIKSES//textMesh.text = $"Score: {score.currentScore}";
    }
}
