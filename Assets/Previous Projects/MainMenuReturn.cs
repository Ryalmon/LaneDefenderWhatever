/*****************************************************************************
// File Name :         MainMenuReturn.cs
// Author :            Ashton Mutnansky
// Creation Date :     April 11, 2022
//
// Brief Description : This is a script that returns players to the main
                       menu from the other UI menus
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReturn : MonoBehaviour
{
    /// <summary>
    /// MainMenu function that changes the scene manager from current scene
    /// back to main menu screen.
    /// </summary>
    public void MainMenu()
    {
        // SceneManager changes scene back to main menu
        SceneManager.LoadScene("Main Menu");
    }
}
