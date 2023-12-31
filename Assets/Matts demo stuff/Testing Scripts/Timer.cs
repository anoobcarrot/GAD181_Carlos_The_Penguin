using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [HideInInspector] public float currentTime;
    public float startingTime = 10f;
    private bool isTimerRunning;
    public Image timerImage;

    [SerializeField] private List<Sprite> timerSprites;


    void Start()
    {
        currentTime = startingTime;
        isTimerRunning = true;
        Time.timeScale = 1f;
    }
    void Update()
    {

        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

            // Check if the timer has reached zero
            if (currentTime <= 0f)
            {
                // Stop the timer
                StopTimer();

                // Trigger game over or any other desired actions
                GameOver();
            }

    

        }

        switch (Mathf.Ceil(currentTime))
        {
            case 0:
                timerImage.sprite = timerSprites[0];
                break;
            case 1:
                timerImage.sprite = timerSprites[1];
                break;
            case 2:
                timerImage.sprite = timerSprites[2];
                break;
            case 3:
                timerImage.sprite = timerSprites[3];
                break;
            case 4:
                timerImage.sprite = timerSprites[4];
                break;
            case 5:
                timerImage.sprite = timerSprites[5];
                break;
            case 6:
                timerImage.sprite = timerSprites[6];
                break;
            case 7:
                timerImage.sprite = timerSprites[7];
                break;
            case 8:
                timerImage.sprite = timerSprites[8];
                break;
            case 9:
                timerImage.sprite = timerSprites[9];
                break;
            case 10:
                timerImage.sprite = timerSprites[10];
                break;
        }
    }

    //stop timer function that can be called
    public void StopTimer()
    {
        isTimerRunning = false;
    }

    //start timer function that can be called
    private void StartTimer()
    {
        isTimerRunning = true;
    }

    // lose condition
    public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("gameover dude");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
