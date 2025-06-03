using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger
        if (other.CompareTag("Player"))
        {
            // Get the Jump component on the player
            Jump playerJump = other.GetComponent<Jump>();

            // Increase the jump strength to a higher value
            if (playerJump != null)
            {
                playerJump.jumpStrength = 10;
            }
        }
    }

    // Called when another collider exits the trigger zone
    private void OnTriggerExit(Collider other)
    {
        // Check if the player exited the trigger
        if (other.CompareTag("Player"))
        {
            // Get jump component on the player
            Jump playerJump = other.GetComponent<Jump>();

            // Reset jump strength back to the og value
            if (playerJump != null)
            {
                playerJump.jumpStrength = 4;
            }
        }
    }

}
