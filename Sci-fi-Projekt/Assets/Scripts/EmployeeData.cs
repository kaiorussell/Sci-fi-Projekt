using System.Collections.Generic;
using UnityEngine;

public class EmployeeData : MonoBehaviour
{
    public Sprite eSprite;
    public string eName;
    public string eDepartment;
    public string ePOB;
    public string eDOB;

    private SpriteRenderer sr;
    [SerializeField]private EmployeeDatabase edb;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        RandomizeAll();
        print($"{eName}, {eDepartment}, {ePOB}, {eDOB}");
    }

    private void RandomizeAll()
    {
        RandomizeName();
        RandomizeDepartment();
        RandomizePOB();
        RandomizeDOB();
        RandomizeSprite();
    }
    private void RandomizeName()
    {
        eName = edb.EmployeeNames[Random.Range(0, edb.EmployeeNames.Count)];
    }
    
    private void RandomizeDepartment()
    {
        eDepartment = edb.EmployeeDepartment[Random.Range(0, edb.EmployeeDepartment.Count)];
    }

    private void RandomizePOB()
    {
        ePOB = edb.EmployeePOB[Random.Range(0, edb.EmployeePOB.Count)];
    }

    private void RandomizeDOB()
    {
        eDOB = edb.EmployeeDOB[Random.Range(0, edb.EmployeeDOB.Count)];
    }

    private void RandomizeSprite()
    {
        eSprite = edb.sprites[Random.Range(0, edb.sprites.Count)];
        sr.sprite = eSprite;
    }
}
