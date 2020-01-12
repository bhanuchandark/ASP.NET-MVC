using System;
using System.Collections;
using ShopCart;

namespace ShopCart
{

public class Item1
{
        private string _itemCode = string.Empty;
        private string _itemName = string.Empty;
        private float _itemCost = -1;

        public string ItemCode
        {
                get
                {
                        return _itemCode;
                }
                set
                {
                        _itemCode = value;
                }
        }

        public string ItemName
        {
                get
                {
                        return _itemName;
                }
                set
                {
                        _itemName = value;
                }                         
        }

        public float ItemCost
        {
                get
                {
                        return _itemCost;
                }
                set
                {
                        _itemCost = value;
                }
        }
}

public class ItemCol : CollectionBase
{
        public int Add(Item it)
        {
                return List.Add(it);
        }

        public void Insert(int index, Item it)
        {
                List.Insert(index,it);
        }

        public void Remove(Item it)
        {
                List.Remove(it);
        }

        public bool Contains(Item it)
        {
                return List.Contains(it);
        }

        public int IndexOf(Item it)
        {
                return List.IndexOf(it);
        }

        public void CopyTo(Item[] array, int index)
        {
                List.CopyTo(array, index);
        }

        public Item this[int index]
        {
                get
                {
                        return (Item) List[index];
                }
                set
                {
                        List[index] = value;
                }
        }

}
}
