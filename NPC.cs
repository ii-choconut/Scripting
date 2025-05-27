using UnityEngine;

public class NPC : MonoBehaviour
{
    // NPC Info
    public int health = 5;
    public float speed = 1.2f;
    public int level = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        health = health + level;
        print("Health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        // Rec current pos
        Vector3 newPosition = transform.position;

        // Update z-axis based on speed and time between frames
        newPosition.z += speed * Time.deltaTime;

        // Assign new pos back to the NPC transform
        transform.position = newPosition;

        print(transform.position);

    }
}
