using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RangedAbility : MonoBehaviour {
    //string to hold the name of the next scene
    public string screen;

    //called when the gun button is selected
    public void ChooseGun() {
        //sets the players ranged ability to gun
        PlayerPrefs.SetString("Ranged","Gun");

        //goes to the next scene
        SceneManager.LoadScene(screen);
    }

    //Called when the bomb button is selected
    public void ChooseSplashBomb() {
        //sets the players ranged ability to bomb
        PlayerPrefs.SetString("Ranged","Bomb");

        //goes to the next scene
        SceneManager.LoadScene(screen);
    }
}
