using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class townHP : MonoBehaviour
{
    public int ddd = 5;
    [SerializeField] private GameObject heartImage;
    [SerializeField] private GameObject heartImage1;
    [SerializeField] private GameObject heartImage2;
    [SerializeField] private GameObject heartImage3;
    [SerializeField] private GameObject heartImage4;
    void Update()
    {
        HeartImage();
    }
    private void HeartImage()
    {
                switch(ddd)
        {
            case 0:
                heartImage.gameObject.SetActive(false);
                heartImage1.gameObject.SetActive(false);
                heartImage2.gameObject.SetActive(false);
                heartImage3.gameObject.SetActive(false);
                heartImage4.gameObject.SetActive(false);
                break;

            case 1:
                heartImage.gameObject.SetActive(true);
                heartImage1.gameObject.SetActive(false);
                heartImage2.gameObject.SetActive(false);
                heartImage3.gameObject.SetActive(false);
                heartImage4.gameObject.SetActive(false);
                break;
            case 2:
                heartImage.gameObject.SetActive(true);
                heartImage1.gameObject.SetActive(true);
                heartImage2.gameObject.SetActive(false);
                heartImage3.gameObject.SetActive(false);
                heartImage4.gameObject.SetActive(false);
                break;
            case 3:
                heartImage.gameObject.SetActive(true);
                heartImage1.gameObject.SetActive(true);
                heartImage2.gameObject.SetActive(true);
                heartImage3.gameObject.SetActive(false);
                heartImage4.gameObject.SetActive(false);
                break;
            case 4:
                heartImage.gameObject.SetActive(true);
                heartImage1.gameObject.SetActive(true);
                heartImage2.gameObject.SetActive(true);
                heartImage3.gameObject.SetActive(true);
                heartImage4.gameObject.SetActive(false);
                break;
            case 5:
                heartImage.gameObject.SetActive(true);
                heartImage1.gameObject.SetActive(true);
                heartImage2.gameObject.SetActive(true);
                heartImage3.gameObject.SetActive(true);
                heartImage4.gameObject.SetActive(true);
                break;
    
            
        }
    
    }


}
