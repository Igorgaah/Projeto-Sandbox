using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllrt : MonoBehaviour
{
    private InputActionMap playerActionMap;
    private Vector2 moveInput;

    private void Awake()
    {
        playerActionMap = new InputActionMap();

        //Configurar as ações e callbacks
        playerActionMap.AddAction("Move", binding: "<Keyboard>/wasd");
        playerActionMap.AddAction("Jump", binding: "<Keyboard/space");

        //Vincular os callbacks das ações
        playerActionMap.AddAction["Move"].performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        playerActionMap.AddAction["Jump"].performed += ctx => Jump();

         // Adicione ação "Attack" e vincule o callback
        playerActionMap.AddAction("Attack", binding: "<Keyboard>/f");
        playerActionMap["Attack"].performed += ctx => Attack();

        // Adicione ação "Interact" e vincule o callback
        playerActionMap.AddAction("Interact", binding: "<Keyboard>/g");
        playerActionMap["Interact"].performed += ctx => Interact();
    }

    private void OnEnable()
    {
        playerActionMap.Enable();
    }

    private void OnDisable()
    {
        playerActionMap.Disable();
    }

    private void Attack()
    {
        Debug.Log("Attacking!");
        
    }

    private void Interact()
    {
        Debug.Log("Interacting!");
        
    }

    private void Jump()
    {
        Debug.Log("Jump!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection =  new Vector3(moveInput.x, of, moveInput.y);
        transform.Translate(moveDirection * Time.deltaTime);
    }
}
