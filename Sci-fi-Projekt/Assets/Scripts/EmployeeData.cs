using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EmployeeData : MonoBehaviour
{
    public Sprite eSprite;
    private bool isAlien;

    public string eFirstName;
    public string eLastName;
    public string eDepartment;
    public string ePOB;
    public string eDOB;

    private bool[] difficultyChanges =
    {
        false, false, false, false, false
    };

 

    private SpriteRenderer sr;
    [SerializeField]private EmployeeDatabase edb;


    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        RandomizeAll();
        print($"{eFirstName} {eLastName}, {eDepartment}, {ePOB}, {eDOB}");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int n = 0; n < difficultyChanges.Count(); n++)
            {
                Debug.Log(difficultyChanges[n]);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            for (int i = 0; i < EmployeeManager.Instance.difficulty; i++)
            {
                Debug.Log("For Loop start");
                int rand = Random.Range(0, difficultyChanges.Count());
                if (!difficultyChanges[rand])
                {
                    difficultyChanges[rand] = true;
                }
                else
                {
                    i--;
                }
                Debug.Log("For loop end");
            }
        }
    }

    private void ResetAll()
    {
        for (int i = 0; i < difficultyChanges.Length; i++)
        {
            difficultyChanges[i] = false;

        }
    }


    private void RandomizeAll()
    {
        RandomizeFirstName();
        RandomizeLastName();
        RandomizeDepartment();
        RandomizePOB();
        RandomizeDOB();
        RandomizeSprite();
    }
    private void RandomizeFirstName()
    {
        if (difficultyChanges[0])
        {
            eFirstName = edb.alienFirstNames[Random.Range(0, edb.alienFirstNames.Count)];
        }
        else
        {
            eFirstName = edb.employeeFirstNames[Random.Range(0, edb.employeeFirstNames.Count)];
        }
        
    }

    private void RandomizeLastName()
    {
        if (difficultyChanges[1])
        {
            eLastName = edb.alienLastNames[Random.Range(0, edb.alienLastNames.Count)];
        }
        else
        {
            eLastName = edb.employeeLastNames[Random.Range(0, edb.employeeLastNames.Count)];
        }
    }

    private void RandomizeDepartment()
    {
        if (difficultyChanges[2])
        {
            eDepartment = edb.alienDepartment[Random.Range(0, edb.alienDepartment.Count)];
        }
        else
        {
            eDepartment = edb.employeeDepartment[Random.Range(0, edb.employeeDepartment.Count)];
        }
    }

    private void RandomizePOB()
    {
        if (difficultyChanges[3])
        {
            ePOB = edb.alienPOB[Random.Range(0, edb.alienPOB.Count)];
        }
        else
        {
            ePOB = edb.employeePOB[Random.Range(0, edb.employeePOB.Count)];
        }
    }

    private void RandomizeDOB()
    {
        if (difficultyChanges[4])
        {
            eDOB = edb.alienDOB[Random.Range(0, edb.alienDOB.Count)];
        }
        else
        {
            eDOB = edb.employeeDOB[Random.Range(0, edb.employeePOB.Count)];
        }
    }

    private void RandomizeSprite()
    {
        eSprite = edb.sprites[Random.Range(0, edb.sprites.Count)];
        sr.sprite = eSprite;
    }
}
