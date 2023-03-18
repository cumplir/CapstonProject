using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionBtns : MonoBehaviour
{
    public GameObject OptionPannel;
    public GameObject QuestPannel;
    public GameObject InventoryPannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickOption()
    {
        OptionPannel.gameObject.SetActive(true);
    }
    public void CloseOption()
    {
        OptionPannel.gameObject.SetActive(false);
    }

    public void OnclickQuest()
    {
        QuestPannel.gameObject.SetActive(true);
    }
    public void CloseQuest()
    {
        QuestPannel.gameObject.SetActive(false);
    }

    public void OnclickInventory()
    {
        InventoryPannel.gameObject.SetActive(true);
    }
    public void CloseInventory()
    {
        InventoryPannel.gameObject.SetActive(false);
    }
}
