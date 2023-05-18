using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] Image m_icon;
    //[SerializeField] TextMeshPro m_stackLabel;
    
    public void Set(InventoryItem item) {
        m_icon.sprite = item.data.icon;
        if(item.stackSize <= 1) {
            //m_stackLabel.SetActive(false);
            return;
        }

        //m_stackLabel.text = item.stackSize.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
