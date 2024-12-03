using UnityEngine.InputSystem;

public class Jab : PunchHit
{
    public override void DoJab(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            var controlName = context.control.name;

            print("123");

            if (controlName == "buttonNorth")
            {
                // play left hook animation
                LeftTemporaryHit();
                StartCoroutine(MaveLeftGloveBack());
                print("456");
            }

            else if (controlName == "buttonSouth")
            {
                //play right kook animation
                RightTemporaryHit();
                StartCoroutine(MaveRightGloveBack());
            }


            LoseStamina(staminaLossValue.jab);


            if (connected == true)
            {
                DoDamage(damageValue.jab);
            }
        }
    }
}
