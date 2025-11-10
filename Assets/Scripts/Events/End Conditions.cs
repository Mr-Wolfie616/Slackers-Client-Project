using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndConditions : MonoBehaviour
{
    // create end conditions
    //  when timer end 
    //  when all three alians die 
    //  when manager runs out of bullets 
    //  when all tasks are complete 

    void Update()
    {

    }
    
    public void Endgame()
    {
        Debug.Log("HELLO");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
