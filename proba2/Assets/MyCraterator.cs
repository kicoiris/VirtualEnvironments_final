using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCraterator : MonoBehaviour {
    public TerrainDeformer deformer;
    public Transform deformator;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            Ray rayCheck = new Ray(deformator.position, deformator.forward);
            Debug.DrawRay(rayCheck.origin, rayCheck.direction * 100);

            RaycastHit hitInfo;
            if (Physics.Raycast(rayCheck, out hitInfo, 100))
            {
                deformer.DestroyTerrain(hitInfo.point, 4);
            }
        }
    }
}
