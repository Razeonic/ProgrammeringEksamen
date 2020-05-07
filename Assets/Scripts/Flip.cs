using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{

    Vector3 characterScale;
    float characterScaleX;

    void Start()
    {
        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }

    void Update()
    {



        // Flip the Character:
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -characterScaleX;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = characterScaleX;
        }
        transform.localScale = characterScale;

    }
}

