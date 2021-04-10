using UnityEngine;

public class Scrolling_3 : MonoBehaviour
{
    int count;

    [Header("Other Objects")]
    public GameObject panPrefab_1;
    public GameObject panPrefab_2;
    public GameObject panPrefab_3;

    GameObject[] instPans;

    void Start()
    {
        GameObject[] prefabs = new GameObject[] { panPrefab_1, panPrefab_2, panPrefab_3 };
        count = prefabs.Length;

        instPans = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            instPans[i] = Instantiate(prefabs[i], transform, false);
            if (i == 0) continue;
        }
    }
}