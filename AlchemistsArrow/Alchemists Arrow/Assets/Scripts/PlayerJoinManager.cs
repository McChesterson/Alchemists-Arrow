using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using System.ComponentModel;

public class PlayerJoinManager : NetworkBehaviour
{
    public Image[] joinIcons = { null, null, null, null };
    public Color player1JoinedColor;
    public Color player2JoinedColor;
    public Color player3JoinedColor;
    public Color player4JoinedColor;
    int currentAvailibleSpot;
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Initialize();
    }
    private void Initialize()
    {
        currentAvailibleSpot = 0;
    }
    private void OnPlayerConnected()
    {
        Debug.Log("player joined");
    }
}