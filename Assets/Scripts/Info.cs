using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject infoPanel;
    bool isClickedInfo;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    void Update()
    {
        if (isClickedInfo) infoPanel.SetActive(true);
        isClickedInfo = false;
    }

    public void InfoClicked()
    {
        isClickedInfo = true;
    }
}
