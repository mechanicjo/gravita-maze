using UnityEngine;
using UnityEngine.UI;   // UI�� ���õ� ��ũ��Ʈ �۾��� ���ؼ� �߰��� �־�� �Ѵ�.
using System.Collections;

public class DropdownSize : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject fillImage;
    
    void Start()
    {
        if(dropdown.options.Count > 2)
        {
            fillImage.SetActive(false);
        }
        else
        {
            fillImage.SetActive(true);
        }

    }

}
