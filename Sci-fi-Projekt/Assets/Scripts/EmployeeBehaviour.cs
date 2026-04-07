using System.Collections;
using UnityEngine;

public class EmployeeBehaviour : MonoBehaviour
{

    public bool isEvil;

    private Color color;

    void Start()
    {
        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        isEvil = Random.value < 0.5f;

        StartCoroutine(WalkInAnimation());
        GetComponent<SpriteRenderer>().color = color;



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (isEvil)
            {
                Debug.Log("You Win :D");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("You lose :C");
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (isEvil)
            {
                Debug.Log("You lose :C");
            }
            else
            {
                Debug.Log("You won :D");
                Destroy(gameObject);
            }
        }
    }

    IEnumerator WalkInAnimation()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Animation>().Play();
    }

}
