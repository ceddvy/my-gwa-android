using Android.Content;
using Android.Graphics.Drawables;
using My_GWA;
using My_GWA.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendererAndroid))]
namespace My_GWA.Droid
{
    class CustomEntryRendererAndroid : EntryRenderer
    {
        public CustomEntryRendererAndroid(Context context) : base(context)
        {

        }
        CustomEntry customEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                customEntry = (CustomEntry)e.NewElement;
                var gradientDrawable = new GradientDrawable();

                gradientDrawable.SetCornerRadius(customEntry.EntryCornerRadius);
                gradientDrawable.SetStroke(2, customEntry.EntryBorderColor.ToAndroid());

                Control.SetBackground(gradientDrawable);
            }
            if (Control != null)
            {
                this.Control.KeyListener = GetDigitsKeyListener(Android.Text.InputTypes.ClassNumber);
                this.Control.KeyListener = GetDigitsKeyListener(Android.Text.InputTypes.NumberFlagDecimal);               
            }
        }
    }
}