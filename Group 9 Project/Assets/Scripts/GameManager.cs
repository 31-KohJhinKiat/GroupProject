using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //healthbar
    public Slider HealthBar;

    //score
    public int scoreValue;
    public Text ScoreText;

    //timer
    public float levelTime;
    private float elapsedGameTime;
    public Text TimerText;

    //audio
    private AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // call the time function
        elapsedGameTime -= Time.deltaTime;
        SetTimeText(elapsedGameTime);

        if (levelTime > 0)
        {
            levelTime -= Time.deltaTime;
            TimerText.GetComponent<Text>().text = "Time left: " + FormatTime(levelTime);
        }
        else
        {
            levelTime = 0;
            SceneManager.LoadScene("GameOverScene");
            print("Times up!");

        }
    }

    public void UpdateHealthBar(int health)
    {
        HealthBar.GetComponent<Slider>().value = health;
    }

    public void addScore(int score)
    {
        scoreValue = scoreValue + score ;
        ScoreText.GetComponent<Text>().text = "Score: " + scoreValue;
    }

    // For time text
    public void SetTimeText(float time)
    {
        TimerText.text = "Timer: " + FormatTime(time);
    }

    private string FormatTime(float time)
    {
        int intTime = (int)time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        float fraction = time * 1000;
        fraction = (fraction % 1000);
        string timerText = System.String.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
        return timerText;
    }

}
