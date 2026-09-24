using UnityEngine;

public class scriptingit : MonoBehaviour
{
    public string size = "Short";
    public int feet = 5;
    public bool isTall = false;

    public int health = 100;
    public bool Isdead = false;
    void Start()
    {
        Debug.Log("Size: " + size);
        Debug.Log("Feet: " + feet);
        Debug.Log("Is Tall: " + isTall);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 35;
            Debug.Log("Health: " + health);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            health -= 80;
            Debug.Log("Health: " + health);
            
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Isdead: " + Isdead);
        }


        if (health <= 0)
        {
            health = 0;
            Debug.Log("You are dead");
            Isdead = true;
            health = 1;
        }
    }
}
