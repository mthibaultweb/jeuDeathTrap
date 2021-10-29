using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float fireSpeed = 2f;
    public Ennemy ennemyPosition;
    /*public Vector2 initDirection = Vector2.left;*/
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Launch(Vector2 direction)
    {
        
        rb2D.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
      //  transform.Rotate(new Vector3(0f, 0f, 80f) * fireSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
