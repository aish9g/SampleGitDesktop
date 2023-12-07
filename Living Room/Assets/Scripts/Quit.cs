using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    void Update()
    {
        // Check if the "Escape" key (Esc) is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quit the application
            Application.Quit();
        }
    }
}