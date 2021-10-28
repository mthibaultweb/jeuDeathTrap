using System.Collections;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        
        if(IsGrounded())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
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

    // public bool IsGrounded()
    // {
    //     RaycastHit2D hit = Physics2D.Raycast(rb2D.position, Vector2.down, groundDistance, groundMask);
    //     Debug.DrawRay(rb2D.position, Vector2.down * groundDistance, Color.red);
    //     return hit.collider != null; 

    // }
}

