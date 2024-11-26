using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Objective", menuName = "Objective", order = 1)]
public class Objective : ScriptableObject
{
    [Header("Hit Objectives")]
    [Tooltip("Amount of hits allready done by the player")]
    public int hitsRegisterd;
    [Tooltip("Amount of hits required to complete the objective")]
    public int hitsRequired;
    [Tooltip("What kind of hit is required for the objective")]
    public enum HitType {Jab, Hook, Uppercut}
    public HitType hitType;
    public float hitBuff;
    public bool isHitObjective;

    [Header("Block Objectives")]
    [Tooltip("Amount of blocks allready done by the player")]
    public int blocksRegistered;
    [Tooltip("Amount of blocks required to complete the objective")]
    public int blocksRequired;
    public float blockBuff;
    public bool isBlockObjective;

    public void Start()
    {
        
    }
}
