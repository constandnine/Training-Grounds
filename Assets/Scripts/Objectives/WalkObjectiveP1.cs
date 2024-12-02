using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkObjectiveP1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player one"))
        {
            other.GetComponent<ObjectiveManager>().UpdateObjective();   

            Destroy(gameObject);
        }
    }
}
