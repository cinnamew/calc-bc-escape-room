using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] Image m_icon;
    [SerializeField] TMP_Text m_stackLabel;
    
    public void Set(InventoryItem item) {
        m_icon.sprite = item.data.icon;
        if(item.stackSize <= 1 && m_stackLabel != null) {
            m_stackLabel.enabled = false;
        }else {
            m_stackLabel.enabled = true;
            m_stackLabel.text = item.stackSize.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //m_stackLabel = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
