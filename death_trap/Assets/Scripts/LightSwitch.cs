using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public LightBehavior light;
    private bool canSwitch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSwitch && Input.GetKeyDown(KeyCode.UpArrow)){
            light.SwitchOffOn();
        }
    }

        private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("enter");
        if(other.gameObject.tag == "Player"){
            canSwitch = true;
            Debug.Log("work");
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("enter");
        if(other.gameObject.tag == "Player"){
            canSwitch = false;
            Debug.Log("work");
        }
    }
}
