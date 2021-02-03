using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WORKLIGHT : MonoBehaviour
{
    public Light workLight;

    //public GameObject WorkLight;
    // Start is called before the first frame update
    void Start()
    {
        workLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
