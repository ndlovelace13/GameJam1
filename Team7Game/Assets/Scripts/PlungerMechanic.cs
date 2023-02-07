using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlungerMechanic : MonoBehaviour
{
    public AudioSource ticksource;
    [SerializeField] private float power = 0.0f;
    private float maxPower = 1.1f;
    [SerializeField] private bool shooting = false;
    [SerializeField] public bool canShoot = true;
    private Vector3 startPosition;
    [SerializeField] Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        ticksource = GetComponent<AudioSource>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !shooting && canShoot)
        {
            if (power < maxPower)
            {
                transform.Translate(-Time.deltaTime, 0, 0);
                power += Time.deltaTime;
            }
            else
            {
                power = maxPower;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space) && canShoot)
        {
            ticksource.Play();
            shooting = true;
        }
        else if (shooting)
        {
            if (power > 0)
            {
                body.AddForce(power, 0, 0, ForceMode.Impulse);
                transform.Translate(14*Time.deltaTime, 0, 0);
                power -= 14*Time.deltaTime;
            }
            else
            {
                transform.position = startPosition;
                power = 0.0f;
                shooting = false;
            }
        }
    }

    /*private void OnCollisionStay(Collision collision)
    {
        if ((collision.gameObject.tag == "Player") && shooting)
        {
            body.AddForce(power, 0, 0, ForceMode.Impulse);
        }
    }
    */
}
