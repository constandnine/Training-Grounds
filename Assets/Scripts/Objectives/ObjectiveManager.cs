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

    public string objectiveInfo;
    public string progressText;

    public TextMeshProUGUI objectiveText;
    public TextMeshProUGUI objectiveProgress;
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

            hitsRegisterd = 0;
            blocksRegisterd = 0;
            cornersRegisterd = 0;

            if (activeObjective.isHitObjective)
            {
                objectiveInfo = "Hit " + activeObjective.hitsRequired.ToString() + " " + activeObjective.hitType.ToString() + "s on the opponent";
                progressText = hitsRegisterd.ToString() + " / " + activeObjective.hitsRequired.ToString();
            }
            else if (activeObjective.isBlockObjective)
            {
                objectiveInfo = "Block the opponent " + activeObjective.blocksRequired.ToString() + " times";
                progressText = blocksRegisterd.ToString() + " / " + activeObjective.blocksRequired.ToString();
            
            }
            else if(activeObjective.isWalkObjective)
            {
                objectiveInfo = "Walk to every corner of the map";
                progressText = cornersRegisterd.ToString() + " / " + activeObjective.cornersRequired.ToString();
                foreach (GameObject obj in objectivePoints)
                {
                    Instantiate(pointToSpawn, obj.transform);
                }
            }
            else if (activeObjective.isStaminaObjective)
            {
                //code for staminaCheck
            }
        }
            objectiveText.text = objectiveInfo;
            objectiveProgress.text = progressText;
    }

    
    public void UpdateObjective()
    {
        if (activeObjective.isHitObjective)
        {
            hitsRegisterd++;
            progressText = hitsRegisterd.ToString() + " / " + activeObjective.hitsRequired.ToString();
        }
        else if (activeObjective.isBlockObjective)
        {
            blocksRegisterd++;
            progressText = blocksRegisterd.ToString() + " / " + activeObjective.blocksRequired.ToString();
        }
        else if (activeObjective.isWalkObjective)
        {
            cornersRegisterd++;
            progressText = cornersRegisterd.ToString() + " / " + activeObjective.cornersRequired.ToString();
        }
        else if (activeObjective.isStaminaObjective)
        {
            //code for stamina check
        }

        objectiveProgress.text = progressText;
        CheckObjectiveFinished();
    }

    public void CheckObjectiveFinished()
    {
        if (activeObjective.isHitObjective)
        {
            if (hitsRegisterd >= activeObjective.hitsRequired)
            {
                objectiveFinished = true;
            }
        }
        else if (activeObjective.isBlockObjective)
        {
            if (blocksRegisterd >= activeObjective.blocksRequired)
            {
                objectiveFinished = true;
            }
        }
        else if (activeObjective.isWalkObjective)
        {
            if (cornersRegisterd >= activeObjective.cornersRequired)
            {
                objectiveFinished = true;
            }
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
