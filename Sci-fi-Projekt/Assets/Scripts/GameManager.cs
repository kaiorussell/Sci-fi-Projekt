using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private int maxHealth = 3;
    public int health;
    private int startDifficulty = 2;
    public int difficulty;
    private GameObject employee;

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }
    private void Awake()
    {
        score.currentScore = 0;
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        health = maxHealth;
        difficulty = startDifficulty;
    }

    public void LoseHealth()
    {
        health--;
        if (health <= 0)
        {
            Lose();
        }
    }

    public void Lose()
    {
        Debug.Log("YOU HAVE COMPLETELY LOST");
        SceneManager.LoadScene(1);
    }
}