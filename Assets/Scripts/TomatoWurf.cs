using UnityEngine;

public class BallBewegung : MonoBehaviour
{
    public float wurfH�he = 5f; // Steuert die Wurfh�he des Balls
    public float wurfWeite = 5f; // Steuert die Wurfweite des Balls
    public KeyCode wurfTaste = KeyCode.Space; // Die Taste f�r den Wurf

    private bool wirdGeworfen = false;
    private Vector3 wurfZiel;

    void Update()
    {
        if (Input.GetKeyDown(wurfTaste) && !wirdGeworfen)
        {
            StarteWurf();
        }

        if (wirdGeworfen)
        {
            BewegeZumZiel();
        }
    }

    void StarteWurf()
    {
        wirdGeworfen = true;
        wurfZiel = new Vector3(0f, 0.7f, 0f);
    }

    void BewegeZumZiel()
    {
        float schwerkraft = -9.8f;
        float zeitSeitWurf = Time.time - Time.fixedTime;

        float x = wurfWeite * zeitSeitWurf;
        float y = wurfH�he * zeitSeitWurf + 0.5f * schwerkraft * Mathf.Pow(zeitSeitWurf, 2);

        transform.position = new Vector3(x, y, 0f);

        if (transform.position.y <= wurfZiel.y)
        {
            wirdGeworfen = false;
            transform.position = wurfZiel; // Stelle sicher, dass der Ball genau auf dem Ziel landet
        }
    }
}

