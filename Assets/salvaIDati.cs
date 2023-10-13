using UnityEngine;
using UnityEngine.UI;

public class salvaIDati : MonoBehaviour
{
    public string giorno;
    public InputField[] campiDiTesto;
    InputField c;
    void Awake()
    {
        if (PlayerPrefs.HasKey(giorno + campiDiTesto[0].name))
        {
            campiDiTesto[0].text = PlayerPrefs.GetString(giorno + campiDiTesto[0].name);
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[0].name);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[1].name))
        {
            campiDiTesto[1].text = PlayerPrefs.GetString(giorno + campiDiTesto[1].name);
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[1].name);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[2].name))
        {
            campiDiTesto[2].text = PlayerPrefs.GetString(giorno + campiDiTesto[2].name);
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[2].name);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[3].name))
        {
            campiDiTesto[3].text = PlayerPrefs.GetString(giorno + campiDiTesto[3].name);
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[3].name);
        }
    }

    public void Salva()
    {
        if (PlayerPrefs.HasKey(giorno + campiDiTesto[0].name))
        {
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[0].name);
            PlayerPrefs.SetString(giorno + campiDiTesto[0].name, campiDiTesto[0].text);
        }
        else
        {
            PlayerPrefs.SetString(giorno + campiDiTesto[0].name, campiDiTesto[0].text);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[1].name))
        {
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[1].name);
            PlayerPrefs.SetString(giorno + campiDiTesto[1].name, campiDiTesto[1].text);
        }
        else
        {
            PlayerPrefs.SetString(giorno + campiDiTesto[1].name, campiDiTesto[1].text);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[2].name))
        {
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[2].name);
            PlayerPrefs.SetString(giorno + campiDiTesto[2].name, campiDiTesto[2].text);
        }
        else
        {
            PlayerPrefs.SetString(giorno + campiDiTesto[2].name, campiDiTesto[2].text);
        }

        if (PlayerPrefs.HasKey(giorno + campiDiTesto[3].name))
        {
            PlayerPrefs.DeleteKey(giorno + campiDiTesto[3].name);
            PlayerPrefs.SetString(giorno + campiDiTesto[3].name, campiDiTesto[3].text);
        }
        else
        {
            PlayerPrefs.SetString(giorno + campiDiTesto[3].name, campiDiTesto[3].text);
        }
        
        PlayerPrefs.Save();
    }

    void OnApplicationQuit()
    {
        Salva();
    }

    private void OnApplicationPause(bool pause)
    {
        Salva();
    }
}
