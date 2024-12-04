public class Uppercut : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Uppercut");
        if (stamina > staminaloss)
        {
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
