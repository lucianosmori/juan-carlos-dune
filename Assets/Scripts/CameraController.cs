using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // Reference to the player
    public Vector3 offset = new Vector3(0, 10, -10); // Offset from the player
    public float angle = 45f; // Angle for the isometric view

    void LateUpdate()
    {
        if (player != null)
        {
            // Set the camera position with the offset
            transform.position = player.position + offset;

            // Rotate the camera to the desired angle
            transform.rotation = Quaternion.Euler(angle, 1, 0);
        }
    }
}