using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SphereShapeCylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        ModifShape();
	}

    void ModifShape()
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.parent.localScale.x, transform.localScale.z);

    }

}
