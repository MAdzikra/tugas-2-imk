using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) // Jika tombol Q ditekan
        {
            Debug.Log("Quit button pressed! Exiting game...");
            Application.Quit();

        }
    }
}
