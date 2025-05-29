using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        // Increase player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        // Reduce player's running speed
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
