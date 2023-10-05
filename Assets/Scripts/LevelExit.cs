using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelExit : MonoBehaviour
{
     float time = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            StartCoroutine(OnReplayLevel());

        }



    }

    IEnumerator  OnReplayLevel()
    {
        yield return new WaitForSecondsRealtime(time);
            SceneManager.LoadScene("Level 2");
            FindObjectOfType<ScenePersist>().ResetScenePersist();

      
    }
    
}
