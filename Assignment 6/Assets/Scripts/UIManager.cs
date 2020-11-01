/* Broc Edson
 * Assignment 6
 * Manages UI as well as win/end conditions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public float timer;
    public float maxTime = 30f;
    public int initialTargets = 10;
    public Text timerText;
    public Text targetText;
    public Text endText;
    public string currentScene;
    [HideInInspector] public int targetsRemaining;
    [HideInInspector] public bool ended;
    private float initialTime;
    private bool won;

    void Awake()
    {
        endText.gameObject.SetActive(false);
        targetsRemaining = initialTargets;
        initialTime = Time.time;
    }

    void Update()
    {
        timer = Time.time;
        if((maxTime - (timer - initialTime)) <= 0 && !ended)
        {
            ended = true;
        }
        else if(targetsRemaining <= 0 && !ended)
        {
            ended = true;
            won = true;
        }
        if(ended)
        {
            targetText.text = "";
            timerText.text = "";
            string endString = "";
            if(won)
            {
                endString = "You Won!";
            }
            else
            {
                endString = "You Lose!";
            }
            endString += "\nPress R to Restart";
            endText.text = endString;
            endText.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(currentScene);
            }
        }
        else
        {
            targetText.text = "Targets Left: " + targetsRemaining;
            timerText.text = "Timer: " + (int)(maxTime - (timer - initialTime));
        }
    }
}
