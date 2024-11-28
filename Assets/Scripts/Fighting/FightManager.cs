using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class FightManager : MonoBehaviour
{
    #region Variables
    [Header("Input")]

    private InputController inputController;

    [SerializeField] private float BumperValue;


    [Header("Stamina and Damage")]

    [SerializeField] private float stamina;
    [SerializeField] private float staminaRechargeAmount;

    [SerializeField] private float powerHitStaminaLossMultiplier;

    [SerializeField] private StaminaLossValue staminaLossValue;

    private bool powerPunch;


    [Header("Timers")]

    [SerializeField] private float timeAfterPunchTimerCountdown;

    private bool recharge;


    [Header("Temporary hit")]

    [SerializeField] private Transform leftGlove;
    [SerializeField] private Transform rightGlove;

    [SerializeField] private Transform leftGloveTarget;
    [SerializeField] private Transform rightGloveTarget;   
    
    [SerializeField] private Transform leftGloveReturnTarget;
    [SerializeField] private Transform rightGloveReturnTarget;

    [SerializeField] private float punchSpeed;

    [SerializeField] private float Returntime;
    #endregion


    #region StandartVoids
    private void Awake()
    {
        inputController = new InputController();


        powerPunch = false;
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
            powerPunch = true;
        }


        if (recharge == true)
        {
            Recharge();
        }
    }
    #endregion


    #region Moves
    public void OnJabs(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.hook)
        {
            var controlName = context.control.name;


            if (controlName == "buttonSouth")
            {
                // play left hook animation
                LeftTemporaryHit();
                StartCoroutine(MaveLeftGloveBack());
            }

            else if (controlName == "buttonNorth")
            {
                //play right kook animation
                RightTemporaryHit();
                StartCoroutine(MaverightGloveBack());
            }


            LoseStamina(staminaLossValue.jab);
        }
    }


    public void OnHooks(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.hook)
        {
            var controlName = context.control.name;


            if (controlName == "buttonEast")
            {
                // play left hook animation
                LeftTemporaryHit();
                StartCoroutine(MaveLeftGloveBack());
                Debug.Log("west called");
            }

            else if (controlName == "buttonWest")
            {
                //play right kook animation
                RightTemporaryHit();
                StartCoroutine(MaverightGloveBack());
                Debug.Log("east called");
            }


            LoseStamina(staminaLossValue.hook);
        }
    }


    public void OnUpperCut(InputAction.CallbackContext context)
    {
        if (context.started && stamina > staminaLossValue.uppercut)
        {
            LoseStamina(staminaLossValue.uppercut);
        }
    }
    #endregion


    public void OnLeftBumperHold(InputAction.CallbackContext context)
    {
        BumperValue = context.ReadValue<float>();
    }

    private void Recharge()
    {
        if (stamina < 100)
        {
            stamina += staminaRechargeAmount * Time.deltaTime;
        }
    }

    private void LoseStamina(float staminaLoss)
    {

        if (powerPunch == true)
        {
            staminaLoss *= powerHitStaminaLossMultiplier;
        }

        stamina -= staminaLoss;
        


        StopCoroutine(TimeTillRecharge());
        recharge = false;

        StartCoroutine(TimeTillRecharge());
    }


    #region temporaryHit
    private void LeftTemporaryHit()
    {
        leftGlove.position = Vector3.MoveTowards(leftGlove.position, leftGloveTarget.position, punchSpeed * Time.deltaTime);


        StartCoroutine(MaveLeftGloveBack());
    }

    private void RightTemporaryHit()
    {
        rightGlove.position = Vector3.MoveTowards(rightGlove.position, rightGloveTarget.position, punchSpeed * Time.deltaTime);
    }

    private IEnumerator MaveLeftGloveBack()
    {
        yield return new WaitForSeconds(Returntime);


        rightGlove.position = Vector3.MoveTowards(rightGlove.position, rightGloveReturnTarget.position, punchSpeed * Time.deltaTime);
    }  
    
    private IEnumerator MaverightGloveBack()
    {
        yield return new WaitForSeconds(Returntime);


        leftGlove.position = Vector3.MoveTowards(leftGlove.position, leftGloveReturnTarget.position, punchSpeed * Time.deltaTime);
    }

    #endregion


    private IEnumerator TimeTillRecharge()
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
}