using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightBehavior : MonoBehaviour
{
    [SerializeField] private Light2D light;
    [SerializeField] private bool lightOn = true;

    private float flickeringChrono = 0f;
    private float flickerChrono = 0f;
    [SerializeField] float startFlickerTime = 2f;
    [SerializeField] float flickeringDuration = 1f;
    [SerializeField] float flickerDuration = 0.1f;



    // Debug.log(lightIntensity);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flickeringChrono += Time.deltaTime;

        if (flickeringChrono > startFlickerTime)
        {
            flickerChrono += Time.deltaTime;

            if (flickerChrono > flickerDuration)
            {
                AnimatedLight();
                flickerChrono = 0f;
            }
           
            
            if (flickeringChrono > startFlickerTime + flickeringDuration)
            {
                flickeringChrono = 0f;
            }
        }

    }

    /*void FixedUpdate()
    {
        Invoke("AnimatedLight", 2f);
    }*/



    public void SwitchOffOn()
    {
        if (lightOn)
        {
            light.intensity = 0;
            Debug.Log("it works");
            lightOn = false;
        }
        else
        {
            light.intensity = 1;
            lightOn = true;
        }


    }


    void AnimatedLight()
    {
        if (lightOn == true)
        {
        float intensity = Random.Range(0f, 1f);
        light.intensity = intensity;
        }
        else
        {
            light.intensity = 0;
        }

    }

}
