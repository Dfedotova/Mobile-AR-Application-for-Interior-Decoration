using UnityEngine;

public class Scrolling_6 : MonoBehaviour
{
    int count;

    [Header("Other Objects")]
    public GameObject panPrefab_1;
    public GameObject panPrefab_2;
    public GameObject panPrefab_3;
    public GameObject panPrefab_4;
    public GameObject panPrefab_5;
    public GameObject panPrefab_6;

    GameObject[] instPans;

    void Start()
    {
        GameObject[] prefabs = new GameObject[] { panPrefab_1, panPrefab_2, panPrefab_3, panPrefab_4, panPrefab_5, panPrefab_6 };
        count = prefabs.Length;

        instPans = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            instPans[i] = Instantiate(prefabs[i], transform, false);
            if (i == 0) continue;
        }
    }
}