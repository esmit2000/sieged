﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitMovement : MonoBehaviour {

    private Transform target;
    private float speed = 5;
    
    void Start()
    {
        target = this.GetComponentInParent<Player>().transform;
    }
    
    // every frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Debug.Log(target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
