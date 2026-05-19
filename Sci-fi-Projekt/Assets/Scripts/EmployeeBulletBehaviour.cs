using System.Collections;
using Unity.VisualScripting;
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
        eliteEmployee = GameObject.FindGameObjectWithTag("Employee");
        eliteEmployee.GetComponent<EmployeeBehaviour>().lastEmployeeBullet = this.gameObject;
        transform.position = eliteEmployee.transform.position;
        sr.sprite = eliteEmployee.GetComponent<SpriteRenderer>().sprite;
        sr.color = eliteEmployee.GetComponent<SpriteRenderer>().color;
    }

    public IEnumerator KillTheBullet()
    {
        anim.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        Debug.Log("Himeko core");
    }
    public IEnumerator SurviveTheBullet()
    {
        anim.Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        Debug.Log("Ya survived");
    }
    
}
