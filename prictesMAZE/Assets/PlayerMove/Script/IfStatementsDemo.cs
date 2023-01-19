using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IfStatementsDemo : MonoBehaviour
{
    private int number = 0;

    private void Update()
    {
        Debug.Log("the number is:"+number);

        if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha2))
        {
            number += 1;
        }

        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
        {
            number = 0;
            Debug.Log(number);
        }
       
       
    }
}