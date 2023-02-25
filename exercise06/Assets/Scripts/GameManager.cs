using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public NavMeshAgent nma;
    public int playerScore;
    public int gachaScore;
    RaycastHit hit;
    float delay;
    public TMP_Text playerDisplay;
    public TMP_Text gachaDisplay;
    public GameObject edelgard;
    public GameObject kaga;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        gachaScore = 0;
        delay = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0) {
            delay -= Time.deltaTime;
            if (delay <= 0) {
                nma.SetDestination(hit.point);
            }
        }
        // This part checks to see if the player just clicked the left mouse button
        if (Input.GetMouseButtonDown(0)) {
            // Create a ray from where the player clicked into the 3d world
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000)) {

                // If we get in here, it means that we hit something. 'hit' is
                // an object that Unity filled with all of the info about what the Raycast hit.
                //
                // Check to make sure we actually clicked on the ground. Don't forget to
                // create and add the tag "Ground" to your ground!
                if (hit.collider.CompareTag("Ground")) {
                    delay = 0.1f;
                    // Set the destination to where the player clicked.
                    
                }
            }
        }
    }

    public void SetAgent(NavMeshAgent a) {
        nma = a;
        delay = 0;
    }

    public void PlayerPoint() {
        playerScore += 1;
        playerDisplay.text = "" + playerScore + " rings collected";
        if (playerScore == 15) {
            kaga.SetActive(true);
        }
    }

    public void GachaPoint() {
        gachaScore += 1;
        gachaDisplay.text = "" + gachaScore + " orbs collected";
        if (gachaScore == 15) {
            edelgard.SetActive(true);
        }
    }
}
