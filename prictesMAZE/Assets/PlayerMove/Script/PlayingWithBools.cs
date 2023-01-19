using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class PlayingWithBools : MonoBehaviour
{
    [SerializeField] private bool activated = false;
    [SerializeField] private Transform block;

    private void Update()
    {
        if (activated == true)
        {
           block.Translate(0, 1 * Time.deltaTime, 0);
        }
    }
}
/*
    private void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.CompareTag("player"))

            activated = true;
    }

    private void OnTriggerExit(Collider other)
    {
     if (other.gameObject.CompareTag("player"))

                activated = false;
    }       
}
*/