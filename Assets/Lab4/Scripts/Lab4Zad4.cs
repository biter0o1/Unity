using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4Zad4 : MonoBehaviour
{
    // ruch wokó³ osi Y bêdzie wykonywany na obiekcie gracza, wiêc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;

    public float sensitivity = 1000f;

    void Start()
    {
        // zablokowanie kursora na œrodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartoœci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotacjê wokó³ osi 


        //Zad4
        //Vector3 currentRotation = player.localRotation.eulerAngles;
        //currentRotation.x = Mathf.Clamp(currentRotation.x, 0, 90);
        //player.localRotation = Quaternion.Euler(currentRotation);



        player.Rotate(Vector3.up * mouseXMove);

        //player.rotation = Quaternion.Euler(Mathf.Clamp(player.rotation.y, -90, 90), 0, 0);



        // a dla osi X obracamy kamerê dla lokalnych koordynatów
        // -mouseYMove aby unikn¹æ ofektu mouse inverse
        transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);

    }
}