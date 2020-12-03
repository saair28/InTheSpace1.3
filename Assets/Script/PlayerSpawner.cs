using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    public GameObject my_Nivel1;
    LevelManager my_Nivel1_script;
    public bool niveltrue;
    // Start is called before the first frame update
    void Start()
    {
        my_Nivel1_script = my_Nivel1.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (niveltrue == true)
        {
            PlayerSpawn();
        }
        else
        {
            //Destroy(Nivel1);
        }
    }
    public void PlayerSpawn()
    {
        Instantiate(Player, transform.position, transform.rotation);
        niveltrue = false;
    }
}
