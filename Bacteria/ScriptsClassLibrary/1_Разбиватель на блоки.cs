using System;
using System.Windows.Controls;
using System.Windows;

namespace ScriptsClassLibrary
{
    public class DivideIntoBlocks
    {
        public static double Count;
        public static double CountSht;
        public static void MethodDivideIntoBlocks(int count)
        {
            int i; int j;

            Count = count;
            CountSht = Math.Round(1.0 * count / 1.549268293, 0);
            for (i = 0; i < CountSht; i++)
            {
                VariableMover.CenterScrin_GridNull.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (j = 0; j < count; j++)
            {
                VariableMover.CenterScrin_GridNull.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }
        }
    }
}
