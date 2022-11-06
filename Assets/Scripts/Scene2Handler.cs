using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Handler : MonoBehaviour
{
    public static void NewGame()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	Debug.Log("Reset the Scene...");
        //SceneManager.LoadScene("Scene", LoadSceneMode.Single);
    }

    public static void mainMenu()
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    	//SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }

    public static void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}