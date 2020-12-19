using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private float speed = 3f;
    public bool walkLeft;
    public GameObject effect;
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }


    void Update()
    {
        Walk();
    }

    private void Walk()
    {
        Vector3 temp = transform.position;
        Vector3 tempscale = transform.localScale;
        if (walkLeft)
        {
            temp.x -= speed * Time.deltaTime;
            tempscale.x = -Mathf.Abs(tempscale.x);
        }
        else
        {
            temp.x += speed * Time.deltaTime;
            tempscale.x = Mathf.Abs(tempscale.x);
        }

        transform.position = temp;
        transform.localScale = tempscale;
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(2f);
        walkLeft = !walkLeft;
        StartCoroutine(ChangeDirection());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            audioctrl.instance.enemyDestroy(gameObject.transform.position);
        }
    }
}
