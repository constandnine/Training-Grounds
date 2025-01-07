using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("scrip reference")]

    private BaseAttackClass attackClass;


    [Header("Statistics")]

    [SerializeField] private float _health;
    public float health { get { return _health;} set { _health = value; } }

    [SerializeField] private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }

    private void KnockOut()
    {
        if (health < 1)
        {
            // KO logig here pls
        }
    }
}
