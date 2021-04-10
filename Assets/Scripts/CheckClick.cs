using UnityEngine;

public class CheckClick : MonoBehaviour
{
    bool isClicked;

    public void IsClicked(GameObject prefab)
    {
        isClicked = true;
        StartCoroutine(LoadScene.SwitchBackToMainScene("SampleScene", this.gameObject.scene.name, () => { ARobjectManager.instance.AddNewObject(prefab); }));
    }
}
