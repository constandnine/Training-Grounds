using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StateManager : MonoBehaviour
{
    [Header("Script References")]

    private BaseAttackClass _attack;
    public BaseAttackClass attack { get { return _attack; } set { _attack = value; } }

    private StateEfects stateEfects;


    [Header("States")]

    [SerializeField] private PlayerStates _currentstate;
    public PlayerStates currentState { get { return _currentstate; } set { _currentstate = value; } }

    [SerializeField] private float switchToHalfStateAmount;
    [SerializeField] private float switchToLowStateAmount;


    private void Awake()
    {
        attack = GetComponent<BaseAttackClass>();


        stateEfects = GetComponent<StateEfects>();


        currentState = PlayerStates.HealthyAndFit;
    }


    public void SwitchStates(float stamina, float health)
    {
        if (health > switchToHalfStateAmount && stamina > switchToHalfStateAmount)
        {
            currentState = PlayerStates.HealthyAndFit;
            print("state 1");
        }

        else if (health > switchToHalfStateAmount && stamina > switchToLowStateAmount)
        {
            currentState = PlayerStates.HealthyHalfFit;
            print("state 2");
        }

        else if (health > switchToHalfStateAmount && stamina < switchToLowStateAmount)
        {
            currentState = PlayerStates.HealthyNotFit;
            print("state 3");
        }

        else if (health > switchToLowStateAmount && stamina > switchToHalfStateAmount)
        {
            currentState = PlayerStates.HealthyNotFit;
            print("state 4");
        }

        else if (health < switchToLowStateAmount && stamina > switchToHalfStateAmount)
        {
            currentState = PlayerStates.HealthyNotFit;
            print("state 5");
        }

        else if (health > switchToLowStateAmount && stamina > switchToLowStateAmount)
        {
            currentState = PlayerStates.HalfHealthHalfFit;
            print("state 6");
        }

        else if (health < switchToLowStateAmount && stamina > switchToLowStateAmount)
        {
            currentState = PlayerStates.LowHealthHalfFit;
            print("state 7");
        }

        else if (health > switchToLowStateAmount && stamina < switchToLowStateAmount)
        {
            currentState = PlayerStates.HalfHealthNotFit;
            print("state 18");
        }

        else
        {
            currentState = PlayerStates.LowHealthAndFit;
            print("state 9");
        }


        stateEfects.ApplyStateEffects();
    }

}