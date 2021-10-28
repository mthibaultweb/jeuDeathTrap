using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private float life = 100f;
    [SerializeField] private Light2D haloLight = null;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetHealth(life);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(light.intensity);
        EndLife();
    }

    public void EndLife()
    {
        if (haloLight == null)
        {
            return;
        }
        Debug.Log("EndLife");
        if (haloLight.intensity >= 0.4)
        {
            Debug.Log("vie -1");
            life = life - 10 * Time.deltaTime;
            healthBar.SetHealth(life);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Halo") {
            haloLight = collision.GetComponent<Light2D>();
        }
        if (collision.gameObject.tag == "Fire")
        {
            life = life - 10;
            healthBar.SetHealth(life);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Light")
        {
            haloLight = null;
        }
    }


}
