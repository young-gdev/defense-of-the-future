
using UnityEngine;
using UnityEngine.UI;


public class BuildMode : MonoBehaviour
{
    public bool buildmode = false;

    public string unit = "none";

    [SerializeField] GameObject mine2x2;
    [SerializeField] GameObject mine3x2;

    public ParticleSystem spawnEffect2x2;
    public ParticleSystem spawnEffect3x2;

    public bool blockSpawn2x2 = false;
    public bool blockSpawn3x2 = false;

    public ParticleSystem BlockedEffect2x2;
    public ParticleSystem BlockedEffect3x2;



    public void MineSpawn()
    {
        buildmode = true;
        unit = "mine";
    }

    public void Button2x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn2x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine2x2);
                    
                    spawnEffect2x2.Play();
                    blockSpawn2x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect2x2.Play();
            }
        }
        
    }

    public void Button3x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn3x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine3x2);

                    spawnEffect3x2.Play();
                    blockSpawn3x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect3x2.Play();
            }
        }

    }
}
