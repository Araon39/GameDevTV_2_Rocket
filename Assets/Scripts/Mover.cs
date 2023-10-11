using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float mainThrust = 100f;
    [SerializeField] private float rotateRocket = 10f;
    [SerializeField] private AudioSource _audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveRocket();
        RotateRocket();
    }

    void MoveRocket()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            if (_audioSource.isPlaying == false)
            {
                _audioSource.Play();
            }
        }
        else
        {
            _audioSource.Stop();
        }
    }
    void RotateRocket()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotateRocket);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotateRocket);
        }
    }

    private void ApplyRotation(float rotationRocket)
    {
        rb.freezeRotation = true; //замораживаем вращения
        transform.Rotate(Vector3.forward * rotationRocket * Time.deltaTime);
        rb.freezeRotation = false; //размораживаем
    }
}
