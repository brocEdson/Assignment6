/* Broc Edson
 * Assignment 6
 * Shoots items with raycasts - From Assignment 5
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public float hitForce = 10f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    private UIManager uiMan;

    private void Start()
    {
        uiMan = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !uiMan.ended)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            MovingTarget moveTarget = hitInfo.transform.gameObject.GetComponent<MovingTarget>();
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            if (moveTarget != null)
            {
                moveTarget.TakeDamage(damage);
            }
            else if(target != null)
            {
                target.TakeDamage(damage);
            }
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
