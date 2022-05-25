using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cat : Animal
{
    private float catSpeed = 1.5f;

    //POLYMORPHISM/ABSTRACTION
    public override void Move()
    {
        base.Move();
    }

    private void Start()
    {
        base._name = "Remy";
        base.moveSpeed *= catSpeed;
    }

    private void Update()
    {           
        Move();
    }
}
