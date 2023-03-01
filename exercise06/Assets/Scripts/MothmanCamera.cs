using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothmanCamera : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    float rotateCounter;
    public float rotateCountdown;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        rotateCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateCounter < 180) {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            if (rotateCountdown <= 0) {
                rotateCounter = System.Math.Min(180, rotateCounter + rotateSpeed * Time.deltaTime);
                if (rotateCounter >= 180) {
                    text.SetActive(true);
                }
                transform.rotation = Quaternion.Euler(90 - rotateCounter, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            } else {
                rotateCountdown -= Time.deltaTime;
            }
        }
    }
        
}
