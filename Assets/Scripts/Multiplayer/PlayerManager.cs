using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public List<PlayerInput> players = new List<PlayerInput>();
    [SerializeField]
    private List<Transform> startPositions = new List<Transform>();

    private PlayerInputManager playerInputManager;
    public PlayerCustomise customise1, customise2;


    private void Awake()
    {
        playerInputManager = FindAnyObjectByType<PlayerInputManager>();
    }
    private void OnEnable()
    {
       playerInputManager.onPlayerJoined += AddPlayer;
    }
    private void OnDisable()
    {
       playerInputManager.onPlayerJoined -= AddPlayer;
    }

    public void AddPlayer(PlayerInput player)
    {
        players.Add(player);

        player.transform.position = startPositions[players.Count - 1].position;
        customise1.StartCustomize();
        customise2.StartCustomize();

            players[0].tag = "P1";
            players[0].gameObject.GetComponent<ObjectiveManager>().PlayerStart();

            players[1].tag = "P2";
            players[1].gameObject.GetComponent<ObjectiveManager>().PlayerStart();
        
    }   
}
