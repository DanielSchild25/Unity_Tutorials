using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool canShoot = true;
    public float coolDown = 2.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            canShoot = false;

            Invoke("CooledDown", coolDown);
        }
    }

    void CooledDown()
    {
        canShoot = true;
    }
}
