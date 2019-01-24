using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GpuInstancingManager : MonoBehaviour {

    public GameObject prefab;

    public Material material;

	void Start () {
		
        for(int x = -10; x < 10; x++)
        {
            for (int y = -10; y < 10; y++)
            {
                for (int z = -10; z < 10; z++)
                {
                    var go = Instantiate(prefab, new Vector3(x, y, z) * 1.2f, Quaternion.identity);
                    go.GetComponent<MeshRenderer>().sharedMaterial = material;
                }
            }
        }
    }
	
	void Update () {
		
	}
}
