using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed;
    [SerializeField] private bool right;
    Rigidbody2D RB;
    Vector3 direction;
    float horizontal;
    public GameObject bulletPref;

    private void Move()
    {
        if (horizontal > 0 && right)
        {
            Flip();
        }
        if (horizontal < 0 && !right)
        {
            Flip();
        }


        direction = Vector3.right * horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }


    private void Start()
    {
        speed = 10;
        RB = GetComponent<Rigidbody2D>();
    }

    private void Flip()
    {
        right = !right;
        Vector3 sc = transform.localScale;
        sc.x *= -1;
        transform.localScale = sc;
    }

    private void Shoot()
    {
        GameObject temp = Instantiate(bulletPref, transform.position, Quaternion.identity);
        temp.name = "Bullet";
        temp.GetComponent<Bullet>().direction = (!right) ? 1  : -1 ;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(horizontal);
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Horizontal"))
        {
            Move();
        }

        if (Input.GetButtonDown("Fire1"))
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }
}
