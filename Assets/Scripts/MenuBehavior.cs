using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * A class that loads a scene from a main menu scene
 */
public class MenuBehavior : MonoBehaviour
{
    public void LoadScene(int sceneBuildIndex)
    {
        //load the scene
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
