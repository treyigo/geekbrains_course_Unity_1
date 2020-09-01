using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 0.1f;
    [SerializeField] int damage = 2;
    [SerializeField] public int direction;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy temp = collision.gameObject.GetComponent<Enemy>();
            temp.health -= 2;
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * direction * speed;
    }
}
