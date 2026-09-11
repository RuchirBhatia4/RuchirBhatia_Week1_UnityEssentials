using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-world seconds it takes for one full day to pass.")]
    [Min(1f)]
    public float secondsPerDay = 120f;

    void Update()
    {
        float rotationSpeed = 360f / secondsPerDay;

        transform.Rotate(
            rotationSpeed * Time.deltaTime,
            0f,
            0f,
            Space.Self
        );
    }
}