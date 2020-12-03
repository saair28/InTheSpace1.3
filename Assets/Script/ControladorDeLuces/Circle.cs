using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{
    [SerializeField] Image circleImg;
    //public GameObject circle_Img;
    //public GameObject circle;
    //public GameObject circleFill;

    public bool desactivaCircle = false;
    //[SerializeField] Text txtProgress;


    [SerializeField] [Range(0, 1)] public float progress = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (progress <= 1)
        { 
            if (Input.GetKey(KeyCode.E))
            {
                progress = progress + 0.001f;
                circleImg.fillAmount = progress;
            
            }
        } else if (progress >= 1)
        {

            desactivaCircle = true;
            
        }



    }
    
    
}
