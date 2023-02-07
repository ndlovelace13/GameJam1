using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariableStorage : MonoBehaviour
{
    TMPro.TMP_Text text;
    public static int ballsLeft;
    // Start is called before the first frame update
    void Start()
    {
        ballsLeft = 3;
        text = GetComponent<TMPro.TMP_Text>();
        text.text = $"Balls: {ballsLeft}";
    }

    // Update is called once per frame
    void Update()
    {

        if (ballsLeft > -1)
        {
            text.text = $"Balls: {ballsLeft}";
        }
        
    }
}
