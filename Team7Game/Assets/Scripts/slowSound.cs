using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class slowSound : MonoBehaviour
{
    public AudioSource slow;
    // Start is called before the first frame update
    void Start()
    {
        slow = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) )
        {
            slow.Play();
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
