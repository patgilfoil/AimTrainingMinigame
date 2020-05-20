using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A class that keeps track of time and splits timer after a cutoff
 */
public class TimerBehavior : MonoBehaviour
{
    /*
     * The amount of time that has passed
     */
    private float time;
    /*
     * The amount of time that has passed after a cutoff
     */
    private float timeAfterCutoff;
    /*
     * The reference to a target object
     */
    private ClickableTargetBehavior target;
    /*
     * The reference to a text UI object to display the timer
     */
    public Text timer;

    private bool timerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "Time: " + time.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        //update timer
        if (timerOn)
        {
            time += Time.deltaTime;
            timeAfterCutoff += Time.deltaTime;
            timer.text = "Time: " + time.ToString("F2");
        }
    }

    public void ToggleTimer()
    {
        timerOn = !timerOn;
    }

    public float TimerCutoff()
    {
        float timeCut = timeAfterCutoff;
        timeAfterCutoff = 0.0f;
        return timeCut;
    }
}
