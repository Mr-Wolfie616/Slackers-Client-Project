using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndConditions : MonoBehaviour
{
    //create end conditions
    //  when timer end DONE
    //  when all three aliens die
    //  when manager runs out of bullets DONE
    //  when all tasks are complete
    //      Create score scripts
    //      when score is full end

    public void Endgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
