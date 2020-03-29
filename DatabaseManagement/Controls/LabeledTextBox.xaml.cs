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

namespace DatabaseManagement.Controls
{
    /// <summary>
    /// Interaction logic for LabeledTextBox.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(LabeledTextBox), new FrameworkPropertyMetadata(null));
        public string Text
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty LabelTextProperty = DependencyProperty.Register(nameof(LabelText), typeof(string), typeof(LabeledTextBox), new FrameworkPropertyMetadata(null));
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly DependencyProperty LabelWidthProperty = DependencyProperty.Register(nameof(LabelWidth), typeof(int), typeof(LabeledTextBox), new FrameworkPropertyMetadata(null));
        public int LabelWidth
        {
            get { return (int)GetValue(LabelWidthProperty); }
            set { SetValue(LabelWidthProperty, value); }
        }

        public static readonly DependencyProperty TextBoxWidthProperty = DependencyProperty.Register(nameof(TextBoxWidth), typeof(int), typeof(LabeledTextBox), new FrameworkPropertyMetadata(null));
        public int TextBoxWidth
        {
            get { return (int)GetValue(TextBoxWidthProperty); }
            set { SetValue(TextBoxWidthProperty, value); }
        }

        public static readonly DependencyProperty ControlHeightProperty = DependencyProperty.Register(nameof(ControlHeight), typeof(int), typeof(LabeledTextBox), new FrameworkPropertyMetadata(null));
        public int ControlHeight
        {
            get { return (int)GetValue(ControlHeightProperty); }
            set { SetValue(ControlHeightProperty, value); }
        }

        public LabeledTextBox()
        {
            InitializeComponent();
        }
    }
}
