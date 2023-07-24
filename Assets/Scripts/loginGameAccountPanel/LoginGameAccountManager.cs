using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System.Collections;

public class LoginGameAccountManager : MonoBehaviour
{
    public TMP_InputField gameIDInput; // ���� ID �Է� �ʵ�
    public TMP_InputField passwordInput; // ��й�ȣ �Է� �ʵ�

    public GameObject homePanel; // Ȩ �� �г�
    public GameObject loginGameAccountPanel; // �α��� �г�

    // �α��� ��ư Ŭ�� �� ����Ǵ� �Լ�
    public void OnLoginButtonClick()
    {
        string gameID = gameIDInput.text; // ���� ID ��������
        string password = passwordInput.text; // ��й�ȣ ��������

        WWWForm form = new WWWForm();
        form.AddField("userId", gameID);
        form.AddField("password", password);

        string url = "http://172.10.5.141:80/user/checkAccount";

        UnityWebRequest www = UnityWebRequest.Post(url, form);

        StartCoroutine(SendJoinRequest(www));
    }

    // �α��� ��û ������ �ڷ�ƾ �Լ�
    private IEnumerator SendJoinRequest(UnityWebRequest www)
    {
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            // ���� ó��
            Debug.LogError(www.error);
        }
        else
        {
            // �α��� ���� ��, Ȩ ȭ������ ��ȯ
            // TODO: Ȩ ȭ������ ��ȯ�ϴ� �ڵ� �߰�
            PlayerPrefs.SetString("userId", gameIDInput.text); //Playerprefs �̿��ؼ� userId �� ��ü���� ������Ŵ.
            homePanel.SetActive(true); // Ȩ �г� Ȱ��ȭ
            loginGameAccountPanel.SetActive(false); // �α��� �г� ��Ȱ��ȭ
            Debug.Log("�α��� ����");
        }
    }
}
