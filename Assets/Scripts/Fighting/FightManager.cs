using UnityEngine;
using UnityEngine.InputSystem;

public class FightManager : MonoBehaviour
{
    #region Variables
    [Header("Input")]

    private InputController inputController;

    [SerializeField] private float BumperValue;

    private bool powerPunch;


    [Header("Script References")]

    [SerializeField] private PunchHit punchHit;


    [Header("Timers")]

    [SerializeField] private float timeAfterPunchTimerCountdown;

    private bool recharge;
    #endregion

    #region StandartVoids
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
    #endregion

    public void OnJab(InputAction.CallbackContext context)
    {
        print("1");

        if (context.started == true)
        {
            punchHit.DoJab(context);
            print("2");
        }
    }


    public void OnHook(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            punchHit.DoHook(context);
        }
    }


    public void OnUppercut(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            punchHit.DoUppercut(context);
        }
    }
}