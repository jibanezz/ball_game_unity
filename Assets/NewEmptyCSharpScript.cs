using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public float speed = 50f; // Speed of the sphere movement

    void Update()
    {
        // Get input from arrow keys or WASD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a new vector for movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the sphere
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}

