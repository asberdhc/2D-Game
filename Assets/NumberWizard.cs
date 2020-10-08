using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, please");
        Debug.Log("The highest number you can chose is " + max);
        Debug.Log("The lowest number you can chose is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("push up if it's higher or down if is lower");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {

        }
    }
}
