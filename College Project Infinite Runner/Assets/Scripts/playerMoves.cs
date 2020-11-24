using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerMoves : MonoBehaviour {

    private CharacterController controller;
    private float speed = 5.0f;
    private Vector3 moveVector;
    private float gravity = 12.0f;

    public scoreBoard sb;

    private float verticalVelocity = 0.0f;
    public Text gg;
    public deathMenu dm;
    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
       moveVector = Vector3.zero;
        if(controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity* Time.deltaTime;
        }

        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = verticalVelocity;
        moveVector.z = speed;

        controller.Move(moveVector * Time.deltaTime);
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {
            string str = sb.scoreText.text;
              Debug.Log(str);
            PlayerPrefs.SetString("xxx", str);
         //   dm.deathScore(str);
         //   Time.timeScale = 0;
           
            SceneManager.LoadScene("Game Over");
        }
    }
    public void setSpeed(float modifier)
    {
        speed = 5.0f + modifier;
    }
    
}
