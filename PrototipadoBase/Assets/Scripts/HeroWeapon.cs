using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWeapon : MonoBehaviour
{
    public HeroBullet bulletPrefab;
    public float frequency = 0.2f;
    public float angle = 0f;

   


    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(0))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.red, 10f);

            var bulletDirection = Quaternion.LookRotation(transform.forward) * Quaternion.AngleAxis(angle, Vector3.up);
            var bullet = Instantiate(bulletPrefab, transform.position, bulletDirection);
  

           // timer += Time.deltaTime;
           // if (timer > frequency)
           // {
           //     timer = 0;
           // }
        }

    }
}
