using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   float _baseSpeed = 5.0f;
   float _gravidade = 4f;

   //Referência usada para a câmera filha do jogador
   GameObject playerCamera;
   //Utilizada para poder travar a rotação no angulo que quisermos.
   float cameraRotation;

   CharacterController characterController;

    public float jumpForce = 30.0f;

    GameManager gm;


   void Start()
   {
       characterController = GetComponent<CharacterController>();
       playerCamera = GameObject.Find("Main Camera");
       cameraRotation = 0.0f;
       gm = GameManager.GetInstance();
   }

   void Update()
   {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");
       
       
       //Verificando se é preciso aplicar a gravidade
       float y = 0;
       if(!characterController.isGrounded){
           y = -_gravidade;
       }else{
            if(Input.GetAxisRaw("Jump") != 0)
            {
                // Debug.Log("Jump");
                y = Mathf.Sqrt(jumpForce);
            }
       }
       
       
        //Tratando movimentação do mouse
       float mouse_dX = Input.GetAxis("Mouse X");
       float mouse_dY = Input.GetAxis("Mouse Y");
       
        Vector3 direction = transform.right * x + transform.up * y + transform.forward * z;


        //Tratando a rotação da câmera
       cameraRotation += mouse_dY;
       Mathf.Clamp(cameraRotation, -75.0f, 75.0f);
       
       characterController.Move(direction * _baseSpeed * Time.deltaTime);
    
       transform.Rotate(Vector3.up, mouse_dX);


       playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);

       if(Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME){
        //    Debug.Log("PAUSE");
            gm.ChangeState(GameManager.GameState.PAUSE);
        }

   }

   
void LateUpdate()

{
  RaycastHit hit;
  Debug.DrawRay(playerCamera.transform.position, transform.forward*10.0f, Color.magenta);
  if(Physics.Raycast(playerCamera.transform.position, transform.forward, out hit, 100.0f))
  {
    //  Debug.Log(hit.collider.name);
   }
}
}