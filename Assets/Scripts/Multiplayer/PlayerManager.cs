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

        if(players.Count > 1)
        {
            players[0].tag = "P1";
            players[0].gameObject.GetComponent<ObjectiveManager>().PlayerStart();

            players[1].tag = "P2";
            players[1].gameObject.GetComponent<ObjectiveManager>().PlayerStart();
        }
    }   
}
