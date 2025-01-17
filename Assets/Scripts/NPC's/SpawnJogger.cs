using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJogger : MonoBehaviour
{
    [Header("Jogger")]

    [SerializeField] private GameObject jogger;
    public int joggerIndex;


    void Update()
    {
        if(joggerIndex == 0)
        {
            OnSpawnJogger();
        }
    }

    private void OnSpawnJogger()
    {
        joggerIndex ++;


        Instantiate(jogger, transform);
    }
}
