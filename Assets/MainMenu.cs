using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        // Reset the time scale in case it's 0 from a previous game over state
        Time.timeScale = 1f;

        // Ensure all buttons are interactable when the menu loads
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    public void PlayGame()
    {
        // Load the next scene (assuming the game is the next scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("La game has quit");
        Application.Quit();
    }

    public void ResetMenu()
    {
        // Forcefully re-enable all buttons if they are not working
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.interactable = true;  // Make sure buttons can be clicked
        }
    }
}
