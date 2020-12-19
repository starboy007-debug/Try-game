using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GamePlayController : MonoBehaviour
{
    public static GamePlayController instance;
    private Text lifetext;
    private Text scoretext;

    private int lifescore;
    private int score;

    void Awake()
    {
        MakeInstance();

        scoretext = GameObject.Find("Scoretext").GetComponent<Text>();
        lifetext = GameObject.Find("Lifetext").GetComponent<Text>();

    }

    private void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void IncrementScore()
    {
        score++;
        scoretext.text = "x" + score;
    }

    public void DecrementScore()
    {
        lifescore--;
        if(lifescore >= 0)
        {
            lifetext.text = "x" + lifescore;
        }
        if(lifescore < 0)
        {
            SceneManager.LoadScene("GamePlay0");
        }
    }

}
