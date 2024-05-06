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
    public static NetworkVariable<int> currentAvailibleSpot;
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Initialize();
    }
    private void Initialize()
    {
        currentAvailibleSpot = new NetworkVariable<int>(0);
        print("Initialized");
    }

    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        print("started a server");
    }
    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        print("started a client");
    }
    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        print("started a host");
    }

    private void OnPlayerConnected()
    {
        Debug.Log("player joined");
    }
}