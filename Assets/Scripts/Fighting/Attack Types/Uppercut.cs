using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Attack;
using UnityEngine.InputSystem;

public class Uppercut : PunchHit
{
    public override void DoUppercut(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            // Play uppercut animation

            LoseStamina(staminaLossValue.uppercut);


            if (connected == true)
            {
                DoDamage(damageValue.uppercut);
            }
        }
    }
}
