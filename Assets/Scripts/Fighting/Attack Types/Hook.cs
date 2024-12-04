using UnityEngine.InputSystem;

public class Hook : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Jab");
        if (stamina > staminaloss)
        {

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
            //play jab animation
            LeftTemporaryHit();
            StartCoroutine(MaveLeftGloveBack());


            stamina -= staminaloss;


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
