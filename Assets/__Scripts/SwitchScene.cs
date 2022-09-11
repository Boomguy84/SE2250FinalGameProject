using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {
    //when trigger collider is entered 
    private void OnTriggerEnter2D(Collider2D collision) {
        //If the tag is equal to "Hero"
        if (collision.gameObject.tag == "Hero") {
            //Commit it to local memory
            PlayerPrefs.SetFloat("Health",ParentPlayer.health);

            //Call the complete level method. 
            CompleteLevel();
        }
    }

    //called when the player completes the level 
    private void CompleteLevel() {
        //returns the index of the scene based on the scene value
        if (SceneManager.GetActiveScene().buildIndex % 2 == 1) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (SceneManager.GetActiveScene().buildIndex % 2 == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
