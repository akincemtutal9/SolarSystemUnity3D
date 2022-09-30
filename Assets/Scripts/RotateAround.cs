using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private Transform targetPlanet;

    [SerializeField] private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if(targetPlanet == null) { return; }
    }

    // Update is called once per frame
    void Update()
    {
        RotateAroundPlanet();
    }
    private void RotateAroundPlanet()
    {
        transform.RotateAround(targetPlanet.transform.position, targetPlanet.transform.up, rotationSpeed * Time.deltaTime);

    }

}
