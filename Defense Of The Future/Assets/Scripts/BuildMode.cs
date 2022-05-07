using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BuildMode : MonoBehaviour
{
    public bool buildmode = false;
    public string prefab = "none";
    [SerializeField] GameObject mine;


    public void MineSpawn()
    {
        buildmode = true;
        prefab = "mine";
    }
    
    public void SpawnAnyObject()
    {
        if (prefab == "mine")
        {
            Instantiate(mine);
        }
    }
}
