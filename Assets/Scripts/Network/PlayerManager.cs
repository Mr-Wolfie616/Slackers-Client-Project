using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public int ManagerHealth = 4;
    private List<GameObject> Players;
    private GameObject ManagerPlayer;

    public void StartGame()
    {
        Players = FindObjectsOfType<GameObject>().ToList();
        foreach(GameObject item in Players)
            if(item != PlayerPrefab)
            {
                Players.Remove(item);
            }
        ManagerPlayer = Players[Random.Range(0,Players.Count - 1)];
        foreach(GameObject player in Players)
        {
            if(player == ManagerPlayer)
            {
                player.GetComponent<HealthManagement>().health = ManagerHealth;
                Destroy(player.GetComponent<TaskInteraction>());
            } 
            else
            {
                Destroy(player.GetComponent<ManagerGun>());
                Destroy(player.GetComponent<EndConditions>());
            }
        }
    }

    public int NumberOfAliens()
    {
        int alienCount = 0;
        foreach(GameObject player in Players)
        {
            if(player != ManagerPlayer)
            {
                alienCount += 1;
            } 
        }
        return alienCount;
    }

    public void KillAlien(GameObject alienObject)
    {
        Players.Remove(alienObject);
    }
}
