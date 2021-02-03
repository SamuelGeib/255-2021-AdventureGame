using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCabinetController : MonoBehaviour
{

    public Transform cabinetDoorLeft;



    // The angle of the door in degrees
    private float leftDoorAngle = 0;


    public float leftAnimLength = 0.5f;
    private float leftAnimTimer = 0;
    private bool leftAnimIsPlaying = false;


    private bool leftIsClosed = true;

    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {

       

        //Play the animation

        if(leftAnimIsPlaying)
        {
            if (!leftIsClosed)
            leftAnimTimer += Time.deltaTime; // Playing forward
            else
                leftAnimTimer -= Time.deltaTime; // Playing backward

            float percent = leftAnimTimer / leftAnimLength;

            if (percent < 0 && leftIsClosed) 
            {
                percent = 0;
                leftAnimIsPlaying = false;
            }
            if (percent > 1 && !leftIsClosed)
            {
                percent = 1;
                leftAnimIsPlaying = false;
            }
            cabinetDoorLeft.localRotation = Quaternion.Euler(0, leftDoorAngle * percent, 0); // Set angle of doorArt
        }
        
    }

    private void OnMouseEnter() // This event triggers when the cursor is over the object.
    {
        //print("mouse over!");
    }
    private void OnMouseDown() // This event triggers when the user clicks on the object.
    {
        //print("Mouse Pressed!");
        // Change Something
        //Destroy(gameObject);
    }

    public void PlayerInteract(Vector3 position)
    {
        if (leftAnimIsPlaying) return; // Skips everything else in the function
        //if (!Inventory.main.hasKey) return; Player does not need the key.

        Vector3 disToPlayer = position - transform.position;

        disToPlayer = disToPlayer.normalized;

        bool playerOnOtherSide = (Vector3.Dot(disToPlayer, transform.right) > 0);

        if (!leftIsClosed)
        {
            leftDoorAngle = 90;
            //if (playerOnOtherSide) doorAngle = -90;
        }

        // if (!isClosed) doorAngle = (playerOnOtherSide) ? -90 : 90; // Turnary Operator Google.

        leftIsClosed = !leftIsClosed; // toggles the state
        
        leftAnimIsPlaying = true;

        // Set playhead to end or beginning
        if (leftIsClosed) leftAnimTimer = leftAnimLength;
        else leftAnimTimer = 0;
    }

}
