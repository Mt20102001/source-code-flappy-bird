using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool isEndGame;
    bool isStartFirstTime;
    int gamePoint = 0;
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Text txtEndPoint;
    public Button btnRestart;
    public Button btnExit;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStartFirstTime = true;
        pnlEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButton(0) && isStartFirstTime)
            {
                //ReLoad
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                Time.timeScale = 1;
            }
        }
    }

    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point:" + gamePoint.ToString();
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        StartGame();
    }

    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Your point\n" + gamePoint.ToString();
    }
}
