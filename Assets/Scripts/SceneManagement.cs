using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class SceneManagement : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene("MainScene");
    }
}
