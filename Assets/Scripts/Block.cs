using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    void Update(){
        // if the block falls off the screen get rid of it
        if(transform.position.y < -6f) {
            Destroy(gameObject);
        }

    }
}
