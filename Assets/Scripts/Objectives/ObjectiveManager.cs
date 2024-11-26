using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Objective;

public class ObjectiveManager : MonoBehaviour
{
    [SerializeField]
    private List<Objective> objectives;
    [SerializeField]
    private Objective activeObjective;

    public string info;


    public void Start()
    {
        if (activeObjective == null)
        {
            GetNewObjective();
        }
    }
    public void GetNewObjective()
    {
        int i = Random.Range(0, objectives.Count);
        activeObjective = objectives[i];
        objectives.Remove(objectives[i]);
        if (activeObjective.isHitObjective)
        {
            info = "Hit " + activeObjective.hitsRequired.ToString() + " " + activeObjective.hitType.ToString() + "s on the opponent";
        }
        else if (activeObjective.isBlockObjective)
        {
            info = "Block the opponent " + activeObjective.blocksRequired.ToString() + " times";
        }
    }
   
    
}
