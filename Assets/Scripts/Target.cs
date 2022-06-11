using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 2; //number of shoots the character it'll get..

    public void OnDamageEventReceived(float damageAmount) {
        health -= damageAmount;

        if(health <= 0) {
            OnDieEvent();
        }

    }

    private void OnDieEvent() {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
