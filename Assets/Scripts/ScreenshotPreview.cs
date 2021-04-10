using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotPreview : MonoBehaviour
{
    [SerializeField]
    GameObject screen;
    string[] files = null;
    int currentScreenshot = 0;

    void Start()
    {
        files = Directory.GetFiles(Application.persistentDataPath + "/", "*.png");
        if (files.Length > 0) ShowTheScreenshot();
    }

    void ShowTheScreenshot()
    {
        string path = files[currentScreenshot];
        Texture2D texture = GetScreenshotImage(path);
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        screen.GetComponent<Image>().sprite = sp;
    }

    Texture2D GetScreenshotImage(string path)
    {
        Texture2D texture = null;
        byte[] fileBytes;
        if (File.Exists(path))
        {
            fileBytes = File.ReadAllBytes(path);
            texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
            texture.LoadImage(fileBytes);
        }
        return texture;
    }

    public void NextPicture()
    {
        if (files.Length > 0)
        {
            currentScreenshot += 1;
            if (currentScreenshot > files.Length - 1)
                currentScreenshot = 0;
            ShowTheScreenshot();
        }
    }

    public void PreviousPicture()
    {
        if (files.Length > 0)
        {
            currentScreenshot -= 1;
            if (currentScreenshot < 0)
                currentScreenshot = files.Length - 1;
            ShowTheScreenshot();
        }
    }
}



