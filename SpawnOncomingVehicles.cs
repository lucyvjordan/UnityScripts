using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOncomingVehicles : MonoBehaviour
{
    
    [SerializeField] private GameObject vehicleObject;
    private Vector3 spawnLocation = new Vector3(0f, 1f, 150f);

    void Start()
    {
        InvokeRepeating("SpawnVehicle", 0, 6);
        // the function 'SpawnVehicle' will be repeated every 6 seconds, starting from 0 seconds after running
    }

    void SpawnVehicle()
    {
        Instantiate(vehicleObject, spawnLocation, Quaternion.Euler(0, 180, 0), transform);
        // An instance of the vehicleObject prefect will spawn at the spawnLocation defined, rotated 180 degrees around the Y-axis and with the current transform object this script is in as the parent
    }
}