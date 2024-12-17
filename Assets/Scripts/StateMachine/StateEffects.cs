using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class StateEfects : StateManager
{
    [Header("Decrease Percentage")]

    private float lowDecrease;
    private float highDecrease;


    public void ApplyStateEffects()
    {
        switch (currentState)
        {
            case PlayerStates.HealthyHalfFit:
                attack.staminaloss += lowDecrease;
                break;


            case PlayerStates.HealthyNotFit:
                attack.staminaloss *= highDecrease;
                break;


            case PlayerStates.HalfHealthAndFit:
                attack.damage += lowDecrease;
                break;


            case PlayerStates.LowHealthAndFit:
                attack.damage *= highDecrease;
                break;


            case PlayerStates.HalfHealthHalfFit:
                attack.damage += lowDecrease;
                attack.staminaloss += lowDecrease;
                break;


            case PlayerStates.HalfHealthNotFit:
                attack.damage += lowDecrease;
                attack.staminaloss *= highDecrease;
                break;


            case PlayerStates.LowHealthHalfFit:
                attack.damage += highDecrease;
                attack.staminaloss *= lowDecrease;
                break;


            case PlayerStates.LowHealthNotFit:
                attack.damage *= highDecrease;
                attack.staminaloss *= highDecrease;

                break;
        }
        
    }
    
}
