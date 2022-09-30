using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundItself : MonoBehaviour
{
    [SerializeField] private float selfRotationSpeed;
    private Transform selfTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        selfTransform = this.gameObject.transform;    
    }

    // Update is called once per frame
    void Update()
    {
        RotateAroundSelfTransform();
    }
    private void RotateAroundSelfTransform()
    {
        transform.RotateAround(selfTransform.position, selfTransform.up, selfRotationSpeed * Time.deltaTime); ;
    }
}
