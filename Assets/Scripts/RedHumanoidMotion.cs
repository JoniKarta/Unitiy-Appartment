using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHumanoidMotion : MonoBehaviour
{
    // Start is called before the first frame update
    float angularSpeed;
    float speed;
    float hMove, vMove;
    CharacterController characterController;
    void Start()
    {
        speed = 4.5f;
        angularSpeed = 100f;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            hMove = Input.GetAxis("Horizontal") * angularSpeed * Time.deltaTime;
            vMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            GetComponent<Animation>().Play("ShieldWarrior@Walk01");
            transform.Rotate(0, hMove, 0);

          /*  Vector3 pos = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 point;

            point.y = Terrain.activeTerrain.SampleHeight(pos) - transform.position.y;
            
            Vector3 direction = Vector3.forward * vMove;
            direction.y = point.y;*/
            //transform.Translate(Vector3.forward * vMove);
            characterController.Move(transform.TransformDirection(Vector3.forward * vMove));
            
        }
        else
        {
            GetComponent<Animation>().Play("ShieldWarrior@Idle01");
        }
    }
}
