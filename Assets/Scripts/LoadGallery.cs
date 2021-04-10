using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGallery : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
