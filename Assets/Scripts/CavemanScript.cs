using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavemanScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float floatStrength;
    public float Speed_after_collision;
    public float time_​after_collision;
    public float back_​to_speed;
    [SerializeField] string Pipe_Up;

    private bool isTriggered = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * floatStrength;
        }

        if (isTriggered)
        {
            StartCoroutine(ChangeStrengthForDuration(Speed_after_collision, time_​after_collision, () => floatStrength = back_​to_speed));
            isTriggered = false; // Reset the flag
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Pipe_Up))
        {
            //Debug.Log("hii");
            isTriggered = true; // Set the flag to start the coroutine
        }
    }

    private IEnumerator ChangeStrengthForDuration(float newStrength, float duration, System.Action callback)
    {
        // Apply the new strength
        float originalStrength = floatStrength;
        floatStrength = newStrength;

        yield return new WaitForSeconds(duration);

        // Restore the original strength
        floatStrength = originalStrength;

        // Execute the callback after waiting
        callback?.Invoke();
    }
}
