using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _turnTime = 5.0f;


    private float _horizontalInput;
    private float _verticalInput;

    void Start()
    {
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        //forward movement
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _verticalInput);
        //rotating smoothly
        transform.Rotate(Vector3.up, Time.deltaTime * _turnTime * _horizontalInput);

    }





}