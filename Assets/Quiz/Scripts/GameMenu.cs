using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart_1()
    {
        SceneManager.LoadScene("GameScene_1");
    }

    public void GameStart_2()
    {
        SceneManager.LoadScene("GameScene_2");
    }

    public void GameStart_3()
    {
        SceneManager.LoadScene("GameScene_3");
    }

    public void GameStart_4()
    {
        SceneManager.LoadScene("GameScene_4");
    }

    public void GameStart_5()
    {
        SceneManager.LoadScene("GameScene_5");

    }

    public void GameStart_6()
    {
        SceneManager.LoadScene("GameScene_6");

    }

    public void GameStart_7()
    {
        SceneManager.LoadScene("GameScene_7");

    }

    public void GameStart_8()
    {
        SceneManager.LoadScene("GameScene_8");

    }

    public void GameStart_9()
    {
        SceneManager.LoadScene("GameScene_9");

    }

    public void GameStart_10()
    {
        SceneManager.LoadScene("GameScene_10");

    }

    public void GameStart_11()
    {
        SceneManager.LoadScene("GameScene_11");

    }

    public void GameStart_12()
    {
        SceneManager.LoadScene("GameScene_12");

    }


    public void ReturnButton()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
