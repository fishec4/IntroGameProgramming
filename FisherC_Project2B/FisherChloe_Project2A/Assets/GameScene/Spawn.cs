using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn : MonoBehaviour
{
    public GameObject fallingprefab;
    public GameObject prefabcontainer;

    private void PrefabSpawn()
    {
        GameObject prefabInstance = Instantiate(fallingprefab, transform.position, Quaternion.identity);
        prefabInstance.transform.SetParent(prefabcontainer.transform);
        
    }

    
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        InvokeRepeating("PrefabSpawn", 3, 2);
        

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetInt("DeathParam", 1);
            Time.timeScale = 1;
        }
    }
}





