using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideButtons : MonoBehaviour
{
    private Button btn;
    [SerializeField] bool goRight = true;
    

    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(ChangeWall);
    }

    void ChangeWall() {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
