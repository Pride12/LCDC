using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneGizmosScript : MonoBehaviour {

    public float radius=1;
    public Vector3 offsetSphere;
    public Vector3 offsetCube;
    public Vector3 shapeCube;


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position+offsetSphere, radius);

        Gizmos.DrawWireCube(transform.position + offsetCube, shapeCube);
    }
}
