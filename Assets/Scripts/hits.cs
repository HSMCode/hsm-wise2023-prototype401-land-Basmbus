using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hits : MonoBehaviour
{
    public int points = 0;
    public TMP_Text pointsText;
    
    public void add()
    {
        points = points + 1;
    }

    void Update()
    {
        pointsText.text = "Hits " + points;
    }
}
