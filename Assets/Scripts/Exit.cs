using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject infoPanel;
    bool isClickedExit;

    void Update()
    {
        if (isClickedExit) infoPanel.SetActive(false);
    }

    public void ExitClicked()
    {
        isClickedExit = true;
    }
}
