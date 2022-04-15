using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_B : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            //EnemySearch();
            //EnemeyDestruction();
            EnemyScan();
        }
    }

    void EnemySearch()
    {
        for (int i = 0; i < 5; i++)
        {
            enemyDistance = Random.Range(1, 10);
            if (enemyDistance >= 8)
            {
                print("An enemy is far away!");
            }
            else if (enemyDistance >= 4 && enemyDistance <= 7)
            {
                print("An enemy is at medium range!");
            }
            else if (enemyDistance < 4)
            {
                print("An enemy is very close!");
            }
        }
    }

    void EnemeyDestruction()
    {
        while(enemyCount > 0)
        {
            print("There is an enemy, lets destroy it!");
            enemyCount--;
        }
    }

    void EnemyScan()
    {
        bool isAlive = false;

        do
        {
            print("Scanning for enemies!");
        }
        while (isAlive == true);
    }
}
