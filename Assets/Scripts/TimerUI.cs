using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    public float spielzeitDauer = 60f; // 1 Minute in Sekunden
    private float verbleibendeZeit;
    public TextMeshProUGUI timerText;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        verbleibendeZeit = spielzeitDauer;
    }

    void Update()
    {
        if (verbleibendeZeit > 0f)
        {
            verbleibendeZeit -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            SpielBeenden();
        }
    }

    void UpdateTimerText()
    {
        int minuten = Mathf.FloorToInt(verbleibendeZeit / 60f);
        int sekunden = Mathf.FloorToInt(verbleibendeZeit % 60f);
        string zeitText = string.Format("{0:00}:{1:00}", minuten, sekunden);
        timerText.text = "Verbleibende Zeit: " + zeitText;
    }

    void SpielBeenden()
    {
        Debug.Log("Spiel beendet!"); // Hier könntest du weitere Aktionen hinzufügen
        
       SceneManager.LoadScene("Endszene"); // Lade die Endszene
     
    }
}

