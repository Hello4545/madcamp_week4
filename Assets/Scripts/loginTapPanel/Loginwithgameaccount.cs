using UnityEngine;

public class Loginwithgameaccount : MonoBehaviour
{
    public GameObject gameAccountLoginPanel; // ���� ���� �α��� �г�
    public GameObject loginTabPanel; // �α��� �� �г�

    // "���� �������� �α���" ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnGameAccountLoginButtonClick()
    {
        gameAccountLoginPanel.SetActive(true); // ���� ���� �α��� �г� Ȱ��ȭ
        loginTabPanel.SetActive(false); // �α��� �� �г� ��Ȱ��ȭ
    }
}
