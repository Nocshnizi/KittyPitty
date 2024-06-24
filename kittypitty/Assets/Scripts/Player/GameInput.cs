using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameInput : MonoBehaviour {
    public event EventHandler OnObjectDetection;

    public static GameInput Instance { get; private set; }

    [Header("Movment")]
    [SerializeField] private float jumpPower = 5f;
    public Rigidbody2D rigidbody2D;
    public MovmentVisual movmentVisual;
    public EButtonVisual eButtonVisual;
    public float gravityFalling;

    //private movement
    private float horizontal;
    private float vertical;
    private float speed = 5;
    private Vector2 vecGravity;

    [Header("Layers")]
    public Transform groundChek;
    public Transform wallCheck;
    public LayerMask groundLayer;
    public LayerMask objectLayer;

    [Header("EyesLight")]
    public EyesLight eyesLightCode;


    [Header("Physic Mechanic Features")]
    public SuperMushroom superMushroom;
    public GameObject rockVisual;

    [Header("Input Section")]
    public GameObject EButton;



    private bool IsFacingRight = true;
    private GameInput player;
    private IInteracted iObject;
   
    private void Awake() {
        Instance = this;
        EButton.SetActive(false);
    }

    private void Start() {
        vecGravity = new Vector2(0, -Physics2D.gravity.y);
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate() {
        rigidbody2D.velocity = new Vector2(horizontal * speed, rigidbody2D.velocity.y);

        if (IsFacingRight && horizontal > 0f) {
            Flip();
        }
        else if (!IsFacingRight && horizontal < 0f) {
            Flip();
        }

        movmentVisual.SetAnimation();
       
        AfterJumpFalling();
    }


    public void Move(InputAction.CallbackContext context) {
        horizontal = context.ReadValue<Vector2>().x;

    }
   
    public void Jump(InputAction.CallbackContext context) {
        if(context.performed && IsGrounded()) { 
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }
    }

    public void Intaraction(InputAction.CallbackContext context) {
        if(context.performed) {
            OnObjectDetection?.Invoke(this, EventArgs.Empty);
        }
    }


    public void EyesLight(InputAction.CallbackContext context) {
        if(context.performed) {
            eyesLightCode.IsEyesLightOn();
        }
    }

    public void Meow(InputAction.CallbackContext context) {
        if(context.performed) {
            Instantiate(rockVisual, new Vector2(transform.position.x + 10, transform.position.y +20), transform.rotation);
        }
        
    }

    public bool IsGrounded() {
        return Physics2D.OverlapCircle(groundChek.position, 0.3f, groundLayer);
    }



    private void Flip() {
        IsFacingRight = !IsFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }


    public bool IsWalking() {
        return rigidbody2D.velocity != Vector2.zero;
    }
    
    public void SetSelectedObject(IInteracted iObject) {
        this.iObject = iObject;
    }

    private void AfterJumpFalling() {
        if (!IsGrounded() && rigidbody2D.velocity.y < 0) {
            rigidbody2D.velocity -= vecGravity * gravityFalling * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Interact")) {
            EButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        EButton.SetActive(false);
    }

}

