using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HitsText : MonoBehaviour
{
    public TextMeshProUGUI pointsText;

    void Start()
    {
        pointsText = GetComponent<TextMeshProUGUI>();
    }

    void UpdatePointsText()
    {
        pointsText.text = "Hits " + pointsText;
    }
}
