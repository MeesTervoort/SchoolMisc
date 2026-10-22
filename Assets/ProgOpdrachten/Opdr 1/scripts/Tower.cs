using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        float x = Random.Range(0f, 1f);
        float y = 1f;
        float z = Random.Range(0f, 1f);

        transform.localScale = new Vector3(x, y, z);

        Color randomColor = Random.ColorHSV();
        GetComponent<Renderer>().material.color = randomColor;
    }

    void Update()
    {
        
    }
}
