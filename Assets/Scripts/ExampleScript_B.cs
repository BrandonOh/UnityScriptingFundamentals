using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_B : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 4;

    private string[] enemies = new string[5];
    private int weaponId = 0;
    
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
            //EnemyScan();
            //EnemyRoster();
            WeaponSearch();
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

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Goblin";
        enemies[3] = "Golem";
        enemies[4] = "Unicorn";
        foreach(string enemy in enemies)
        {
            print(enemy);
        }
    }

    void WeaponSearch()
    {
        weaponId = Random.Range(0, 7);

        switch (weaponId)
        {
            case 1:
                print("You found a sword!");
                break;
            case 2:
                print("You found a axe!");
                break;
            case 3:
                print("You found a dagger!");
                break;
            case 4:
                print("You found a mace!");
                break;
            case 5:
                print("You found a staff!");
                break;
            default:
                print("Guess you found nothing...");
                break;
        }
    }
}
