using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Remove_Cam : NetworkBehaviour
{
    public override void OnStartLocalPlayer()
    {
        if (isLocalPlayer)
        {
            GetComponentInChildren<Camera>().enabled = true;
        }
    }
}
