using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaga : MonoBehaviour
{

    public LineRenderer line;
    public GameObject explode;
    public float countdown;
    public Vector3 feh;
    public float sceneCountdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = 3;
        sceneCountdown = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
            if (countdown <= 0) {
                line.gameObject.SetActive(true);
                explode.SetActive(true);
            }
        } else {
            line.SetPositions(new Vector3[] { feh, transform.position});
        }
        sceneCountdown -= Time.deltaTime;
        if (sceneCountdown <= 0) {
            SceneManager.LoadScene("GachaIsDead");
        }
    }
}
