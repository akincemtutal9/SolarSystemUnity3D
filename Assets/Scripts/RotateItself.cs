using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItself : MonoBehaviour
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
        RotateAroundItself();
    }
    private void RotateAroundItself()
    {
        transform.RotateAround(selfTransform.transform.position, selfTransform.transform.up, selfRotationSpeed * Time.deltaTime); ;

    }
}
