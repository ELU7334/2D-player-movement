using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
       public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          float horizontalInput = Input.GetAxis("Horizontal");
          float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * Time.deltaTime * 5 * horizontalInput);

        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }
}
