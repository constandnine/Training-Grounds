using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    [SerializeField]
    private List<Objective> objectives;
    [SerializeField]
    Objective activeObjective;
    [SerializeField]
    private int ammountOfObjectivesFinished;
    [SerializeField]
    private int maxObjectives;

    public string info;
    public TextMeshProUGUI objectiveText;
    public GameObject[] objectivePoints;
    public GameObject pointToSpawn;



    [Header("Registerd")]
    [Tooltip("Amount of hits required to complete the objective")]
    public int hitsRegisterd;
    [Tooltip("Amount of blocks allready done by the player")]
    public int blocksRegisterd;
    [Tooltip("Amount of corners player has already walked to")]
    public int cornersRegisterd;
    [Tooltip("Amount of stamina player currently has")]
    public float staminaRegisterd;

    public bool objectiveFinished;
    

    public void Start()
    {
        ammountOfObjectivesFinished = 0;
        objectiveFinished = false;
        if (activeObjective == null)
        {
            GetNewObjective();
        }
    }
    public void GetNewObjective()
    {
        if(ammountOfObjectivesFinished < maxObjectives)
        {
            objectiveFinished = false;
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
            else if(activeObjective.isWalkObjective)
            {
                info = "Walk to every corner of the map";
                foreach(GameObject obj in objectivePoints)
                {
                    Instantiate(pointToSpawn, obj.transform);
                }
            }
            else if (activeObjective.isStaminaObjective)
            {
                //code for staminaCheck
            }
        }
            objectiveText.text = info;
    }

    
    public void UpdateObjective()
    {
        if (activeObjective.isHitObjective)
        {
            hitsRegisterd++;
        }
        else if (activeObjective.isBlockObjective)
        {
            blocksRegisterd++;
        }
        else if (activeObjective.isWalkObjective)
        {
            cornersRegisterd++;
        }
        else if (activeObjective.isStaminaObjective)
        {
            //code for stamina check
        }

        CheckObjectiveFinished();
    }

    public void CheckObjectiveFinished()
    {
        if (hitsRegisterd == activeObjective.hitsRequired)
        {
            objectiveFinished = true;
        }
        else if (blocksRegisterd == activeObjective.blocksRequired)
        {
            objectiveFinished = true;
        }
        else if (cornersRegisterd == activeObjective.cornersRequired)
        {
            objectiveFinished = true;
        }
        if (objectiveFinished)
        {
            ammountOfObjectivesFinished++;
            GetNewObjective();
        }

    }


    public void GiveObjectiveReward()
    {
        //code for reward.
    }
}
