using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPlanet : MonoBehaviour
{
    [SerializeField] private Transform targetPlanet;

    [SerializeField] private float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        RotateAroundPlanetObject();
    }
    private void RotateAroundPlanetObject()
    {
        transform.RotateAround(targetPlanet.transform.position, targetPlanet.transform.up, rotationSpeed * Time.deltaTime);

    }

}
