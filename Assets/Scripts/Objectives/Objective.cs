using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Objective", menuName = "Objective", order = 1)]
public class Objective : ScriptableObject
{
    /*[Header("Objective")]
    public bool objectiveFinished;*/


    [Header("Hit Objectives")]
    //[Tooltip("Amount of hits allready done by the player")]
    //public int hitsRegisterd;
    [Tooltip("Amount of hits required to complete the objective")]
    public int hitsRequired;
    [Tooltip("What kind of hit is required for the objective")]
    public enum HitType {Jab, Hook, Uppercut}
    public HitType hitType;
    public float hitBuff;
    public bool isHitObjective;

    [Header("Block Objectives")]
   /* [Tooltip("Amount of blocks allready done by the player")]
    public int blocksRegistered;*/
    [Tooltip("Amount of blocks required to complete the objective")]
    public int blocksRequired;
    public float blockBuff;
    public bool isBlockObjective;

    [Header("Stamina objectives")]
    [Tooltip("Amount of stamina player has to maintain during the round")]
    public float staminaRequired;
    public float staminaBuff;
    public bool isStaminaObjective;

    [Header("Walk objectives")]
    //[Tooltip("Amount of corners player has already walked to")]
    // public int cornersRegisterd;
    [Tooltip("Amount of corners player has to walk to")]
    public int cornersRequired;
    public bool isWalkObjective;

    

}

