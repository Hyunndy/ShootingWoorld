using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    public ParticleSystem Fire;
    public ParticleSystem Water;
 
    public Texture normTexture;
    public Texture helmTexture;
    private SkinnedMeshRenderer skinnedMeshRenderer;

    public AudioSource Horse_Sound;

    public void Start()
    {
        Fire.Pause();
        Water.Pause();

        skinnedMeshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();  // get the first Skinned mesh renderer component (only active ones!) in the objects children
        skinnedMeshRenderer.material.mainTexture = normTexture;


    }


    public void OnTriggerEnter(Collider other)
    {

        //여기다가 포인트를 넣는다.
        switch (other.tag)
        {

             case "FireBullet":                                                                                                                                 

                other.gameObject.SetActive(false);

                GetComponent<AudioSource>().Play();

                Fire.Play();
      
              Invoke("Burn", 2.5f);

                break;

            case "Bullet":

                other.gameObject.SetActive(false);

                break;

            case "BlueBullet":

                other.gameObject.SetActive(false);
                FireEffect();
                Invoke("UnBurn", 1.5f);
                Invoke("WaterEffect", 1.5f);
                break;


        }

    }

    public void WaterEffect()
    {
        Water.Stop();
    }

    public void UnBurn()
    {
               skinnedMeshRenderer.material.mainTexture = normTexture;
    }


    public void Burn()
    {
        skinnedMeshRenderer.material.mainTexture = helmTexture;
    }

    public void FireEffect()
    {

        Fire.Stop();
        Water.Play();

    }



}
