using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static void PlayButtonClicked()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public static void LevSelToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
