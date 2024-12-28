using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeingCarController : MonoBehaviour
{
    [SerializeField] private GameObject[] _car;
    [SerializeField] private float _speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * _speed);
    }
}
