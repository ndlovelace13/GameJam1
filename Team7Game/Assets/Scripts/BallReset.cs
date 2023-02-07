using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody body;
    [SerializeField] private GameObject plunger;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            Reset();
        }
    }

    public void Reset()
    {
        transform.position = startPosition;
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        plunger.GetComponent<PlungerMechanic>().canShoot = true;
    }


}
