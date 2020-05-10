using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    void OnMouseUp(){
        SceneManager.LoadScene("MainScene", LoadSceneMode.Additive);
        Debug.Log("Changed Scene!");
    }



}
