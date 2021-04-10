using UnityEngine;

public class Scrolling_1 : MonoBehaviour
{
    int count;

    [Header("Other Objects")]
    public GameObject panPrefab_1;

    GameObject[] instPans;

    void Start()
    {
        GameObject[] prefabs = new GameObject[] { panPrefab_1 };
        count = prefabs.Length;

        instPans = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            instPans[i] = Instantiate(prefabs[i], transform, false);
            if (i == 0) continue;
        }
    }
}