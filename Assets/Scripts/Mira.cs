using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour {
    public float sensitivity = 100f;
    public Transform player1;

    public float xRotation = 0f;


    // Start is called before the first frame update
    void Start() {
        //Configure cursor to be locked at the center of the game
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        //Stores rotation position
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player1.Rotate(Vector3.up * mouseX);


    }
}
