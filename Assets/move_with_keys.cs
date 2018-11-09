using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_with_keys : MonoBehaviour {
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public Rigidbody vector;
    // Use this for initialization
    void Start () {
        vector = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            z = 1;
        else if (Input.GetKey(KeyCode.DownArrow))
            z = -1;
        else
            z = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
            x = 1;
        else if (Input.GetKey(KeyCode.RightArrow))
            x = -1;
        else
            x = 0;
        y = -10;
        vector.velocity = new Vector3(x, y, z);
    }
}
