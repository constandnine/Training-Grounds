using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseAttackClass : MonoBehaviour
{
    [Header("script reference")]
        
    [SerializeField] public ObjectiveManager objectiveManager;
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

    [SerializeField] private float _staminaloss;
    public float staminaloss { get { return _staminaloss; } set { _staminaloss = value; } }


    [Header("Landed")]

    private bool _connected;
    public bool connected { get { return _connected; } set { _connected = value; } }


    [Header("Animator")]

    [SerializeField] private Animator _animator;
    public Animator animator { get { return _animator; } set { _animator = value; } }


    [Header("Audio")]

    [SerializeField] private AudioSource _hitSound;
    public AudioSource hitSound { get { return _hitSound;} set { _hitSound = value; } }


    private void Start()
    {
        objectiveManager = gameObject.GetComponent<ObjectiveManager>();
    }
    public virtual void Attack()
    {
        Debug.LogError("No Attack Assinged");
    }

}
