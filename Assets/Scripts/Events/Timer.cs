using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float duration = 600;
    public TextMeshProUGUI Countdown;

    // Update is called once per frame
    void Update()
    {
        if (duration > 0f)
        {
            duration -= Time.deltaTime;

            if (duration < 0f)
            {
                duration = 0f;
            }

            DisplayTime(duration);

            if (duration <= 0f)
            {
                Debug.Log("Game Over!!");
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        int Seconds = Mathf.FloorToInt(duration % 60);
        int Minutes = Mathf.FloorToInt(duration / 60);
        Countdown.text = string.Format("{0:00}:{1:00}", Minutes, Seconds);
    }
}
