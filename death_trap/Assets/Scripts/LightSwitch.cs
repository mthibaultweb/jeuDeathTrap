using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public LightBehavior light;
    private bool canSwitch = false;
    [SerializeField] private SpriteRenderer mainSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSwitch && Input.GetKeyDown(KeyCode.UpArrow)){
            light.SwitchOffOn();
            mainSprite.flipY = !mainSprite.flipY;
        }
    }

        private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player"){
            canSwitch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            canSwitch = false;
        }
    }
}
