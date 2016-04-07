using UnityEngine;

public class Generate2 : MonoBehaviour
{
    public GameObject Crevettes2;
    float health = 100f;
    float lifelossSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1.5f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate(Crevettes2);
    }
}