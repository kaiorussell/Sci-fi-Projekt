using UnityEngine;

public class EmployeeManager : MonoBehaviour
{
    private static EmployeeManager _instance;
    public static EmployeeManager Instance {  get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    [SerializeField] private EmployeeDatabase edb;

//lowkey kinda useless
}
