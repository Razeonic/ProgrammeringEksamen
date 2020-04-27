using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerEvent : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            Application.LoadLevel("MainMenu");
    }

}
