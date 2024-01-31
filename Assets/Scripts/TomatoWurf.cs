using UnityEngine;

public class TomatoWurf : MonoBehaviour
{
    public float geschwindigkeit = 5f; // Geschwindigkeit des Flugs
    public AudioClip hitSound; // Audioclip für Treffer
    private hits hits;

    void Start()
    {
        hits = GameObject.Find("GM").GetComponent<hits>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * geschwindigkeit * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elefant"))
        {
            hits.add();
            // Spiele den Sound ab, wenn das TomatoWurf-GameObject den Elefanten trifft
            if (hitSound != null)
            {
                AudioSource.PlayClipAtPoint(hitSound, transform.position);
            }

            // Zerstöre das TomatoWurf-GameObject
            Destroy(gameObject);
        }

        if (other.CompareTag("Wand"))
        {
            // Zerstöre das TomatoWurf-GameObject, wenn es eine Wand berührt
            Destroy(gameObject);
        }
    }
}


    