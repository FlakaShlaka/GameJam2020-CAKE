using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    public List<GameObject> objectsToSpawn;
    private List<GameObject> createdObjs = new List<GameObject>();
    
    public Vector3 levelSize = new Vector3(3,1,100);
    public Vector2 spacingOfObjects = new Vector2(3,5);
    public float startObjectsPos = 5f;
    
    public float chanceForCollectible = 40;

    private float lastZPositionOfObj = 0;
    
    void Awake()
    {
        CreateLevel();
    }

    [ContextMenu("Set Boris Level")]
    void CreateLevel()
    {
        ResetLevel();
        
        floor.transform.localScale = levelSize;
        floor.transform.position += Vector3.forward * (levelSize.z / 2);
        
        CreateObjects();
    }
    
    [ContextMenu("Reset Level")]
    void ResetLevel()
    {
        floor.transform.localScale = Vector3.one;
        floor.transform.position = Vector3.zero;

        foreach (var obj in createdObjs)
        {
            DestroyImmediate(obj);
        }
        
        createdObjs = new List<GameObject>();
        lastZPositionOfObj = 0;
    }

    void CreateObjects()
    {
        for (int i = 0; i < levelSize.z; i++)
        {
            var objToCreate = GetObjectToCreate();
            Vector3 positionToSpawn = new Vector3(
                Random.Range(-levelSize.x /2, levelSize.x /2),
                levelSize.y/2+1f,
                lastZPositionOfObj + startObjectsPos + Random.Range(spacingOfObjects.x, spacingOfObjects.y));
            
            if (positionToSpawn.z >= levelSize.z)
            {
                //TODO: Instantiate end level trigger
                break;
            }
            
            var tempObj = Instantiate(objToCreate, positionToSpawn, Quaternion.identity);
            createdObjs.Add(tempObj);

            lastZPositionOfObj = positionToSpawn.z;

            
        }
       
        //TODO Instantiate All object (loop)
    }
    
    GameObject GetObjectToCreate()
    {
        return objectsToSpawn[Random.Range(0, objectsToSpawn.Count)];
    }
}
