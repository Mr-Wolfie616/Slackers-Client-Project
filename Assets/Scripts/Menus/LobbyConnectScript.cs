using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyConnectScript : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;

    void Start()
    {
        hostButton.onClick.AddListener(HostButtonOnClick);
        clientButton.onClick.AddListener(ClientButtonOnClick);

        DontDestroyOnLoad(gameObject);
    }

    public void HostButtonOnClick()
    {
        NetworkManager.Singleton.StartHost();
    }

    public void ClientButtonOnClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
