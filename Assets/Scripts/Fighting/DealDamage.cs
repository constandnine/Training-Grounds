using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FightManager;

public class DealDamage : MonoBehaviour
{
    [Header("Damage Values")]

    [SerializeField] private StaminaLossValue damageValue;

    [SerializeField] private float powerHitDamageMultiplier;


    private void OnTriggerEnter(Collider other)
    {
        
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
