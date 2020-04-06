using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectbase.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoundedImage : ContentView
    {
        public RoundedImage()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(ImageSource), typeof(RoundedImage), null, propertyChanged: (bindable, oldValue, newvalue) =>
        {
            if (newvalue is ImageSource image && bindable is RoundedImage)
            {
                ((RoundedImage)bindable).image.Source = (ImageSource)newvalue;
            }
        });
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }
        public static readonly BindableProperty SizeProperty = BindableProperty.Create(nameof(Size), typeof(double), typeof(RoundedImage), null, propertyChanged: (bindable, oldValue, newvalue) =>
        {
            if (newvalue != null && bindable is RoundedImage)
            {
                ((RoundedImage)bindable).roundedFrame.WidthRequest = (double)newvalue;
                ((RoundedImage)bindable).roundedFrame.HeightRequest = (double)newvalue;
                ((RoundedImage)bindable).roundedFrame.CornerRadius = (float)((double)newvalue / 2);
            }
        });
    }
}