using System.Collections;
using UnityEngine;

public class EmployeeBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject employeeBullet;
    public GameObject lastEmployeeBullet;

    private EmployeeData employeeData;
    [SerializeField] private Score score;

    [SerializeField] private float waitForNewEmployee = 1.5f;

    private void Awake()
    {
        employeeData = GetComponent<EmployeeData>();
    }
    void Start()
    {

        employeeData.isAlien = Random.value < 0.5f;

        StartCoroutine(NewEmployee());
    }


    public void onHumanButtonPress()
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
        CreateBullet();
        StartCoroutine(NewEmployee());
    }

    public void onAlienButtonPress()
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


    private IEnumerator NewEmployee()
    {
        if (GetComponent<Animation>().isPlaying)
        {
            GetComponent<Animation>().Stop();
        }
        employeeData.Invoke("ResetAll", 0);
        yield return new WaitForSeconds(waitForNewEmployee);
        employeeData.Invoke("RandomizeAll", 0);
        GetComponent<Animation>().Play();
    }

    private void CreateBullet()
    {
        Instantiate(employeeBullet);
    }

}
