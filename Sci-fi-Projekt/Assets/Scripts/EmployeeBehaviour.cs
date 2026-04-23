using System.Collections;
using UnityEngine;

public class EmployeeBehaviour : MonoBehaviour
{
    private EmployeeData employeeData;
    [SerializeField] private Score score;

    private float waitForNewEmployee = 3f;

    private void Awake()
    {
        employeeData = GetComponent<EmployeeData>();
    }
    void Start()
    {

        employeeData.isAlien = Random.value < 0.5f;

        StartCoroutine(NewEmployee());
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (employeeData.isAlien)
            {
                Debug.Log("Right guess");
                score.currentScore++;
            }
            else
            {
                Debug.Log("Wrong guess");
                GameManager.Instance.LoseHealth();
            }
            StartCoroutine(NewEmployee());
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (employeeData.isAlien)
            {
                Debug.Log("Wrong guess");
                GameManager.Instance.LoseHealth();
            }
            else
            {
                Debug.Log("Right guess");
                score.currentScore++;
            }
            StartCoroutine(NewEmployee());
        }
    }


    private IEnumerator NewEmployee()
    {
        employeeData.Invoke("ResetAll", 0);
        employeeData.Invoke("RandomizeDifficultyChanges", 0);
        employeeData.Invoke("RandomizeAll", 0);
        yield return new WaitForSeconds(waitForNewEmployee);
        GetComponent<Animation>().Play();
    }

}
