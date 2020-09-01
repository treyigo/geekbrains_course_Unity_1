using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    public GameObject enemyPref;
    public GameObject CurrentEnemy;

      
    // Update is called once per frame
    private void Update()
    {
        if(CurrentEnemy==null)
        {
            Instantiate(enemyPref, transform.position, Quaternion.identity);
            CurrentEnemy = Instantiate(enemyPref, transform.position, Quaternion.identity);
        }
    }
}
