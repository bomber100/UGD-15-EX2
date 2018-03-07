using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{

    Material m_Material;

    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = Color.magenta;
    }

}