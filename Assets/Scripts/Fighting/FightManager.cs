using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class FightManager : MonoBehaviour
{
    #region Variables

    [Header("Input")]

    private InputController inputController;

    private InputAction powerPunch;

    [SerializeField] private float BumperValue;


    [Header("Statistics")]

    [SerializeField] private float stamina;
    [SerializeField] private float staminaRechargeAmount;

    [SerializeField] private StaminaLossValue staminaLossValue;
    [SerializeField] private StaminaLossValue damageValue;


    [Header("Timers")]

    [SerializeField] private float timeAfterPunchTimerCountdown;

    private bool recharge;
    private bool test;

    public float testTimer;

    float staminaz;

    #endregion

    private void Awake()
    {
        inputController = new InputController();
    }


    private void OnEnable()
    {
        inputController.Enable();
    }


    private void OnDisable()
    {
        inputController.Disable();
    }

    private void Update()
    {
        //StartTimer();
        if (BumperValue == 1)
        {
            PowerPunch();
        }


        if (recharge == true)
        {
            Recharge();
        }
    }


    private void Recharge()
    {
        if (stamina < 100)
        {
            stamina += staminaRechargeAmount * Time.deltaTime;
        }
    }


    public void OnJabs(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.jab)
        {
            var controlName = context.control.name;


            if (controlName == "buttonNorth")
            {
                // play left jab animation
            }

            else if (controlName == "buttonSouth")
            {
                //play right jab animation
            }


            stamina -= staminaLossValue.jab;

            


            StopCoroutine(TimerAfterPunch());
            recharge = false;

            StartCoroutine(TimerAfterPunch());
        }
    }

    public void OnJabs(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.jab)
        {
            LoseStamina(staminaLossValue.jab);
        }
    }

    private void LoseStamina(float staminaLocal)
    {
        //animation.play

        stamina -= staminaLocal;

        StopCoroutine(TimerAfterPunch());

        recharge = false;

        StartCoroutine(TimerAfterPunch());
    }


    public void OnHooks(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.hook)
        {
            var controlName = context.control.name;


            if (controlName == "buttonwest")
            {
                // play left hook animation
            }

            else if (controlName == "buttoneast")
            {
                //play right kook animation
            }


            stamina -= staminaLossValue.hook;


            StopCoroutine(TimerAfterPunch());
            recharge = false;

            StartCoroutine(TimerAfterPunch());
        }
    }


    public void OnUpperCut(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.uppercut)
        {
            //play Uppercut animation.


            stamina -= staminaLossValue.uppercut;


            StopCoroutine(TimerAfterPunch());
            recharge = false;

            StartCoroutine(TimerAfterPunch());
        }
    }


    public void OnLeftBumperHold(InputAction.CallbackContext context)
    {
        BumperValue = context.ReadValue<float>();
    }


    private void PowerPunch()
    {
        float _uppercut = staminaLossValue.uppercut * 1.15f;
        staminaLossValue.uppercut = _uppercut;

        float _hook = staminaLossValue.hook * 1.15f;
        staminaLossValue.hook =_hook;

        float _jab = staminaLossValue.jab * 1.15f;
        staminaLossValue.jab = _jab;


        float _uppercutDamage = damageValue.uppercut * 1.15f;
        damageValue.uppercut = _uppercutDamage;

        float _hookDamage = damageValue.hook * 1.15f;
        damageValue.hook = _hookDamage;

        float _jabDamage = damageValue.jab * 1.15f;
        damageValue.jab = _jabDamage;
    }


    private IEnumerator TimerAfterPunch()
    {
        yield return new WaitForSeconds(timeAfterPunchTimerCountdown);


        recharge = true;
    }


    [System.Serializable]
    public class StaminaLossValue
    {
        [SerializeField] private float Hook;
        public float hook
        {
            get { return Hook;}

            set {Hook = value;}
        }

        [SerializeField] private float Uppercut;
        public float uppercut
        {
            get { return Uppercut;}

            set {Uppercut = value;}
        }

        [SerializeField] private float Jab;
        public float jab
        {
            get { return Jab;}

            set {Jab = value;}
        }
        
    }


    [System.Serializable]
    public class DamageValue
    {
        [SerializeField] private float Hook;
        public float hook
        {
            get { return Hook; }

            set { Hook = value; }
        }

        [SerializeField] private float Uppercut;
        public float uppercut
        {
            get { return Uppercut; }

            set { Uppercut = value; }
        }

        [SerializeField] private float Jab;
        public float jab
        {
            get { return Jab; }

            set { Jab = value; }
        }

    }
}