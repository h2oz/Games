using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject Crevettes;
    float lifelossSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 3f);
        Health.health = 100;
    }

    void Update()
    {
        float lostlife = Time.deltaTime * lifelossSpeed;
        Health.health = Health.health - lostlife;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.color = Color.black;
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 32;
        string bob = " Health: " + Mathf.Floor(Health.health).ToString();
        //GUILayout.Label(" Health: " + Mathf.Floor(Health.health).ToString());
        GUI.Label(new Rect(500, 50, 200, 50), " Health: " + Mathf.Floor(Health.health).ToString(), myStyle);
        GUI.Label(new Rect(10, 20, 100, 20), "Riverquest",myStyle);
    }

    void CreateObstacle()
    {
        Instantiate(Crevettes);
    }
}