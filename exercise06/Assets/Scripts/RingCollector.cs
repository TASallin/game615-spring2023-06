using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCollector : MonoBehaviour
{
    public bool isEnemy;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("ring")) {
            Destroy(other.gameObject);
            if (isEnemy) {
                gm.GachaPoint();
            } else {
                gm.PlayerPoint();
            }
        }
    }
}
