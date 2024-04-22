using UnityEngine;

//TODO: This script should be attached to the camera since we are going off of wherever the camera is looking at

public class ElevatorDetection : MonoBehaviour
{
    //Button we are currently looking at
    private ElevatorButton button;

    // Update is called once per frame
    void FixedUpdate()
    {
        FindButton();
    }

    void FindButton()
    {
        //TODO: Use Physics.Raycast to detect if the direction we are looking at is intersecting a ElevatorButton
        //      You will need to make a new Layer similar to we've done in the past and create a layerMask similar to how we
        //      did for ground detection. 
        //      If raycast successfully intersects a button then use GetComponent on the transform of the hit object to get the ElevatorButton
        //      Class and assign the value into button.
        //      Then call the Select function
        //      
        //      If there is no successful intersection from the Raycast then check if button is not null and if that is the case then
        //      call UnSelect on the button and then set the button to null afterwards to clear it out.
        //
        //      You will need to modify the direction the Raycast shoots out towards to user Vector3.forward instead of -Vector.up
        //      Again, look at the ground detection code to help you out!
        //      Make sure the layermask uses the correct number as well based on which index the layer you created for the elevator button is set to
    }

    //TODO: This function should be called from your player script
    //      You will need to create a reference to ElevatorDetection in your player script and assign it as a reference
    public ElevatorButton GetButton()
    {
        return button;
    }
}
