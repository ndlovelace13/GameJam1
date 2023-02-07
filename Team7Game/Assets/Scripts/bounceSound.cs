using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bounceSound : MonoBehaviour
{
    public AudioSource bounce;
    // Start is called before the first frame update
    void Start()
    {
        bounce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            bounce.Play();
        }
    }
}
