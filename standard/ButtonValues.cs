using CalcLib.Engine;
using CalcLib.Types;

namespace BasicCalc.standard
{
    public class ButtonValues : IButtonValues
    {
        private readonly Item[,] _buttonItems = new Item[,] { };

        public ButtonValues()
        {
            Item _nnnn = NoneItem.CreateItem();

            Item Clear = Item.CreateItem("C", Methods.Clear());
            Item Calc = Item.CreateItem("=", Methods.Result());

            Item Add = Item.CreateItem("+", Methods.Add());
            Item Minus = Item.CreateItem("-", Methods.Minus());


            Item Num0 = Item.CreateItem("0", 0);
            Item Num1 = Item.CreateItem("1", 1);
            Item Num2 = Item.CreateItem("2", 2);
            Item Num4 = Item.CreateItem("4", 4);
            Item Num7 = Item.CreateItem("7", 7);


            _buttonItems = new Item[,]
            {
                { _nnnn, Clear, _nnnn },
                { Num4, Num7, Minus },
                { Num1, Num2, Add },
                { _nnnn, Num0,Calc },
            };

            GetLengthY = _buttonItems.GetUpperBound(0);
            GetLengthX = _buttonItems.GetUpperBound(1);
            GetX = GetLengthX + 1;
        }

        public int GetLengthY { get; }

        public int GetLengthX { get; set; }

        public int GetX { get; }

        public Item GetItem(int y, int x)
        {
            return (Item)_buttonItems.GetValue(y, x);
        }
    }
}