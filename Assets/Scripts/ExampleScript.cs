using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    /*
    Assignement Operators:
    = : Assigns data to a variable
    += : Adds value to variable ex. speed = speed + y (speed += y)
    -= : Same as above (subtract)
    *- : Same as above (multiple)
    /= : Same as above (divide)
    %= : Same as above (module)

    Arithmetic Operators:
    + : Addition
    - : Subtraction
    * : Multiplication
    / : Divition
    % : Module

    Comparison Operators:
    == : Is equal to, compare to see if equal
    != : Not equal to, compare to see if not equal
    > : Greater than
    < : Less than
    >= : Greater than or Equal to
    <= : Less than or Equal to

    Logical Operators:
    && : And
    || : Or
    ! : Not
     */

    public float speed = 0.0f;
    public float distance = 0.0f;
    public float time = 0.0f;

    public float maxSpeedLimit = 70f;
    public float minSpeedLimit = 40f;

    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedCheck();
        }
    }

    void SpeedCheck()
    {
        speed = distance / time;
        
        if(speed > maxSpeedLimit)
        {
            print("You are exceeding the speed limit!");
        }
        else if(speed < minSpeedLimit)
        {
            print("You are under the minimum speed limit!");
        }
        else if(speed == maxSpeedLimit || speed == minSpeedLimit)
        {
            print("You are very close to breaking the law!");
        }
        else
        {
            print("Your speed is fine.");
        }
    }
}
