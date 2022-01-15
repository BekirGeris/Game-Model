using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectedController : MonoBehaviour
{
    [SerializeField] private GameObject selectedEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectImage(Transform selectedImageTransform)
    {
        selectedEffect.transform.position = selectedImageTransform.position;
    }
}
