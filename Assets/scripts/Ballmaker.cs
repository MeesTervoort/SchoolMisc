using UnityEngine;
using UnityEngine.UIElements;

public class Ballmaker : MonoBehaviour
{

    public GameObject ballPrefab;
    private float elapsedTime = 0f;

    private GameObject CreateBall(Color c)
    {

        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;

        material.SetColor("_Color", c);

        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }

        return ball;

    }

    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {

            GameObject ball = CreateBall(randColor);
            //DestroyBall(ball);

            elapsedTime = 0f;

        }

    }

    //void Start()
    //{

    //}

    //void Update()
    //{
    //    elapsedTime += Time.deltaTime;
    //    if (elapsedTime > 1f)
    //    {
    //        CreateBall(randColor, transform.position);
    //        elapsedTime = 0f;
    //    }

    //    float r = Random.Range(0f, 1f);
    //    float g = Random.Range(0f, 1f);
    //    float b = Random.Range(0f, 1f);
    //    Color randColor = new Color(r, g, b, 1f);

    //    elapsedTime += Time.deltaTime;

    //    if (elapsedTime > 1f)
    //    {
    //        CreateBall(randColor);
    //        elapsedTime = 0f;
    //    }
    //}


    //private void CreateBall(Color c)
    //{

    //    GameObject ball = Instantiate(ballPrefab);
    //    Material material = ball.GetComponent<MeshRenderer>().material;

    //    material.SetColor("_Color", c);

    //    if (material.shader.name == "Universal Render Pipeline/Lit")
    //    {
    //        material.SetColor("_BaseColor", c);
    //    }
    //}
}
