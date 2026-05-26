using UnityEngine;

public class FatGassinator : MonoBehaviour
{
    [SerializeField] private EmployeeDatabase no;
    [SerializeField] private Sprite bowsie;
    public void HelpMePlease()
    {
        no.sprites.Add(bowsie);
    }
}
