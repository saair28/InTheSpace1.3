using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Message;
    public Transform SpawnerPos;
    public GameObject my_Cables;
    Cables my_Cables_script;
    // Start is called before the first frame update
    void Start()
    {
        my_Cables_script = my_Cables.GetComponent<Cables>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    private void SpawnMessage()
    {
        if (my_Cables_script.message == true)
        {
            GameObject Mes = Instantiate(Message, SpawnerPos.position, Quaternion.identity);
        }
    }
}
