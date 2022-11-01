using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Initialization : MonoBehaviour
{

    [SerializeField] private Spawner cubeSpawner;

    [SerializeField] private TMP_InputField speedText;
    [SerializeField] private TMP_InputField repeatSpawnText;
    [SerializeField] private TMP_InputField rangeText;


    private void Awake()
    {
        SetBasicStats();
    }

    public void SetBasicStats()
    {

        float.TryParse(speedText.text, out cubeSpawner.cubeSpeed);
        float.TryParse(repeatSpawnText.text, out cubeSpawner.repeatSpawn);
        float.TryParse(rangeText.text, out cubeSpawner.cubeRange);

    }

}
