using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public string BotonMenu = "Pausa";
    public string BotonContinuar = "Continuar";

    public string BotonQuitarGame = "QuitarGame";


    // Update is called once per frame
    void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown(BotonMenu) || CrossPlatformInputManager.GetButtonDown(BotonContinuar))
        {
            if(GameIsPaused)
            {
                Continuar();
            }
            else
            {
                Pausa();
            }
        }
         else if (CrossPlatformInputManager.GetButtonDown(BotonQuitarGame))
         {
            QuitarGame();
         }
        
    }

    void Continuar ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pausa ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

     public void QuitarGame()
    {
        Debug.Log("Salió del juego");
        Application.Quit();
    }
}
