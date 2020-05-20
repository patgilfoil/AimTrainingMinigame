using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A class that tracks the score for the UI to display
 */
public class ScorekeepingBehavior : MonoBehaviour
{
    /*
     * The current score
     */
    public float score = 0.0f;
    /*
     * The current text refernce
     */
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update the text
        text.text = score.ToString();
    }
}
