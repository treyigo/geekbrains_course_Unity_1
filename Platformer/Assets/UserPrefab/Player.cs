using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    float speed;
    bool right;
    Rigidbody2D RB;
    Vector3 direction;
    float horizontal;


    private void Move()
    {
        direction = Vector3.right * horizontal;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }


    private void Start()
    {
        speed = 3;
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Horizontal"))
        {
            Move();
        }
    }
}
