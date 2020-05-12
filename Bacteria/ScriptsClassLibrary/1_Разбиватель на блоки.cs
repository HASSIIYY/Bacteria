using System;
using ScriptsClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace ScriptsClassLibrary
{
    public class DivideIntoBlocks
    {
        public static double CountSht;
        public static void MethodDivideIntoBlocks(int count)
        {
            CountSht = Math.Round((double)1043 * count / 1606, 0);
            for (int j = 0; j < CountSht; j++)
            {
                VariableMover.CenterScrin_GridNull.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (int j = 0; j < count; j++)
            {
                VariableMover.CenterScrin_GridNull.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }
        }
    }
}
