using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour {

    public Collider attackRadius;
    private Vector3 moving = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int direction = Random.Range(1, 4);
        if (direction == 1)
        {
            this.transform.position += Vector3.forward * 0.1f;
        }
        if (direction == 2)
        {
            this.transform.position += Vector3.back * 0.1f;
        }
        if (direction == 3)
        {
            this.transform.position += Vector3.right * 0.1f;
        }
        else
        {
            this.transform.position += Vector3.left * 0.1f;
        }
    }
}
