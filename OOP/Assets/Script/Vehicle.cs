using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicleCar
{
    //�����ϴ� ���
    public void Parking();
    
    // �ڵ��� �����ϴ� ���
    public void ControlHandle();
}

public interface IVehicleHorse
{
    // ���� �Դ� ���
    public void EatFood();
    // �ڵ��� �����ϴ� ���
    public void ControlHandle();
}

public interface IVehicleKickBoard
{
    //�۸� ��� ���
    public void LockHelmet();

    // �ڵ��� �����ϴ� ���
    public void ControlHandle();
}

//4. �������� ���� ��Ģ
// �������踦 ������ �ڽź��� ��ȭ�ϱ� ����ͺ��ٴ� 
// ��ȭ�����ʴ°Ϳ� �����ؾ��մϴ�.

//��ȭ�����ʴ°��̶�?
// ��å �Ǵ� ���� ���� �帧�� �߻����� �����̸�, �߻� Ŭ������
// �������̽��� ǥ���� ���ֽ��ϴ�.

//��ȭ�ϱ⽬����̶�?
//���� ���� �Ǵ� ������Ʈ�� ���� ��ü���� ���̸�, 
// ��ü���� Ŭ������ ǥ���� �� �ִ� ���Դϴ�.


//5. �������� ġȯ�� ��Ģ
// ���α׷����� �ڷ��� S�� T�� �������̶�� ���α׷��� 
// �����ϴ� ������ ������� T�� ��ü�� S����ü�� ��ü�ص�
// ���α׷��� ���������� �����ؾ� �մϴ�.

public class Vehicle : MonoBehaviour
{
    // �������̽� �и� ��Ģ
    // Ŭ���̾�Ʈ�� �ڽ��� ������� �ʴ� 
    // �Լ��� ���� ������ ���� �ʾƾ� �Ѵ�.

    // �߻����� �������̽��� ��ü���̰� ���� ������
    // ������ �������̽��� �и����� Ŭ���̾�Ʈ�� �� �ʿ���
    // �Լ��� �̿��� �� �ֵ��� �����ؾ� �մϴ�.

    class Horse : IVehicleHorse
    {
        public void ControlHandle()
        {
            Debug.Log("���� �����Ѵ�");
        }

        public void EatFood()
        {
            Debug.Log("����� �Դ´�");
        }
    }

    class Car : IVehicleCar
    {
        public void ControlHandle()
        {
            Debug.Log("�ڵ��� �����Ѵ�");
        }

        public void Parking()
        {
            Debug.Log("�����Ѵ�");
        }
    }

    class Kickboard : IVehicleCar ,IVehicleKickBoard
    {
        public void ControlHandle()
        {
            Debug.Log("�ڵ��� �����Ѵ�.");
        }

        public void LockHelmet()
        {
            Debug.Log("�۸��� ����Ѵ�.");
        }

        public void Parking()
        {
            Debug.Log("�����Ѵ�.");
        }
    }

}
