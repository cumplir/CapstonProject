using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject CharacterPannel;
    public GameObject ItemPannel;
    public GameObject furniturePannel;
    // Start is called before the first frame update
    public void OnclickItem()
    {
        ItemPannel.gameObject.SetActive(true);
        CharacterPannel.gameObject.SetActive(false);
        furniturePannel.gameObject.SetActive(false);
    }
    public void OnclickCharacter()
    {
        ItemPannel.gameObject.SetActive(false);
        CharacterPannel.gameObject.SetActive(true);
        furniturePannel.gameObject.SetActive(false);
    }
    public void Onclickfurniture()
    {
        ItemPannel.gameObject.SetActive(false);
        CharacterPannel.gameObject.SetActive(false);
        furniturePannel.gameObject.SetActive(true);
    }
}
