using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("scrip reference")]

    private BaseAttackClass attackClass;


    [Header("Statistics")]

    private float _health;
    public float health { get { return _health;} set { _health = value; } }

    [SerializeField] private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }


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
        if (collision.other.gameObject.layer == 6)
        {
            if (collision.other.gameObject.tag != transform.gameObject.tag)
            {
                takedamage();
            }
        }
    }
}
