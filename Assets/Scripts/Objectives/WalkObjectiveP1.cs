using UnityEngine;

public class WalkObjectiveP1 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("P1"))
        {
            other.gameObject.GetComponent<ObjectiveManager>().UpdateObjective();   
            Destroy(this.gameObject);
        }
    }
}
