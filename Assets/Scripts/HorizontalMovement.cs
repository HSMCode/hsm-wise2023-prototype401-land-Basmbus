using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovementX : MonoBehaviour
{
    public float speed = 2f;
    private int direction = 1;

    void Update()
    {
        MoveHorizontally();
    }

    void MoveHorizontally()
    {
        float newX = transform.position.x + direction * speed * Time.deltaTime;
        newX = Mathf.Clamp(newX, -8f, 8f);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        // Ändere die Richtung und drehe um 180 Grad, wenn die Grenzen erreicht werden
        if (newX <= -8f || newX >= 8f)
        {
            direction *= -1;
            Rotate180Degrees();
        }
    }

    void Rotate180Degrees()
    {
        // Drehe das GameObject um 180 Grad um die X-Achse
        transform.Rotate(Vector3.up, 180f);
    }
}
