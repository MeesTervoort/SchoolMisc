using System;
using UnityEngine;

public class scriptingit : MonoBehaviour
{
    public string size = "Short";
    public int feet = 5;
    public bool isTall = false;

    public int health = 100;
    public bool Isdead = false;
    public new string name = "Berry :3";
    public int Defense = 10;

    public int WeakAttack = 35;
    public int StrongAttack = 80;

    public int a = 10;
    public int b = 20;
    


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
            SmallAttack();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            BigAttack();
        }   
        

        if (Input.GetKeyDown(KeyCode.C))
        {
            Greet(name);
            Debug.Log("Isdead: " + Isdead);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Max(a, b);
        }


        if (health <= 0)
        {
            health = 0;
            Debug.Log("You are dead");
            Isdead = true;
            health = 1;
        }
    }

    public void SmallAttack()
    {
        int damage = WeakAttack - Defense;
        Debug.Log("Damage dealt: " + damage);
        health -= WeakAttack - Defense;
        Debug.Log("Health: " + health);
    }
    public void BigAttack()
    {
        int damage = StrongAttack - Defense;
        Debug.Log("Damage dealt: " + damage);
        health -= StrongAttack - Defense;
        Debug.Log("Health: " + health);
    }
    public void Greet(string Name)
    {
        Debug.Log("Hallo, " + Name + "!");
    }
    public void Max(int a, int b)
    {
        if (a > b)
        {
            Debug.Log("The maximum value is: " + a + " from a");
        }
        else
        {
            Debug.Log("The maximum value is: " + b + " from b");
        }
    }
}
