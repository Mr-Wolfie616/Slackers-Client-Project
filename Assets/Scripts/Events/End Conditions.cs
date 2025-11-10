using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndConditions : MonoBehaviour
{
    // create end conditions
    //  when timer end DONE
    //  when all three aliens die 
    //  when manager runs out of bullets 
    //  when all tasks are complete 

    void Start()
    {

    }
    
    void Update()
    {

    }
    
    public void Endgame()
    {
        Debug.Log("HELLO");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
