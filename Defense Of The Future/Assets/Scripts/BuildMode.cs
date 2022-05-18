
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
    [SerializeField] GameObject mine7x2;
    [SerializeField] GameObject mine8x2;
    [SerializeField] GameObject mine9x2;
    [SerializeField] GameObject mine1x2;

    [SerializeField] GameObject mine2x3;
    [SerializeField] GameObject mine3x3; //это мины если что. их префаб
    [SerializeField] GameObject mine4x3;
    [SerializeField] GameObject mine5x3;
    [SerializeField] GameObject mine6x3;
    [SerializeField] GameObject mine7x3;
    [SerializeField] GameObject mine8x3;
    [SerializeField] GameObject mine9x3;
    [SerializeField] GameObject mine1x3;

    //

    public ParticleSystem spawnEffect2x2;
    public ParticleSystem spawnEffect3x2;
    public ParticleSystem spawnEffect4x2;  //это эффект спавна если все прошло положительно
    public ParticleSystem spawnEffect5x2;
    public ParticleSystem spawnEffect6x2;
    public ParticleSystem spawnEffect7x2;
    public ParticleSystem spawnEffect8x2;
    public ParticleSystem spawnEffect9x2;
    public ParticleSystem spawnEffect1x2;


    public ParticleSystem spawnEffect2x3;
    public ParticleSystem spawnEffect3x3;
    public ParticleSystem spawnEffect4x3;  //это эффект спавна если все прошло положительно
    public ParticleSystem spawnEffect5x3;
    public ParticleSystem spawnEffect6x3;
    public ParticleSystem spawnEffect7x3;
    public ParticleSystem spawnEffect8x3;
    public ParticleSystem spawnEffect9x3;
    public ParticleSystem spawnEffect1x3;

    //

    public bool blockSpawn2x2 = false;
    public bool blockSpawn3x2 = false;   //это переменная, которая следит за тем, поставлен ли наш блок на поле или нет
    public bool blockSpawn4x2 = false;
    public bool blockSpawn5x2 = false;
    public bool blockSpawn6x2 = false;
    public bool blockSpawn7x2 = false;
    public bool blockSpawn8x2 = false;
    public bool blockSpawn9x2 = false;
    public bool blockSpawn1x2 = false;

    public bool blockSpawn2x3 = false;
    public bool blockSpawn3x3 = false;   //это переменная, которая следит за тем, поставлен ли наш блок на поле или нет
    public bool blockSpawn4x3 = false;
    public bool blockSpawn5x3 = false;
    public bool blockSpawn6x3 = false;
    public bool blockSpawn7x3 = false;
    public bool blockSpawn8x3 = false;
    public bool blockSpawn9x3 = false;
    public bool blockSpawn1x3 = false;

    //

    public ParticleSystem BlockedEffect2x2;
    public ParticleSystem BlockedEffect3x2;  //собственно, это эффект,если мы хотим поставить блок на блок
    public ParticleSystem BlockedEffect4x2;
    public ParticleSystem BlockedEffect5x2;
    public ParticleSystem BlockedEffect6x2;
    public ParticleSystem BlockedEffect7x2;
    public ParticleSystem BlockedEffect8x2;
    public ParticleSystem BlockedEffect9x2;
    public ParticleSystem BlockedEffect1x2;

    public ParticleSystem BlockedEffect2x3;
    public ParticleSystem BlockedEffect3x3;  //собственно, это эффект,если мы хотим поставить блок на блок
    public ParticleSystem BlockedEffect4x3;
    public ParticleSystem BlockedEffect5x3;
    public ParticleSystem BlockedEffect6x3;
    public ParticleSystem BlockedEffect7x3;
    public ParticleSystem BlockedEffect8x3;
    public ParticleSystem BlockedEffect9x3;
    public ParticleSystem BlockedEffect1x3;






    public void MineSpawn()
    {
        if (buildmode == true)
        {
            unit = "none";
            buildmode = false;
        }
        else
        {
            buildmode = true;
            unit = "mine";
        }
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

    public void Button7x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn7x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine7x2);
                    spawnEffect7x2.Play();
                    blockSpawn7x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect7x2.Play();
            }
        }


    }

    public void Button8x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn8x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine8x2);
                    spawnEffect8x2.Play();
                    blockSpawn8x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect8x2.Play();
            }
        }


    }

    public void Button9x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn9x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine9x2);
                    spawnEffect9x2.Play();
                    blockSpawn9x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect9x2.Play();
            }
        }


    }

    public void Button1x2()
    {
        if (buildmode == true)
        {
            if (blockSpawn1x2 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine1x2);
                    spawnEffect1x2.Play();
                    blockSpawn1x2 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect1x2.Play();
            }
        }


    }


    //


    

    public void Button2x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn2x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine2x3);

                    spawnEffect2x3.Play();
                    blockSpawn2x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect2x3.Play();
            }
        }

    }

    public void Button3x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn3x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine3x3);

                    spawnEffect3x3.Play();
                    blockSpawn3x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect3x3.Play();
            }
        }

    }

    public void Button4x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn4x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine4x3);
                    spawnEffect4x3.Play();
                    blockSpawn4x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect4x3.Play();
            }
        }

    }

    public void Button5x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn5x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine5x3);
                    spawnEffect5x3.Play();
                    blockSpawn5x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect5x3.Play();
            }
        }

    }

    public void Button6x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn6x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine6x3);
                    spawnEffect6x3.Play();
                    blockSpawn6x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect6x3.Play();
            }
        }


    }

    public void Button7x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn7x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine7x3);
                    spawnEffect7x3.Play();
                    blockSpawn7x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect7x3.Play();
            }
        }


    }

    public void Button8x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn8x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine8x3);
                    spawnEffect8x3.Play();
                    blockSpawn8x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect8x3.Play();
            }
        }


    }

    public void Button9x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn9x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine9x3);
                    spawnEffect9x3.Play();
                    blockSpawn9x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect9x3.Play();
            }
        }


    }

    public void Button1x3()
    {
        if (buildmode == true)
        {
            if (blockSpawn1x3 == false)
            {
                if (unit == "mine")
                {
                    Instantiate(mine1x3);
                    spawnEffect1x3.Play();
                    blockSpawn1x3 = true;
                    buildmode = false;
                }
            }
            else
            {
                BlockedEffect1x3.Play();
            }
        }


    }

}
