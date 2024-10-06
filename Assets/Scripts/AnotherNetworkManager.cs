using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherNetworkManager : NetworkManager
{
    public override void OnClientConnect()
    {
        base.OnClientConnect();

        Debug.Log("I have connected to the server");
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Debug.Log("Player has joined the server");
        Debug.Log("There are these amount of players in the game " + numPlayers);
    }
}
