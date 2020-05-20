using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A GameObject that acts as a clickable target
 */

[RequireComponent(typeof(ScorekeepingBehavior))]
[RequireComponent(typeof(TimerBehavior))]
public class ClickableTargetBehavior : MonoBehaviour
{
    /*
     * The amount of hits a target has taken
     */
    public int targetHits;
    /*
     * The maximum amount of hits a target can take
     */
    public int maxTargetHits;
    /*
     * The reference to the Scorekeeper object
     */
    public ScorekeepingBehavior scorekeeper;
    /*
     * The reference to the Timer object
     */
    public TimerBehavior timer;

    // Start is called before the first frame update
    void Start()
    {
        //start at a random position
        float rand1 = Random.Range(-3.5f, 3.5f);
        float rand2 = Random.Range(-4.0f, 4.0f);
        Vector3 newPos = new Vector3(rand1, transform.position.y, rand2);
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function called when target object is clicked
    private void OnMouseDown()
    {
        //if target is clicked with LMB and target has not reached maximum number of hits
        if (Input.GetMouseButtonDown(0) && targetHits <= maxTargetHits)
        {
            if (targetHits == 0 || targetHits == maxTargetHits)
            {
                timer.ToggleTimer();
            }
            //set position to a random position in a 3.5x4 unit square
            float rand1 = Random.Range(-3.5f, 3.5f);
            float rand2 = Random.Range(-4.0f, 4.0f);
            Vector3 newPos = new Vector3(rand1, transform.position.y , rand2);
            transform.position = newPos;
            //increment the amount of times the target has been hit
            targetHits++;
            //update score
            float scoreMulti = timer.TimerCutoff();
            scorekeeper.score = scorekeeper.score + (100 - (10 * scoreMulti));
            Debug.Log(scorekeeper.score + "is score");
        }
    }
}
