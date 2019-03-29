using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour {
    public float Speed;
    public float leftEdgeValue;
    public float rightEdgeValue;
    public float directionChaneChance;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Random.value<= directionChaneChance)
        {
            Speed *= -1;
        }

        transform.position += new Vector3(1f, 0f, 0f) * Speed * Time.deltaTime;
        if (transform.position.x <= leftEdgeValue)
        {
            Speed *= -1;
            transform.position += new Vector3(1f, 0f, 0f) * Speed * Time.deltaTime; ;
        }
        if (transform.position.x >= rightEdgeValue)
        {
            Speed *= -1;
            transform.position += new Vector3(1f, 0f, 0f) * Speed * Time.deltaTime; ;
        }
    }
		
}
/* If you wanted to make the direction change at the edges of the screen a different script than the randomization code, you could do this in the randomization code:
 * 
[RequireComponent(typeof(MoveHorizantal))]** this part goes above the class line
private MoveHorizantal moveScript;
public float directionChangeChance;

void Awake()
{
    movescript = GetComponent<MoveHorizantal>();
    InvokeRepeating("Change", 1, 1);

}
void Update()
{
    if (Random.value <= directionChaneChance)
    {
        moveScript.Speed *= -1;
    }
}*/