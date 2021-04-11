using System.Collections;
using UnityEngine;
using TMPro;

public class RNG : MonoBehaviour
{
    public TextMeshProUGUI text;

    const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789";
    string name;
    string userType = "guest-";


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateRandom");
    }

    IEnumerator GenerateRandom()
    {
        yield return new WaitForEndOfFrame();

        int chars = Random.Range(6, 7);
        for(int i = 0; i <chars; i++)
        {
            text.text = userType += glyphs[Random.Range(0, glyphs.Length)];
        }
    }
}
