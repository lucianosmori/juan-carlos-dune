using UnityEngine;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MainScript has started!");
    }

    // Update is called once per frame
    void Update()
    {
        // Add update logic here
    }

    // OnGUI is called for rendering and handling GUI events
    void OnGUI()
    {
        // Display "Hello, World!" at the top-left corner of the screen
        GUI.Label(new Rect(10, 10, 100, 20), "Hello, World!");
    }
}