using UnityEngine;

public class Generate3 : MonoBehaviour {

    public GameObject bbles;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 3f, 2f);
    }

    void CreateObstacle()
    {
        Instantiate(bbles);
    }
}
