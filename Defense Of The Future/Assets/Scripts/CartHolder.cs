using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartHolder : MonoBehaviour
{
    [Header("Card Holder Parameters")]
    [SerializeField] private Transform _cardHolderPosition;
    [SerializeField] private GameObject _card;
    [SerializeField] private Card[] _cardSO;
    private int _cardsAmount;

    [Header("Card Parameters")]
    [SerializeField] private GameObject[] _plantedCards;
    private int _cost;
    private Sprite _icon;

    private void Start()
    {
        _cardsAmount = _cardSO.Length;
        _plantedCards = new GameObject[_cardsAmount];

        for (int i = 0; i < _cardsAmount; i++)
        {
            CreateCard(i);
        }
    }

    private void CreateCard(int i)
    {
        var card = Instantiate(_card, _cardHolderPosition);

        _plantedCards[i] = card;

        _icon = _cardSO[i].icon;
        _cost = _cardSO[i].cost;

        card.GetComponentInChildren<SpriteRenderer>().sprite = _icon;
        card.GetComponentInChildren<TMP_Text>().text = _cost.ToString();
    }
}
