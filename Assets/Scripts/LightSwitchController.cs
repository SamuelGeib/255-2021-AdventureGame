using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour
{
    bool lightIsOn = false;
    public Light lightBulb;
    public Light lightBulb1;
    public Light lightBulb2;
    public Light lightBulb3;
    public Light lightBulb4;

    public Material lightBulbOn;
    public Material lightBulbOff;


    public GameObject lightBulbObject;
    public GameObject lightBulbObject1;
    public GameObject lightBulbObject2;
    public GameObject lightBulbObject3;
    public GameObject lightBulbObject4;


    LightBulbController LightBulbController;

    //LightBulbController lightBulb = GetComponent<LightBulbController>;
   

   // GameObject[] LightBulb = GameObject.FindGameObjectsWithTag("LightBulb");
    
    // Start is called before the first frame update
    public void PlayerInteract()
    {
        if (lightIsOn == false)
        {
            lightBulb.intensity = 1;
            lightBulbObject.GetComponent<Renderer>().material = lightBulbOn; 
            lightBulb1.intensity = 1;
            lightBulbObject1.GetComponent<Renderer>().material = lightBulbOn;
            lightBulb2.intensity = 1;
            lightBulbObject2.GetComponent<Renderer>().material = lightBulbOn;
            lightBulb3.intensity = 1;
            lightBulbObject3.GetComponent<Renderer>().material = lightBulbOn;
            lightBulb4.intensity = 1;
            lightBulbObject4.GetComponent<Renderer>().material = lightBulbOn;
            lightIsOn = true;
           
        } else if (lightIsOn == true)
        {
            lightBulb.intensity = 0.1f;
            lightBulbObject.GetComponent<Renderer>().material = lightBulbOff;
            lightBulb1.intensity = 0.1f;
            lightBulbObject1.GetComponent<Renderer>().material = lightBulbOff;
            lightBulb2.intensity = 0.1f;
            lightBulbObject2.GetComponent<Renderer>().material = lightBulbOff;
            lightBulb3.intensity = 0.1f;
            lightBulbObject3.GetComponent<Renderer>().material = lightBulbOff;
            lightBulb4.intensity = 0.1f;
            lightBulbObject4.GetComponent<Renderer>().material = lightBulbOff;
            lightIsOn = false;

        }
    }
}
