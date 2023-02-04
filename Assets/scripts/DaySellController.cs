using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaySellController : MonoBehaviour
{
    [SerializeField]
    Sprite[] buttomimages;
    DoneState _thisstate = DoneState.none;
    Image _buttonImage;

    int _imageIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        _buttonImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_thisstate)
        {
            case DoneState.Questions:
                break;
            case DoneState.Csrank:
                break;
            case DoneState.Drank:
                break;
            case DoneState.none:
                break;

        }

    }

    public void CollorChange()
    {
        _imageIndex++;
        _buttonImage.sprite = buttomimages[_imageIndex % buttomimages.Length];
    }

}
