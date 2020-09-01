using System.Collections;  
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
        
    }
}
