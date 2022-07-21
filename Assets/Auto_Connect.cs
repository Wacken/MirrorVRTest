using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Connect : MonoBehaviour
{
    NetworkManager manager;

    [SerializeField] string ip_adress;
    [SerializeField] bool should_autoconnect = false;

    void Awake()
    {
        manager = GetComponent<NetworkManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (should_autoconnect)
        {
            StartCoroutine(wait_till_connect());
        }
    }

    private IEnumerator wait_till_connect()
    {
        yield return new WaitForSeconds(5);
        manager.networkAddress = ip_adress;
        manager.StartClient();
    }

}
