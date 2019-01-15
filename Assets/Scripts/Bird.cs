using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bird : MonoBehaviour
{
    public string color;
    public float height;
    public bool flight;

    private string species;
    private string[] colors = { "green", "brown" };
    private string[] speciess = { "kiwi", "Moa" };
    // Start is called before the first frame update
    void Start()
    {
        color = (Random.value > 0.5f) ? colors[0] : colors[1];
        height = Random.value * 2f;
        flight = Random.value > 0.5f;
        if (height > 1f)
        {
            species = speciess[1];
        }
        else
        {
            species = speciess[0];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
