using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * A GameObject that acts as a clickable target
 */

[RequireComponent(typeof(ScorekeepingBehavior))]
[RequireComponent(typeof(Text))]
public class ClickableTargetBehavior : MonoBehaviour
{
    /*
     * The amount of hits a target has taken
     */
    private int targetHits;
    /*
     * The amount of time that has passed
     */
    private float time;
    /*
     * The amount of time between the last target hit and the current target hit
     */
    private float timeCheckAfterHit;

    /*
     * The maximum amount of hits a target can take
     */
    public int maxTargetHits;
    /*
     * The reference to the Scorekeeper object
     */
    public ScorekeepingBehavior scorekeeper;
    /*
     * The reference to a text UI object to display the timer
     */
    public Text timer;

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
        //update timer
        time += Time.deltaTime;
        timer.text = "Time: " + time;
    }

    //function called when target object is clicked
    private void OnMouseDown()
    {
        //if target is clicked with LMB and target has not reached maximum number of hits
        if (Input.GetMouseButtonDown(0) && targetHits < maxTargetHits)
        {
            //set position to a random position in a 3.5x4 unit square
            float rand1 = Random.Range(-3.5f, 3.5f);
            float rand2 = Random.Range(-4.0f, 4.0f);
            Vector3 newPos = new Vector3(rand1, transform.position.y , rand2);
            transform.position = newPos;
            //increment the amount of times the target has been hit
            targetHits++;
            //update the time after hits
            timeCheckAfterHit = Time.deltaTime - timeCheckAfterHit;
            //update score
            scorekeeper.score += (100 / Time.deltaTime);
        }
    }
}
