using UnityEngine;
using UnityEngine.UIElements;

public class Ballmaker : MonoBehaviour
{

    public GameObject ballPrefab;
    private float elapsedTime = 0f;


    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(color, randPos);
        }
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

            CreateBall(randColor);

            elapsedTime = 0f;

        }

    }
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
        //ill leave this for you future me :3
    }
}
