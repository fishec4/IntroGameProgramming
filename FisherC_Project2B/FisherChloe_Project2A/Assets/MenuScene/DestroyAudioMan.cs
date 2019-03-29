using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudioMan : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("AudioMan");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
		
	}
	
}
