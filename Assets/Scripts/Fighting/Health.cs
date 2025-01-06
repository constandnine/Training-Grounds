using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("scrip reference")]

    private BaseAttackClass attackClass;
    [Header("")]

    private float _health;
    public float health { get { return _health;} set { _health = value; } }

    private void takedamage()
    {
        health -= attackClass.damage;
    }


    private void KnockOut()
    {
        if (health < 1)
        {
            // KO logig here pls
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.other.gameObject.layer == 7)
        {
            takedamage();
        }
    }
}
