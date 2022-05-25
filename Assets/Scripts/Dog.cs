using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    private void Start()
    {
        base._name = "Spot";
    }

    private void Update()
    {
        Move();
    }
}
