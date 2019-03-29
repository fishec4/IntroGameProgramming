using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawn : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag== "Collector")
        {
            Destroy(this);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
