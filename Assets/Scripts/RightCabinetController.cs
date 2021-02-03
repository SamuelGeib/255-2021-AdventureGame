using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCabinetController : MonoBehaviour
{

    public Transform cabinetDoorRight;



    // The angle of the door in degrees
    private float rightDoorAngle = 0;


    public float rightAnimLength = 0.5f;
    private float rightAnimTimer = 0;
    private bool rightAnimIsPlaying = false;


    private bool rightIsClosed = true;

    // Start is called before the first frame update
    void Start()
    {
        
     
    }

    // Update is called once per frame
    void Update()
    {

       

        //Play the animation

        if(rightAnimIsPlaying)
        {
            if (!rightIsClosed)
            rightAnimTimer += Time.deltaTime; // Playing forward
            else
                rightAnimTimer -= Time.deltaTime; // Playing backward

            float percent = rightAnimTimer / rightAnimLength;

            if (percent < 0 && rightIsClosed) 
            {
                percent = 0;
                rightAnimIsPlaying = false;
            }
            if (percent > 1 && !rightIsClosed)
            {
                percent = 1;
                rightAnimIsPlaying = false;
            }
            cabinetDoorRight.localRotation = Quaternion.Euler(0, rightDoorAngle * percent, 0); // Set angle of doorArt
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
        if (rightAnimIsPlaying) return; // Skips everything else in the function
        //if (!Inventory.main.hasKey) return; Player does not need the key.

        Vector3 disToPlayer = position - transform.position;

        disToPlayer = disToPlayer.normalized;

        bool playerOnOtherSide = (Vector3.Dot(disToPlayer, transform.right) > 0);

        if (!rightIsClosed)
        {
            rightDoorAngle = -90;
            //if (playerOnOtherSide) doorAngle = -90;
        }

        // if (!isClosed) doorAngle = (playerOnOtherSide) ? -90 : 90; // Turnary Operator Google.

        rightIsClosed = !rightIsClosed; // toggles the state
        
        rightAnimIsPlaying = true;

        // Set playhead to end or beginning
        if (rightIsClosed) rightAnimTimer = rightAnimLength;
        else rightAnimTimer = 0;
    }

}
