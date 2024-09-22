using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed;
    Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update() {
        
        if(Input.GetMouseButton(0)) {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // where we are touching

            if(touchPos.x < 0) {
                rb.AddForce(Vector2.left * moveSpeed); // force to the left
            }
            else {
                rb.AddForce(Vector2.right * moveSpeed); // force to the right
            }


        }
        else { // not pressing on the screen
            rb.velocity = Vector2.zero;
        }
    }

    // Restart the scene if lost
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Block") { // reload the scene
            SceneManager.LoadScene("Game_Scene"); // name of the scene
        }
    }



}
