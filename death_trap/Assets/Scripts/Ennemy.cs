using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField] private GameObject objectToLaunch;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float playerDistance;
    [SerializeField] LayerMask playerMask;
    private float flickeringChrono = 0f;
    private float flickerChrono = 0f;
    [SerializeField] float startFlickerTime = 1f;
    [SerializeField] private float speed;
    [SerializeField] private float durationBeforeSwitching;
    private float timeInCurrentDirection = 0f;
    private bool mustGoLeft = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerNearLeft())
        {
            flickerChrono += Time.deltaTime;

            if (flickerChrono > startFlickerTime)
            {
               
                GameObject newObject = Instantiate(objectToLaunch);
                newObject.GetComponent<FireProjectile>().Launch(Vector2.left);
                newObject.transform.position = this.transform.position;
                
                flickerChrono = 0f;
               
            }
        }
        if (PlayerNearRight())
        {
            flickerChrono += Time.deltaTime;

            if (flickerChrono > startFlickerTime)
            {

                GameObject newObject = Instantiate(objectToLaunch);
                newObject.GetComponent<FireProjectile>().Launch(Vector2.right);
                newObject.transform.position = this.transform.position;

                flickerChrono = 0f;

            }

        }



    }

    void FixedUpdate()
    {
        Move(Time.fixedDeltaTime);
    }
    public void Move(float dt)
    {
        timeInCurrentDirection = timeInCurrentDirection + dt;
        if (mustGoLeft)
        {
            rb2D.MovePosition(rb2D.position + dt * speed * Vector2.left);
        }
        else
        {
            rb2D.MovePosition(rb2D.position + dt * speed * Vector2.right);
        }
        if (timeInCurrentDirection > durationBeforeSwitching)
        {
            mustGoLeft = !mustGoLeft; // signifie : mustGoLeft devient la valeur opposée
            timeInCurrentDirection = 0f;
        }
    }
    public bool PlayerNearLeft()
    {
        RaycastHit2D hit = Physics2D.Raycast(rb2D.position, Vector2.left, playerDistance, playerMask);
        Debug.DrawRay(rb2D.position, Vector2.left * playerDistance, Color.red);
        return hit.collider != null;
    }

    public bool PlayerNearRight()
    {
        RaycastHit2D hit = Physics2D.Raycast(rb2D.position, Vector2.right, playerDistance, playerMask);
        Debug.DrawRay(rb2D.position, Vector2.right * playerDistance, Color.red);
        return hit.collider != null;
    }
}
