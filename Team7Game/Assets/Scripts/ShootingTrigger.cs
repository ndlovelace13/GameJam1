using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrigger : MonoBehaviour
{
    [SerializeField] private GameObject plunger;
    [SerializeField] private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            plunger.GetComponent<PlungerMechanic>().canShoot = true;
        }
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            plunger.GetComponent<PlungerMechanic>().canShoot = false;
        }
    }
}
