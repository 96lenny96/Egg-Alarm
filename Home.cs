using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CrossPlatformInputManager.GetButtonDown ("play"))
        {
            SceneManager.LoadScene ("Main Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown ("play"))
        {
            SceneManager.LoadScene ("Lvl1");
        }
    }
}
