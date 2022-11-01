using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;

    public float cubeSpeed;
    public float repeatSpawn;
    public float cubeRange;

    private float lastSpawnTime;


    private void FixedUpdate()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        if(Time.time >= lastSpawnTime + repeatSpawn)
        {
            GameObject _cube = Instantiate(spawnObject,transform.position,transform.rotation);

            var _cubeStats = _cube.GetComponent<Move>();
            _cubeStats.moveSpeed = cubeSpeed;
            _cubeStats.deathRange = cubeRange;

            lastSpawnTime = Time.time;
        }

    }
}
