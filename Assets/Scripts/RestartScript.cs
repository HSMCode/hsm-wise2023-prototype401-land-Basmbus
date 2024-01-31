using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Neustart();
        }
    }

    void Neustart()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
}

