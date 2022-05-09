
using UnityEngine;
using UnityEngine.UI;


public class BuildMode : MonoBehaviour
{
    public bool buildmode = false;

    public string unit = "none";

    [SerializeField] GameObject mine2x2;
    [SerializeField] GameObject mine3x2; //это мины если что. их префаб
    [SerializeField] GameObject mine4x2;
    [SerializeField] GameObject mine5x2;
    [SerializeField] GameObject mine6x2;

    public ParticleSystem spawnEffect2x2;
    public ParticleSystem spawnEffect3x2;
    public ParticleSystem spawnEffect4x2;  //это эффект спавна если все прошло положительно
    public ParticleSystem spawnEffect5x2;
    public ParticleSystem spawnEffect6x2;


    public bool blockSpawn2x2 = false;
    public bool blockSpawn3x2 = false;   //это переменная, которая следит за тем, поставлен ли наш блок на поле или нет
    public bool blockSpawn4x2 = false;
    public bool blockSpawn5x2 = false;
    public bool blockSpawn6x2 = false;

    public ParticleSystem BlockedEffect2x2;
    public ParticleSystem BlockedEffect3x2;  //собственно, это эффект,если мы хотим поставить блок на блок
    public ParticleSystem BlockedEffect4x2;
    public ParticleSystem BlockedEffect5x2;
    public ParticleSystem BlockedEffect6x2;




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

    public void Button4x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn4x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine4x2);
                    spawnEffect4x2.Play();
                    blockSpawn4x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect4x2.Play();
            }
        }

    }

    public void Button5x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn5x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine5x2);
                    spawnEffect5x2.Play();
                    blockSpawn5x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect5x2.Play();
            }
        }

    }

    public void Button6x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn6x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine6x2);
                    spawnEffect6x2.Play();
                    blockSpawn6x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect6x2.Play();
            }
        }


    }

}
