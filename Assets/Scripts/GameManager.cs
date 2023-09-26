using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menuScreen;
    public GameObject gameScreen;
    public GameObject gameWinScreen;
    public GameObject gameOverScreen;
    public Button playButton;
    public int winNum;
    public List<Vector2> prizePositions;
    public GameObject prize;
    public List<Button> cupButton;
    public Button cupClicked;
    public int cupClickedNum;

    void Start()
    {
        menuScreen.SetActive(true);
        SetCupInteractive(false);
        playButton.onClick.AddListener(StartGame);
    }

   
    void Update()
    {
        CupClicked();
    }

    public void StartGame()
    {
        menuScreen.SetActive(false);
        gameScreen.SetActive(true);
        SetRandomPosition();
    }

    public void SetRandomPosition()
    {
        winNum = Random.Range(0, prizePositions.Count);
        RectTransform prixetransform = prize.transform as RectTransform;
        prixetransform.anchoredPosition = prizePositions[winNum];
        SetCupInteractive(true);

    }

    public void SetCupInteractive(bool isActive)
    {
        foreach (var cup in cupButton)
        {
            cup.interactable = isActive;
        }
    }

    public void CupClicked()
    {
        if (cupClicked != null)
        {
            cupClicked.gameObject.SetActive(false);
            if (cupClickedNum == winNum)
            {
                Debug.Log("win");
                Invoke("GameWin", 1);
            }
            else
            {
                Debug.Log("lose");
                Invoke("GameLose", 1);
            }
        }
    }

    public void GameWin()
    {
        gameWinScreen.SetActive(true);
        Invoke("LoadMenu", 3);
    }

    public void GameLose()
    {
        gameOverScreen.SetActive(true);
        Invoke("LoadMenu", 3);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("main");
    }
}
