using UnityEngine;

public class ARobjectManager : MonoBehaviour
{
    public static ARobjectManager instance;
    public Transform groundPlane;

    void Awake()
    {
        instance = this;
    }

    public void AddNewObject(GameObject gameObject)
    {
        Instantiate(gameObject, groundPlane);
    }
}
