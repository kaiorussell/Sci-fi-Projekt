using UnityEngine;

public class EmployeeBulletBehaviour : MonoBehaviour
{
    private GameObject eliteEmployee;

    private SpriteRenderer sr;

    private Animation anim;
    private void Awake()
    {
        anim = GetComponent<Animation>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        eliteEmployee = GameObject.FindGameObjectWithTag("Employee");
        eliteEmployee.GetComponent<EmployeeBehaviour>().lastEmployeeBullet = this.gameObject;
        transform.position = eliteEmployee.transform.position;
        sr.sprite = eliteEmployee.GetComponent<SpriteRenderer>().sprite;
        sr.color = eliteEmployee.GetComponent<SpriteRenderer>().color;
    }

    private void MakeTrue()
    {

    }
    private void KillTheBullet()
    {
        anim.Play();
        
    }
    private void SurviveTheBullet()
    {
        anim.Play();
    }
    
}
