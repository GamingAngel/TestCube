using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInput : MonoBehaviour
{
   [SerializeField] private TMP_InputField inputText;


   [SerializeField] private Spawner cubeSpawner;




    public void SetSpeed()
    {
      float.TryParse(inputText.text, out cubeSpawner.cubeSpeed);

        if (cubeSpawner.cubeSpeed <= 0)
        {
            cubeSpawner.cubeSpeed = 1;
        }
        else if (cubeSpawner.cubeSpeed > 100)
        {
            cubeSpawner.cubeSpeed = 100;
        }
        inputText.text = cubeSpawner.cubeSpeed.ToString();
    }

    public void SetSpawnTime()
    {
        float.TryParse(inputText.text, out cubeSpawner.repeatSpawn);

        if (cubeSpawner.repeatSpawn <= 0)
        {
            cubeSpawner.repeatSpawn = 1;
        }
        else if (cubeSpawner.repeatSpawn > 10)
        {
            cubeSpawner.repeatSpawn = 10;
        }
        inputText.text = cubeSpawner.repeatSpawn.ToString();
    }

    public void SetRange()
    {
        float.TryParse(inputText.text, out cubeSpawner.cubeRange);

        if (cubeSpawner.cubeRange <= 0)
        {
            cubeSpawner.cubeRange = 1;
        }
        else if (cubeSpawner.cubeRange > 100)
        {
            cubeSpawner.cubeRange = 100;
        }
        inputText.text = cubeSpawner.cubeRange.ToString();
    }


}
