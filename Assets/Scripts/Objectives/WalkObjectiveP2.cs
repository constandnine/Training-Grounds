using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkObjectiveP2 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("P2"))
        {
            other.GetComponent<ObjectiveManager>().UpdateObjective();

            Destroy(this.gameObject);
        }
    }
}
