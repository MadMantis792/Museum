using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
    public void PreviousScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScreen");
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExitGame()
    {
        Debug.Log("Qutting!");
        Application.Quit();
    }
}