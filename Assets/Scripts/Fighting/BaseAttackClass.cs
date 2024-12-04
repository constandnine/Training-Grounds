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


    public void CheckButton(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            controlName = context.control.name;
        }
    }


    public virtual void Attack()
    {
        print("Doing the base attack!");
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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            connected = true;


            objectiveManager.UpdateObjective();
        }
    }
}
