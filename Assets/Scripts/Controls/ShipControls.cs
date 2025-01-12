using UnityEngine;

public class ShipControls : MonoBehaviour
{
    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        HandleInput();
    }

    private void Initialize()
    {
        // Initialization logic for ship controls
    }

    private void HandleInput()
    {
        // Input handling logic for ship controls
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Time.deltaTime);
    }
}