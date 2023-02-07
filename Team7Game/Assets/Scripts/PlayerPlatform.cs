using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]

    private Rigidbody rb;
    private float dirZ;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirZ = Input.GetAxis("Horizontal") * moveSpeed * -1;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, dirZ);
    }
}
