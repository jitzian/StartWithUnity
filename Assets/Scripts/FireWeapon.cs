using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    private string tag = "FireWeapon";
    public float damageAmount = 1f;
    public float range = 150;
    public Camera playerCamera;

    // Start is called before the first frame update
    void Start() {
        //Empty on purpose
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }

    }

    private void Shoot(){
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range)) {
            Debug.Log("$TAG"+hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null) {
                target.OnDamageEventReceived(damageAmount);
            }
        }
    }
}
