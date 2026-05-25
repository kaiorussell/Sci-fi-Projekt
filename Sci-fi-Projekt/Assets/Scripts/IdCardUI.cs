using TMPro;
using UnityEngine;

public class IdCardUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textObject;

    private GameObject currentEmployee;
    private string currentEFirstName;
    private string currentELastName;
    private string currentEDepartment;
    private string currentEPOB;
    private string currentEDOB;
    private Sprite currentESprite;

    [SerializeField] public GameObject card;

    private void Awake()
    {
       currentEmployee = GameObject.FindGameObjectWithTag("Employee");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            card.SetActive(!card.activeSelf);
        }
        GetCurrentEmployeeData();
        textObject.text = $"Name: {currentEFirstName} {currentELastName}\r\nDepartment: {currentEDepartment}\r\nP.O.B: {currentEPOB}\r\nD.O.B: {currentEDOB}";
    }

    private void GetCurrentEmployeeData()
    {
        currentEmployee = GameObject.FindGameObjectWithTag("Employee");
        currentEFirstName = currentEmployee.GetComponent<EmployeeData>().eFirstName;
        currentELastName = currentEmployee.GetComponent<EmployeeData>().eLastName;
        currentEDepartment = currentEmployee.GetComponent<EmployeeData>().eDepartment;
        currentEPOB = currentEmployee.GetComponent<EmployeeData>().ePOB;
        currentEDOB = currentEmployee.GetComponent<EmployeeData>().eDOB;
    }
}
