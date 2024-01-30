using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    public float forwardRate = 3 / 2;
    private float timer = 0;
    private float timerR = 0;
   

    void Update()
    {
        // Check if the "R" key is being held down
        if (Input.GetKey(KeyCode.R))
        {
            // Stop the movement while the key is held down

            timerR += Time.deltaTime;
        }
        else
        {
            // Continue normal movement logic
            if (timer < forwardRate)
            {
                timer += Time.deltaTime;
                transform.position += velocity * Time.deltaTime;
            }
            else
            {
                transform.position -= velocity * Time.deltaTime;
                timerR = 0;
            }
        }
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
