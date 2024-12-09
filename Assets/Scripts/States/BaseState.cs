using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState : MonoBehaviour
{
    [Header("Script References")]

    private BaseAttackClass attack;


    [Header("Multiplyers")]

    [SerializeField] private float _damageMultiplyer;
    public float damageMultiplyer { get { return _damageMultiplyer; } set { _damageMultiplyer = value; } }


}
