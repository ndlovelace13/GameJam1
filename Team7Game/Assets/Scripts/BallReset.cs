using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody body;
    [SerializeField] 
    private GameObject plunger;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            Reset();
        }
    }

    public void Reset()
    {
        if (GlobalVariableStorage.ballsLeft > 0)
        {
            GlobalVariableStorage.ballsLeft--;
            transform.position = startPosition;
            body.velocity = Vector3.zero;
            body.angularVelocity = Vector3.zero;
            plunger.GetComponent<PlungerMechanic>().canShoot = true;
        }
    }


}
