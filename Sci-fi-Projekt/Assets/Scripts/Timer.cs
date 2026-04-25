using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    private TextMeshProUGUI textComponent;

    [SerializeField] private float maxTime = 120;
    private float timeLeft;
    private int minutesLeft;
    private int secondsLeft;

    private void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        timeLeft = maxTime;
    }

    
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            GameManager.Instance.Lose();
        }
        minutesLeft = Mathf.FloorToInt(timeLeft/60f);
        secondsLeft = Mathf.FloorToInt(timeLeft - minutesLeft * 60f);
        textComponent.text = string.Format("{0:00}:{1:00}", minutesLeft, secondsLeft);
    }
}
