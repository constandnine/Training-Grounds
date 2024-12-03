using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManagerTest : MonoBehaviour
{
    public BaseAttackClass attack;
    // Start is called before the first frame update
    void Start()
    {
        attack.Attack();
    }
}
