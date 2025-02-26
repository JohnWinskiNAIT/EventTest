using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float hInput, vInput, movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hInput * movementSpeed * Time.deltaTime, 0, vInput * movementSpeed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.B))
        {
            MyEvents.Activate.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            MyEvents.ChangeColor.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            MyEvents.ChangeColorIndex.Invoke(2);
        }
    }
}
