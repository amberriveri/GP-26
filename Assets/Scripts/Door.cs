using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    private bool isOpen = false;

    public void Interact()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            Debug.Log("Door opened");
            transform.Rotate(0, 90, 0);
        }
        else
        {
            Debug.Log("Door closed");
            transform.Rotate(0, -90, 0);
        }
    }
}
