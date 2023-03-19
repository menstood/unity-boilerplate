using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugFPS : MonoBehaviour
{
    private void OnGUI()
    {
        //Display the value from GetGameFrameRate function
        GUI.Label(new Rect(10, 10, 100, 20), "FPS: " + GetGameFrameRate().ToString("0.0"));

    }

    float GetGameFrameRate()
    {

        return 1.0f / Time.smoothDeltaTime;
    }
    

}
