using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // ����- ��� ��Ģ
    // ���,Ŭ����,�Լ��� Ȯ�忡 ���� �����־���ϰ� ������ ���ؼ��� ���� �־�� �Ѵ�.

    // Ȯ�忡 ���� ���� �ִ�?
    // ���� �䱸 ������ ����� �� ���濡 �°�
    // ���ο� ������ �߰��Ͽ� ����� Ȯ���� �� �־�� �Ѵ�.

    // ������ ���� ���� �ִ�?
    // ����� �ڵ带 �������� �ʾƵ� ����� Ȯ���ϰų� ������ �� �־�� �Ѵ�.

    public abstract class Item
    {
        public abstract void Effect();
    }

    public class WaterRocket : Item
    {
        public override void Effect()
        {
            Debug.Log("������ �߻�!");
        }
    }

    public class Shield : Item
    {
        public override void Effect()
        {
            Debug.Log("����!");
        }
    }

    public class Magnet : Item
    {
        public override void Effect()
        {
            Debug.Log("Ư���� �÷��̾ ���󰩴ϴ�.");
        }
    }

    private void TriggerItem(Item item)
    {
        item.Effect();
    }

    private void Start()
    {
        WaterRocket waterRocket = new WaterRocket();
        TriggerItem(waterRocket);

        Magnet magnet = new Magnet();
        TriggerItem(magnet);
    }
}
