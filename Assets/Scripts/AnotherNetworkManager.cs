using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AnotherNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);

        MyNetworkPlayer Player = conn.identity.GetComponent<MyNetworkPlayer>();

        MeshRenderer Color = conn.identity.GetComponentInChildren<MeshRenderer>();

        Player.SetDisplayName($"Player{numPlayers}");

        Player.SetColour(new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f)));

        Color.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
