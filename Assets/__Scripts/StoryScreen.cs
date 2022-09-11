using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScreen : MonoBehaviour {
    //the string holds the variable for the name of the scene that is going to be changed to
    public string screen;

    //method gets called when the button is clicked
    public void PressOk() {
        //wwitches scene based on the string value that is defined in Unity
        SceneManager.LoadScene(screen);
    }
}
