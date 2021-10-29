﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : CharacterBehavior
{
    // [SerializeField] private Rigidbody2D rb2D;
    // [SerializeField] private SpriteRenderer mainSprite;
    // [SerializeField] private PolygonCollider2D playerCollider;
    // [SerializeField] private float MoveSpeed = 100f;
    // [SerializeField] private float JumpHeight = 200f;
    //[SerializeField] private float groundDistance = 10f;
    // [SerializeField] LayerMask groundMask;
    // public Animator animator;

    // Start is called before the first frame update
    public DialogManager dialogDisplayer;
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

        // If a dialog is on screen, the player should not be updated
        
        if (dialogDisplayer.IsOnScreen())
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "InstantDialog")
        {
            Dialog instantDialog = collision.GetComponent<Dialog>();
            if (instantDialog != null)
            {
                dialogDisplayer.SetDialog(instantDialog.GetDialog());
            }
        }
    }

    // public void Move()
    // {
    //     float currentMoveSpeed = 0f;

    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         currentMoveSpeed = -MoveSpeed;
    //         mainSprite.flipX = true;
    //     }
    //     else if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         currentMoveSpeed = MoveSpeed;
    //         mainSprite.flipX = false;
    //     }

    //     rb2D.velocity = new Vector2(currentMoveSpeed, rb2D.velocity.y);
    //     animator.SetFloat("Speed", Mathf.Abs(currentMoveSpeed));
    // }

    //     public void Move()
    // {
    //     float currentMoveSpeed = 0f;

    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //        MoveLeft();
    //     }
    //     else if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         MoveRight();
    //     }

    //     rb2D.velocity = new Vector2(currentMoveSpeed, rb2D.velocity.y);
    //     animator.SetFloat("Speed", Mathf.Abs(currentMoveSpeed));
    // }

    // public bool IsGrounded()
    // {
    //     RaycastHit2D hit = Physics2D.Raycast(rb2D.position, Vector2.down, groundDistance, groundMask);
    //     Debug.DrawRay(rb2D.position, Vector2.down * groundDistance, Color.red);
    //     return hit.collider != null; 

    // }
}

