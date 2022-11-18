using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PerlinNoiseMap : MonoBehaviour
{
    Dictionary<int, GameObject> tileset;
    Dictionary<int, GameObject> tileGroups;

    public GameObject prefabDirt;
    public GameObject prefabGrass;
    public GameObject prefabGrassPlant;
    public GameObject prefabBush;

    // Start is called before the first frame update
    void Start()
    {
        CreateTileset();
        CreateTileGroups();
    }

    void CreateTileset()
    {
        tileset = new()
        {
            { 0, prefabDirt },
            { 1, prefabGrass },
            { 2, prefabGrassPlant },
            { 3, prefabBush }
        };
    }

    void CreateTileGroups()
    {
        tileGroups = new();
        foreach (KeyValuePair<int, GameObject> prefabPair in tileset)
        {
            GameObject tileGroup = new(prefabPair.Value.name);
            tileGroup.transform.parent = gameObject.transform;
            tileGroup.transform.localPosition = Vector3.zero;
            // Add tileGroup to tileGroups
            tileGroups.Add(prefabPair.Key, tileGroup);
        }
    }
}
