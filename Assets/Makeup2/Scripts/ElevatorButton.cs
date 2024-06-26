using UnityEngine;

//TODO: This script should be attached to each button on your elevator

public class ElevatorButton : MonoBehaviour
{
    //TODO: You need to assign the reference to the elevator in the inspector of this button
    [SerializeField] private Elevator elevator;
    [SerializeField] private int floor;

    //TODO: You will need to create a couple of materials to represent selected and not selected states
    [SerializeField] private Material defaultMat;
    [SerializeField] private Material selectedMat;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        //TODO: Use GetComponent to get the MeshRenderer attached to this button and assign it to meshRenderer
    }

    public void Press()
    {
        //TODO: Call GoToFloor and pass in the floor
    }

    public void Select()
    {
        //TODO: Change the material of the meshRenderer to selectedMat
    }

    public void UnSelect()
    {
        //TODO: Change the material of the meshRenderer to the defaultMat
    }
}
