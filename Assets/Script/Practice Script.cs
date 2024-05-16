using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Models : MonoBehaviour
{
    
    void Start()
    {
        Gun M4A4 = new Gun();
        M4A4.model = "M4A4";
        M4A4.color = "Grey";
        M4A4.year = 2014;

        Gun MP9 = new Gun();
        MP9.model = "MP9";
        M4A4.color = "Grey";
        M4A4.year = 1985;

        Debug.Log(M4A4.model);
        Debug.Log(MP9.model);

        MP9.fullPower();
    }
}

class Gun
{
    public string model;
    public string color;
    public int year;
    public void fullPower()
    {
        Debug.Log($"The {model} is a gun!");
    }
}
