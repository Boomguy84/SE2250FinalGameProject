using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    //variable declaration
    public Vector3 LaunchOffset;
    
    private void Start() {
        //if "Ranged" is equal to "Bomb" then a bomb will be thrown 
        if (PlayerPrefs.GetString("Ranged")=="Bomb") {
            //set the direction 
            var direction = -transform.right + Vector3.down;

            //add the corresponding force 
            GetComponent<Rigidbody2D>().AddForce(direction * 8, ForceMode2D.Impulse);
        }

        //destroys the bomb 
        Destroy(gameObject, 0.5f);
    }

}
