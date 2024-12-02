using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkObjectiveP2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player two"))
        {
            other.GetComponent<ObjectiveManager>().UpdateObjective();

            Destroy(gameObject);
        }
    }
}
