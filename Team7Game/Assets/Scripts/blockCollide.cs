using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockCollide : MonoBehaviour
{

    public Rigidbody rb;
    public AudioSource slow;
    public AudioSource bounce;
    bool playing1;
    bool playing2;
    // Start is called before the first frame update
    void Start()
    {
        playing1 = false;
        playing2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 20);
    }

    IEnumerator OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "bounce")
        {
            rb.velocity = rb.velocity * 2;
            if (playing1 == false)
            {
                playing1 = true;
                bounce.Play();
                yield return new WaitForSeconds(2);
                playing1 = false;
            }
        }

        if (collision.gameObject.tag == "slow")
        {
            rb.velocity = Vector3.down;
            if (playing2 == false)
            {
                playing2 = true;
                slow.Play();
                yield return new WaitForSeconds(2);
                playing2 = false;
            }
        }

    }

    IEnumerator OnCollisionStay (Collision collision)
    {
        if (collision.gameObject.tag == "movingBounce")
        {
            rb.velocity = rb.velocity * 70;
            if (playing1 == false)
            {
                playing1 = true;
                bounce.Play();
                yield return new WaitForSeconds(2);
                playing1 = false;
            }
        }
    }
}
