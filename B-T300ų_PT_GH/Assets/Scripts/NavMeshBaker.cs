using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


// THIS IS FOR THE AI PATHS

public class NavMeshBaker : MonoBehaviour
{   
    [SerializeField]
    NavMeshSurface[] navMeshSurfaces;

    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < navMeshSurfaces.Length; i++){
            navMeshSurfaces[i].BuildNavMesh();
        }
    }
}
