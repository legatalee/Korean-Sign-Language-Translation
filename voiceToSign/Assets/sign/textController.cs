using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class textController : MonoBehaviour
{
    TextMeshProUGUI text;
    Dictionary<KeyCode, string> mapAlphabetical = new Dictionary<KeyCode, string>
    {
        { KeyCode.R, "��" },
        { KeyCode.S, "��" },
        { KeyCode.E, "��" },
        { KeyCode.F, "��" },
        { KeyCode.A, "��" },
        { KeyCode.Q, "��" },
        { KeyCode.T, "��" },
        { KeyCode.D, "��" },
        { KeyCode.W, "��" },
        { KeyCode.C, "��" },
        { KeyCode.Z, "��" },
        { KeyCode.X, "��" },
        { KeyCode.V, "��" },
        { KeyCode.G, "��" },
        { KeyCode.K, "��" },
        { KeyCode.I, "��" },
        { KeyCode.J, "��" },
        { KeyCode.U, "��" },
        { KeyCode.H, "��" },
        { KeyCode.Y, "��" },
        { KeyCode.N, "��" },
        { KeyCode.B, "��" },
        { KeyCode.M, "��" },
        { KeyCode.L, "��" },
        { KeyCode.O, "��" },
        { KeyCode.P, "��" },
    };

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        /*
        foreach (var (key, word) in mapAlphabetical)
        {
            if (Input.GetKeyDown(key))
            {
                text.text = word;
            }
        }
        */
    }
}
