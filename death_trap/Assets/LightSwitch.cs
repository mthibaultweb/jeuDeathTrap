using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public LightBehavior light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("enter");
        if(other.gameObject.tag == "Player"){
            light.SwitchOffOn();
            Debug.Log("work");
        }
    }
}
