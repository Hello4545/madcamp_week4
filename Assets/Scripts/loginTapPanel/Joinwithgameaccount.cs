using UnityEngine;

public class Joinwithgameaccount : MonoBehaviour
{
    public GameObject joinPanel; // ���� ���� �α��� �г�
    public GameObject loginTabPanel; // �α��� �� �г�

    // "ȸ������" ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnJoinButtonClick()
    {
        joinPanel.SetActive(true); // ���� ���� �α��� �г� Ȱ��ȭ
        loginTabPanel.SetActive(false); // �α��� �� �г� ��Ȱ��ȭ
    }
}


