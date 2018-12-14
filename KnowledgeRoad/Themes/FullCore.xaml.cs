using KnowledgeRoad.Models;
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

namespace KnowledgeRoad
{
    /// <summary>
    /// FullCore.xaml 的交互逻辑
    /// </summary>
    public partial class FullCore : UserControl
    {
        public FullCore()
        {
            InitializeComponent();
        }

        //充实块的ID
        public int Id { get; set; }

        //充实块的样式Style
        private StyleClass styleType;

        public StyleClass StyleType
        {
            get { return styleType; }
            set { styleType = value; }
        }


        //当前充实块的充实值
        private double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
