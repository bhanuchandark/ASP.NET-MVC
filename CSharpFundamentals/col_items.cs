using System;
using System.Collections;

namespace ShopCart
{
public class Item
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
}
