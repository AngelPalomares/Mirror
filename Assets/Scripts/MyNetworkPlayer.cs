using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SyncVar][SerializeField] private string displayeName = "Missing Name";
    [SyncVar]
    [SerializeField] private Color Colour;

    [Server]
    public void SetDisplayName(string displayName)
    {
        displayeName = displayName;
    }

    [Server] 
    public void SetColour(Color colour)
    {
        Colour = colour;
    }
}
