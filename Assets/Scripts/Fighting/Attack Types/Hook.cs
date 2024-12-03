using UnityEngine.InputSystem;

public class Hook : PunchHit
{
    public override void DoUppercut(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            string controlName = context.control.name;


            if (controlName == "buttonEast")
            {
                // play left hook animation
                LeftTemporaryHit();
                StartCoroutine(MaveLeftGloveBack());
            }

            else if (controlName == "buttonWest")
            {
                //play right kook animation
                RightTemporaryHit();
                StartCoroutine(MaveRightGloveBack());
            }


            LoseStamina(staminaLossValue.uppercut);


            if (connected == true)
            {
                DoDamage(damageValue.uppercut);
            }
        }
    }
}
