
using UnityEngine;
using UnityEngine.UI;


public class BuildMode : MonoBehaviour
{
    public bool buildmode = false;
    public string unit = "none";
    [SerializeField] GameObject mine;
    public ParticleSystem spawnEffect;
    public bool blockSpawn = false;
    public ParticleSystem BlockedEffect;
    


    public void MineSpawn()
    {
        buildmode = true;
        unit = "mine";
    }
    
    public void SpawnAnyObject()
    {
        if (buildmode == true)
        {
            if (blockSpawn == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine);
                    spawnEffect.Play();
                    blockSpawn = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect.Play();
            }
        }
        else
        {
        }
    }
}
