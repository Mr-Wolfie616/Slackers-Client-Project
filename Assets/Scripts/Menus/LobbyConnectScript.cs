using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyConnectScript : MonoBehaviour
{
    [SerializeField] private string mainScene = "MainScene";

    public void HostButtonOnClick()
    {
        NetworkManager.Singleton.StartHost();
        NetworkManager.Singleton.SceneManager.LoadScene(mainScene, LoadSceneMode.Single);
    }

    public void ClientButtonOnClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
