using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [Header("scrip reference")]

    private BaseAttackClass attackClass;
    [SerializeField] private Rounds roundsScript;


    [Header("Statistics")]

    [SerializeField] private float _health;
    public float health { get { return _health;} set { _health = value; } }


    [SerializeField] private float _damage;
    public float damage { get { return _damage; } set { _damage = value; } }

    public Health otherPlayerHealth;


    [Header("UI")]

    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider staminaSlider;
    
    [SerializeField] private GameObject WinScreen;


    [Header("Stamina")]


    [SerializeField] private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }

    private float startStamina;
    [SerializeField] private float staminaRechargeRate;


    private void Start()
    {
        startStamina = stamina;
    }


    private void Update()
    {
        healthSlider.value = health;
        staminaSlider.value = stamina;


        if (stamina < startStamina)
        {
            stamina += staminaRechargeRate * Time.deltaTime;
            stamina = Mathf.Clamp(stamina, 0, startStamina);

        }


        if (health <= 1)
        {
            KnockOut();
        }
    }


    private void KnockOut()
    {
        foreach (var playerController in roundsScript.playerControllers)
        {
            if (playerController != null)
            {
                playerController.enabled = false;
            }


            break;
        }


        WinScreen.SetActive(true);


        StartCoroutine(roundsScript.ReloadScene());
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            otherPlayerHealth.health -= damage;
        }
    }
}
