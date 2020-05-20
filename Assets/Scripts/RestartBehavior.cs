using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 * A class that gets a GameObject to display after completion
 */
public class RestartBehavior : MonoBehaviour
{
    /*
     * The current score
     */
    public GameObject restartButton;
    /*
     * The current score
     */
    public ClickableTargetBehavior target;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (target.targetHits == target.maxTargetHits)
        {
            restartButton.gameObject.SetActive(true);
            Debug.Log("Button should appear");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
