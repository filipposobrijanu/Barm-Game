using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public ScoreManager sm;

    public SpriteRenderer gun;

    public Sprite pistol;
    public Sprite shotgun;
    public Sprite ak;
    public Sprite sniper;

    public GameObject Gun;
    public GameObject muzzleflash;

    public void Start()
    {
        if(sm.lastpressedguns == 0)
        {
            
            gun.sprite = pistol;
            gun.transform.localScale = new Vector3((float)0.5, (float)0.5);
            gun.transform.localPosition = new Vector3((float)3.3, (float)-1.51);
            muzzleflash.transform.localPosition = new Vector3((float)5.21, (float)1.58);

        }
        else if (sm.lastpressedguns == 1)
        {

            gun.sprite = shotgun;
            gun.transform.localScale = new Vector3((float)0.6, (float)0.8);
            gun.transform.localPosition = new Vector3((float)4.3, (float)-1.51);
            muzzleflash.transform.localPosition = new Vector3((float)9.74, (float)0.99);

        }
        else if (sm.lastpressedguns == 2)
        {

            gun.sprite = ak;
            gun.transform.localScale = new Vector3((float)0.55, (float)0.55);
            gun.transform.localPosition = new Vector3((float)4.2, (float)-1.6);
            muzzleflash.transform.localPosition = new Vector3((float)9.02, (float)1.54);

        }
        else if (sm.lastpressedguns == 3)
        {

            gun.sprite = sniper;
            gun.transform.localScale = new Vector3((float)0.6, (float)0.8);
            gun.transform.localPosition = new Vector3((float)4.65, (float)-1.36);
            muzzleflash.transform.localPosition = new Vector3((float)10.26, (float)0.37);

        }
    }
}
