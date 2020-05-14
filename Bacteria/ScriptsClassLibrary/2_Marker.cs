using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScriptsClassLibrary
{
    public class Marker
    {
        public static Random Rand = new Random();
        public static void MethodMarker()
        {
            for (int i = 0; i < Math.Round(1.0 * VariableMover.CrushinСounter / 1.549268293, 0); i++)
            {
                for (int j = 0; j < VariableMover.CrushinСounter; j++)
                {
                    Border Person = new Border
                    {
                        Background = new SolidColorBrush(Color.FromArgb((byte)Rand.Next(255), (byte)Rand.Next(150), (byte)Rand.Next(150), (byte)Rand.Next(150))),
                        //Background = (Brush)new BrushConverter().ConvertFrom("#FF474747"),
                        //Margin = new Thickness(1)
                    };
                    Grid.SetColumn(Person, j);
                    Grid.SetRow(Person, i);

                    VariableMover.CenterScrin_GridNull.Children.Add(Person);
                }
            }
        }
    }
}
