using TMPro;
using UnityEngine;

public class IdCardUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textObject;

    private GameObject currentEmployee = GameObject.FindGameObjectWithTag("Employee");
    private string currentEName;
    private string currentEDepartment;
    private string currentEPOB;
    private string currentEDOB;
    private Sprite currentESprite;

    [SerializeField] private GameObject card;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            card.SetActive(!card.activeSelf);
        }
        GetCurrentEmployeeData();
        textObject.text = $"Name: {currentEName}\r\nDepartment: {currentEDepartment}\r\nP.O.B: {currentEPOB}\r\nD.O.B: {currentEDOB}";
    }

    private void GetCurrentEmployeeData()
    {
        currentEmployee = GameObject.FindGameObjectWithTag("Employee");
        currentEName = currentEmployee.GetComponent<EmployeeData>().eName;
        currentEDepartment = currentEmployee.GetComponent<EmployeeData>().eDepartment;
        currentEPOB = currentEmployee.GetComponent<EmployeeData>().ePOB;
        currentEDOB = currentEmployee.GetComponent<EmployeeData>().eDOB;
    }
}
