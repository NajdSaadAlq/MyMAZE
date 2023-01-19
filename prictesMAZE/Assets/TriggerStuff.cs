using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStuff : MonoBehaviour
{
    [SerializeField] private GameObject testBlock;

    [SerializeField] private int playerPoints = 0 ;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal"))

        {
            Destroy(other.gameObject);
            playerPoints += 1;
        }

        }
    }