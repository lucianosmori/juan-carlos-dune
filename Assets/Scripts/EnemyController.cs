using UnityEngine;

/// <summary>
/// Controls the behavior of the enemy, including movement towards the player and self-destruction after a certain time.
/// </summary>
public class EnemyController : MonoBehaviour
{
    /// <summary>
    /// The speed at which the enemy moves.
    /// </summary>
    public float moveSpeed = 3f;

    /// <summary>
    /// The time in seconds before the enemy is destroyed.
    /// </summary>
    public float lifeTime = 10f;

    /// <summary>
    /// Reference to the player's transform.
    /// </summary>
    private Transform player;

    /// <summary>
    /// Initializes the enemy by finding the player and setting a self-destruct timer.
    /// </summary>
    void Start()
    {
        // Find the player GameObject by tag and get its transform
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player not found. Make sure the Player GameObject is tagged as 'Player'.");
        }

        // Destroy the enemy after lifeTime seconds
        Destroy(gameObject, lifeTime);
    }

    /// <summary>
    /// Updates the enemy's position to move towards the player.
    /// </summary>
    void Update()
    {
        if (player != null)
        {
            // Calculate the direction towards the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}