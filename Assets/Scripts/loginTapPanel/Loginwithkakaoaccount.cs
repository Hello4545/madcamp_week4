using UnityEngine;

public class Loginwithkakaoaccount : MonoBehaviour
{
    public GameObject kakaoAccountLoginPanel; // ���� ���� �α��� �г�
    public GameObject loginTabPanel; // �α��� �� �г�

    // "īī�� �������� �α���" ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnKakaoAccountLoginButtonClick()
    {
        kakaoAccountLoginPanel.SetActive(true); // ���� ���� �α��� �г� Ȱ��ȭ
        loginTabPanel.SetActive(false); // �α��� �� �г� ��Ȱ��ȭ
    }
}

