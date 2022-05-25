using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string _name;
    private float _moveSpeed = 1f;

    //ENCAPSULATION//
    public float moveSpeed
    {
        get { return _moveSpeed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Cannot set negative move speed.");
            }
            else
            {
                _moveSpeed = value;
            }
        }
    }


    public virtual void Move()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        }
        
    }

}
