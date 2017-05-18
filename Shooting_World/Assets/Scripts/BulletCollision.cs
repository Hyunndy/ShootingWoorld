using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {

        string key = other.tag;
        //여기다가 포인트를 넣는다.

        switch (key)
        {

            case "Enemy":

                other.gameObject.SetActive(false);

                break;

        }

    }
}
