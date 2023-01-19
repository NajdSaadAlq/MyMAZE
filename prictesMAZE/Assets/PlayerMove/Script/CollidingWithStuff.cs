using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingWithStuff : MonoBehaviour
{
   // private int playerHealth = 3;
    [SerializeField] private int playerHealth = 3;



    private void OnCollisionEnter(Collision other)
    {
        /*   if (other.gameObject) {

               Debug.Log("I am touching something.");
           }
        */

        if (other.gameObject)
        {

            Debug.Log("I am touching something.");
        }

        Debug.Log("Collision with Plane - Collision Enter");

        if (other.gameObject.CompareTag("Hazard"))
        {
            playerHealth -= 1;
        }
    }









    private void OnCollisionStay(Collision other)
    {
        /*
        float shrinkRate = 0.1f * Time.deltaTime;
        if (other.gameObject)
        {
            transform.localScale -= new Vector3(shrinkRate, shrinkRate, shrinkRate);
        }
        */

        Debug.Log("Collision with Plane - Collision Stay");


    }


    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Hazard"))

        Debug.Log("I probably should not have touched that.");

        Debug.Log("Collision with Plane - Collision Exit");
    }
}
