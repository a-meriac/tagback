using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    private void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;
        }
    }
}
