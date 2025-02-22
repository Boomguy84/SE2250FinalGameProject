using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUpSceneScript : MonoBehaviour {
    //variable declaration
    public string player;
    public GameObject Swordsman;
    public GameObject Knight;
    public GameObject Gino;
    public Scene Scene;
    public string SceneName;

    // awake is called before the first frame update
    void Awake() {
        //gets the scene from scenemanager and sets the SceneName variable to the name of the sceen
        Scene = SceneManager.GetActiveScene(); 
        SceneName = Scene.name;

        //gets the hero choice from memory 
        player = PlayerPrefs.GetString("Hero");

        //switch to determine which character to render
        switch (player){
            case "Swordsman":
                //instantiates character
                Instantiate(Swordsman);

                //if the players health is bigger than 0 on memory, then makes that the players health
                if(PlayerPrefs.GetFloat("Health")>0){
                    ParentPlayer.health = PlayerPrefs.GetFloat("Health");
                }

                //if the 2nd level is reached, replenish player health
                if(SceneName == "_Scene_3"){
                    ParentPlayer.health = ParentPlayer.maxHealth;
                }
                break;

            case "Knight":
                //instantiates character
                Instantiate(Knight);

                //if the players health is bigger than 0 on memory, then makes that the players health
                if(PlayerPrefs.GetFloat("Health")>0){
                    ParentPlayer.health = PlayerPrefs.GetFloat("Health");
                }

                //if the 2nd level is reached, replenish player health
                if(SceneName == "_Scene_3"){
                    ParentPlayer.health = ParentPlayer.maxHealth;
                }
                break;

            case "Gino":
                //instantiates character
                Instantiate(Gino);

                //if the players health is bigger than 0 on memory, then makes that the players health
                if(PlayerPrefs.GetFloat("Health")>0){
                    ParentPlayer.health = PlayerPrefs.GetFloat("Health");
                }

                //if the 2nd level is reached, replenish player health
                if(SceneName == "_Scene_3"){
                    ParentPlayer.health = ParentPlayer.maxHealth;
                }
                break;
        }
    }
}
