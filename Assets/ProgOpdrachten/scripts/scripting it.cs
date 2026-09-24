using UnityEngine;

public class scriptingit : MonoBehaviour
{
    public string size = "Short";
    public int feet = 5;
    public bool isTall = false;
    void Start()
    {
        Debug.Log("Size: " + size);
        Debug.Log("Feet: " + feet);
        Debug.Log("Is Tall: " + isTall);
    }

    void Update()
    {
        
    }
}
