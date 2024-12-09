using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseAttackClass : MonoBehaviour
{
    [Header("script reference")]

    public Health healthScript;
    [SerializeField] private ObjectiveManager objectiveManager;


    [Header("Input")]

    private string _controlName;
    public string controlName { get { return _controlName; } set {_controlName = value;} }


    [Header("damage and stamina")]

    [SerializeField] private float _damage;
    public float damage { get { return _damage;} set { _damage = value; } }

    [SerializeField]  private float _stamina;
    public float staminaloss { get { return _staminaloss; } set { _staminaloss = value; } }
    public float stamina { get { return _stamina; } set { _stamina = value; } }
    [SerializeField] private float _staminaloss;


    [Header("Landed")]

    private bool _connected;
    public bool connected { get { return _connected; } set { _connected = value; } }


    [Header("Animator")]

    [SerializeField] private Animator _animator;
    public Animator animator { get { return _animator; } set { _animator = value; } }


    [Header("Button check's")]

    private bool _buttonNorth;
    public bool buttonNorth { get { return _buttonNorth; } set { _buttonNorth = value; } }

    private bool _buttonEast;
    public bool buttonEast { get { return _buttonEast; } set { _buttonEast = value; } }

    private bool _buttonSouth;
    public bool buttonSouth { get { return _buttonSouth; } set { _buttonSouth = value; } }

    private bool _buttonWest;
    public bool buttonWest { get { return _buttonWest; } set { _buttonWest = value; } }


    public void CheckButton(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            controlName = context.control.name;
        }


        if (controlName == "buttonNorth")
        {
            buttonNorth = true;

            buttonEast = false; 
            buttonSouth = false;
            buttonWest = false;
        }


        if (controlName == "buttonEast")
        {
            buttonEast = true;
        }


        if (controlName == "buttonSouth")
        {
            buttonSouth = true;
        }


        if (controlName == "buttonWest")
        {
            buttonWest = true;
        }
    }


    public virtual void Attack()
    {
        Debug.LogError("No Attack Assinged");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            connected = true;


            //objectiveManager.UpdateObjective();
        }
    }
}
