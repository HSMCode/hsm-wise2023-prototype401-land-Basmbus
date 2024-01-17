using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovementX : MonoBehaviour
{
    public float speed = 2f; // Geschwindigkeit der Bewegung
    private int direction = 1; // Richtung der Bewegung: 1 für rechts, -1 für links

    void Update()
    {
        MoveHorizontally();
    }

    void MoveHorizontally()
    {
        // Bewege das Objekt in horizontaler Richtung
        float newX = transform.position.x + direction * speed * Time.deltaTime;
        newX = Mathf.Clamp(newX, -5f, 5f); // Begrenze die Position zwischen -3 und 3
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        // Ändere die Richtung, wenn die Grenzen erreicht werden
        if (newX <= -5f || newX >= 5f)
        {
            direction *= -1;
        }
    }
}