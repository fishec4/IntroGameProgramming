using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollector : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Collector");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
