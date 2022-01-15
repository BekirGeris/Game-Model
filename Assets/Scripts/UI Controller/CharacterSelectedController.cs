using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Snake.UIController;
using Snake.Toast;

public class CharacterSelectedController : MonoBehaviour
{

    [SerializeField] private GamePanelController gamePanelController;
    [SerializeField] private ShowToast showToast;

    [SerializeField] private List<GameObject> chactarImages;
    [SerializeField] private List<TextMeshProUGUI> buys;
    [SerializeField] private GameObject selectedEffect;

    private int selectedImageNoForSale;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 1; i <= 10; i++)
        {
            if(i == PlayerPrefs.GetInt(i.ToString(), -1))
            {
                buys[i - 1].text = "Purchased";
            }
            if(i == PlayerPrefs.GetInt("selectImage", -1))
            {
                selectedEffect.transform.position = chactarImages[i - 1].transform.position;
            }
        }

    }

    public void selectImage(int imageNo)
    {
        for (var i = 1; i <= 10; i++)
        {
            if (imageNo == PlayerPrefs.GetInt(i.ToString(), -1))
            {
                PlayerPrefs.SetInt("selectImage", imageNo);
                Start();
                return;
            }
        }
        selectedImageNoForSale = imageNo;
        gamePanelController.openBuyingPanel();
    }

    public void buying()
    {
        PlayerPrefs.SetInt(selectedImageNoForSale.ToString(), selectedImageNoForSale);
        PlayerPrefs.SetInt("selectImage", selectedImageNoForSale);
        Start();
    }
}
