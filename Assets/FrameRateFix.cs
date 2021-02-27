using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateFix : MonoBehaviour
{
    public int FrameRate = 60;

    private void Awake()
    {
        ChangeFrameRate(FrameRate);
    }

    public void ChangeFrameRate(int frameRate)
    {
        FrameRate = frameRate;
        Application.targetFrameRate = FrameRate;
    }
}
