using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    #region Fields and Properties

    [field: SerializeField] public CardScript CardData { get; private set; }

    #endregion


    #region Methods

public void SetPlayable(bool isPlayable)
    {
        if (_cardButton != null)
        {
            _cardButton.interactable = isPlayable;
        }
            Color cardColor = isPlayable ? Color.white : Color.gray;
            GetComponent<Image>().color = cardColor;
            _nameText.color = isPlayable ? Color.black : Color.gray;
            _descriptionText.color = isPlayable ? Color.black : Color.gray;
    }

    public void SetUp(CardScript data)
    {
        CardData = data;
        GetComponent<CardUI>().SetCardImage();
    }

    #endregion
}
