using UnityEngine;

public class HookLeft : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("HookLeft");
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6 && collision.gameObject.tag != transform.gameObject.tag)
        {
            Health otherPlayerHealth = collision.gameObject.GetComponent<Health>();

            otherPlayerHealth.health -= damage;


            objectiveManager.UpdateObjective();


            hitSound.Play();
        }
    }
}
