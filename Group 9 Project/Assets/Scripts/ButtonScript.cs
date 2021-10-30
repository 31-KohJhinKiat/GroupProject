using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void menuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void playButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void instructionsButton()
    {
        SceneManager.LoadScene("InstructionScene");
    }

    public void creditsButton()
    {
        SceneManager.LoadScene("CreditScene");
    }

}
