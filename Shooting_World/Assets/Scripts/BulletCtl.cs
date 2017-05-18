using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtl : MonoBehaviour {

    //총알 프리팹생성
    public GameObject bulletPrefab;
    public GameObject FirebulletPrefab;
    public GameObject BluebulletPrefab;

    //총알스폰지역 만들기
    public Transform bulletSpawn;

    public void Fire_Bullet()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);



        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;


        Destroy(bullet, 2.0f);

      //  }
        
    }

    public void Fire_BlueBullet()
    {
        // Create the Bullet from the Bullet Prefab
        var Bluebullet = (GameObject)Instantiate(
            BluebulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);



        // Add velocity to the bullet
        Bluebullet.GetComponent<Rigidbody>().velocity = Bluebullet.transform.forward * 6;


        Destroy(Bluebullet, 2.0f);

        //  }

    }

    public void Fire_FireBullet()
    {

        var Firebullet = (GameObject)Instantiate(
    FirebulletPrefab,
    bulletSpawn.position,
    bulletSpawn.rotation);


        // Add velocity to the bullet
 
        Firebullet.GetComponent<Rigidbody>().velocity = Firebullet.transform.forward * 6;

        Destroy(Firebullet, 2.0f);
        //  }

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Fire_Bullet();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Fire_FireBullet();
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            Fire_BlueBullet();
        }
    }
}

