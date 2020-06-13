using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScriptsClassLibrary
{
    public class Marker
    {
        public static int[] Bord = new int[100];
        public static Random Rand = new Random();
        public static void MethodFullMarker() // ЗАПОЛНЯЕТ ВСЕ КЛЕТКИ
        {
            for (int i = 0; i < Math.Round(VariableMover.CrushinСounter / 1.549268293, 0); i++)
            {
                for (int j = 0; j < VariableMover.CrushinСounter; j++)
                {
                    Border Person = new Border
                    {
                        //Background = new SolidColorBrush(Color.FromArgb((byte)Rand.Next(255), (byte)Rand.Next(150), (byte)Rand.Next(150), (byte)Rand.Next(150))),
                        Background = (Brush)new BrushConverter().ConvertFrom("#FF474747"),
                        Margin = new Thickness(1)
                    };
                    Grid.SetColumn(Person, j);
                    Grid.SetRow(Person, i);

                    VariableMover.CenterScrin_GridNull.Children.Add(Person);
                }
            }
        }

        public static void MethodRandomMarker() // ЗАПОЛНЯЕТ СЛУЧАЙНЫЕ КЛЕТКИ
        {
            for (int i = 0; i < length; i++)
            {

            }
            for (int i = 0; i < 50; i++)
            {
                Border Person = new Border
                {
                    Background = (Brush)new BrushConverter().ConvertFrom("#FF474747"),
                    Margin = new Thickness(1)
                };
                Grid.SetColumn(Person, Rand.Next(VariableMover.CrushinСounter));
                Grid.SetRow(Person, Rand.Next((int)Math.Round(VariableMover.CrushinСounter / 1.549268293, 0)));
                Bord[i] = 

                VariableMover.CenterScrin_GridNull.Children.Add(Person);
            }
        }
    }
}
