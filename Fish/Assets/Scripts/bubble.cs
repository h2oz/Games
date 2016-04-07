using UnityEngine;
using System.Collections;

public class bubble : MonoBehaviour
{
    Vector2 velocity = new Vector2(-2, 0);
    float range = 5;

    // Use this for initialization
    void Start()
    {
        float r = Random.value;
        transform.localScale = new Vector3(transform.localScale.x * r, transform.localScale.y * r, transform.localScale.z);
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        transform.position = new Vector4(transform.position.x - 0.02f, transform.position.y, transform.position.z);
        //transform.localScale = new Vector3(transform.localScale.x * 1f, transform.localScale.y * 1f, transform.localScale.z);
        if (screenPosition.x < -3)
        {
            Destroy(this.gameObject);
        }
    }
}
