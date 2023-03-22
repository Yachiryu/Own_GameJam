using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Controles");
    }

    public void Story()
    {
        SceneManager.LoadScene("Story");
    }

    public void Objetivos()
    {
        SceneManager.LoadScene("Objetivos");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
}
