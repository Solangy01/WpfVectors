using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Vectors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Vector3D vector1;
        Vector3D vector2;
        Vector3D vector3;


        // Генерация первых двух векторов - первые два вектора везде используются
        void GenerateVectors()
        {
            vector1 = Vector3D.Parse(Tb_Vec1.Text);
            vector2 = Vector3D.Parse(Tb_Vec2.Text);
        }


        // Обработчики событий нажатия на кнопки


        private void Btn_Sum_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            Tb_Res.Text = (vector1 + vector2).ToString();
        }

        private void Btn_Dif_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            Tb_Res.Text = (vector1 - vector2).ToString();
        }

        private void Btn_Scalar_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            Tb_Res.Text = (vector1 & vector2).ToString();
        }

        private void Btn_Vec_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            Tb_Res.Text = (vector1 * vector2).ToString();
        }

        private void Btn_Mix_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            vector3 = Vector3D.Parse(Tb_Vec3.Text);
            Tb_Res.Text = vector1.MixProd(vector2, vector3).ToString();
        }

        private void Btn_Angle_Click(object sender, RoutedEventArgs e)
        {
            GenerateVectors();
            Tb_Res.Text = vector1.Angle(vector2).ToString();
        }
    }
}
