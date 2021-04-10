using System;
using System.Collections;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public void TakeAShot()
    {
        StartCoroutine("CaptureIt");
    }

    IEnumerator CaptureIt()
    {
        string timeStamp = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string path = fileName;
        ScreenCapture.CaptureScreenshot(path);
        yield return new WaitForEndOfFrame();
    }
}
