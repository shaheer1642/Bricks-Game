using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class BallCollision : MonoBehaviour
{
    public int score;
    public TMP_Text scoreRef;
    // Start is called before the first frame update test
    void Start()
    {
        scoreRef.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        Debug.Log("OnCollisionEnter " + col.gameObject.name);
        if (col.gameObject.name == "Paddle") {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.velocity *= 1.3f;
        }
        if (col.gameObject.name == "Brick") {
            Destroy(col.gameObject);
            Debug.Log("Destroyed " + col.gameObject.name);
            score+=5;
            Debug.Log("Score " + score);
            scoreRef.text = "Score: " + score;
        }
        if (col.gameObject.name == "BrickEndLevel") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
