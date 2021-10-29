using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerControls : CharacterBehavior
{

    int nbRuby;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    // public DialogManager dialogDisplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        
        if(IsGrounded())
        {
            animator.SetBool("IsJumping", false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        } else {
            animator.SetBool("IsJumping", true);
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Ruby")
        {
            nbRuby ++;
            Destroy(collision.gameObject);
            text.text = nbRuby.ToString();
        }

        if (collision.tag == "YouWin")
        {
           
                SceneManager.LoadScene(3);
           
        }

        if (collision.tag == "Level2")
        {
            SceneManager.LoadScene(6);
        }
    }

   
}

