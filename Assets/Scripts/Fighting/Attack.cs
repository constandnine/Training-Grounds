using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    #region Variables
    [Header("Input")]

    private InputController inputController;
    private float bumperValue;


    [Header("Input")]

    private Health healthScript;


    [Header("Stamina and Damage")]

    [SerializeField] private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }

    [SerializeField] private float _staminaRechargeAmount;
    public float staminaRechargeAmount { get { return _staminaRechargeAmount; } set { _staminaRechargeAmount = value; } }

    [SerializeField] private float powerHitStaminaLossMultiplier;
    [SerializeField] private float powerHitDamageMultiplier;

    [SerializeField] protected StaminaLossValue staminaLossValue;
    [SerializeField] protected DamageValue damageValue;

    private bool powerPunch;


    [Header("Timers")]

    [SerializeField] private float timeAfterPunchTimerCountdown;

    private bool recharge;
    #endregion

    #region TempVariables
    [Header("Temporary hit")]

    [SerializeField] public Transform leftGlove;
    [SerializeField] public Transform rightGlove;

    [SerializeField] public Transform leftGloveTarget;
    [SerializeField] public Transform rightGloveTarget;

    [SerializeField] public Transform leftGloveReturnTarget;
    [SerializeField] public Transform rightGloveReturnTarget;

    [SerializeField] public float punchSpeed;

    [SerializeField] public float Returntime;
    #endregion


    private void Update()
    {
        if (bumperValue == 1)
        {
            powerPunch = true;
        }


        if (recharge == true)
        {
            Recharge();
        }
    }


    public void OnLeftBumperHold(InputAction.CallbackContext context)
    {
        bumperValue = context.ReadValue<float>();
    }

    private void Recharge()
    {

    }


    virtual protected void LoseStamina(float staminaLoss)
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

    virtual protected void DoDamage(float damage)
    {

        if (powerPunch == true)
        {
            damage *= powerHitStaminaLossMultiplier;
        }


        healthScript.health -= damage;
    }


    public IEnumerator TimeTillRecharge()
    {
        yield return new WaitForSeconds(timeAfterPunchTimerCountdown);


        recharge = true;
    }


    #region temporaryHit
    public void LeftTemporaryHit()
    {
        leftGlove.position = Vector3.MoveTowards(leftGlove.position, leftGloveTarget.position, punchSpeed * Time.deltaTime);


        StartCoroutine(MaveLeftGloveBack());
    }


    public void RightTemporaryHit()
    {
        rightGlove.position = Vector3.MoveTowards(rightGlove.position, rightGloveTarget.position, punchSpeed * Time.deltaTime);


        StartCoroutine(MaveRightGloveBack());
    }


    public IEnumerator MaveLeftGloveBack()
    {
        yield return new WaitForSeconds(Returntime);


        rightGlove.position = Vector3.MoveTowards(rightGlove.position, rightGloveReturnTarget.position, punchSpeed * Time.deltaTime);
    }


    public IEnumerator MaveRightGloveBack()
    {
        yield return new WaitForSeconds(Returntime);


        leftGlove.position = Vector3.MoveTowards(leftGlove.position, leftGloveReturnTarget.position, punchSpeed * Time.deltaTime);
    }

    #endregion


    [System.Serializable]
    public class DamageValue
    {
        [SerializeField] private float _hook;
        public float hook
        { get { return _hook; } set { _hook = value; } }


        [SerializeField] private float _uppercut;
        public float uppercut { get { return _uppercut; } set { _uppercut = value; } }


        [SerializeField] private float _jab;
        public float jab { get { return _jab; } set { _jab = value; } }

    }


    [System.Serializable]
    public class StaminaLossValue
    {
        [SerializeField] private float _hook;
        public float hook
        { get { return _hook; } set { _hook = value; } }


        [SerializeField] private float _uppercut;
        public float uppercut { get { return _uppercut; } set { _uppercut = value; } }


        [SerializeField] private float _jab;
        public float jab { get { return _jab; } set { _jab = value; } }

    }
}
