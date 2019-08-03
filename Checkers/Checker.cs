using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Checker
    {
        public String symbol { get; private set; }
        public Color team { get; private set; }
        public Position position { get; set; }

        public Checker(Color team, int row, int col)
        {
            int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            if (Color.White==team)
            {
                symbol = char.ConvertFromUtf32(openCircleId);
            }
            else
            {
                symbol= char.ConvertFromUtf32(closedCircleId);
            }

            position = new Position(row, col);
        }   

    }
}
