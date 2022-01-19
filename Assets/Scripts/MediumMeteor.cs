using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumMeteor : MonoBehaviour
{
    public GameObject MeteorPrefab;
    public float respawnTime = 15.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(MeteorWave());
    }
    private void spawnMeteor()
    {
        GameObject a = Instantiate(MeteorPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator MeteorWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnMeteor();
        }
    }
}
