using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseAttackClass : MonoBehaviour
{
    [Header("script reference")]
        
    [SerializeField] private ObjectiveManager objectiveManager;
    [SerializeField] private StateManager _stateManager;
    public StateManager stateManager { get { return _stateManager; }  set { _stateManager = value; } }
    [SerializeField] private Health _healthScript;
    public Health healthScript { get { return _healthScript; } set { _healthScript = value; } }



    [Header("Input")]

    private string _controlName;
    public string controlName { get { return _controlName; } set { _controlName = value; } }


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


    public virtual void Attack()
    {
        Debug.LogError("No Attack Assinged");
    }

}
