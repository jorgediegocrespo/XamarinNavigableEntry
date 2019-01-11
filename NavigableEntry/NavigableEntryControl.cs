using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace NavigableEntry
{
    public class NavigableEntryControl : Entry
    {
        public static readonly BindableProperty NextViewProperty = BindableProperty.Create(nameof(NextView), typeof(View), typeof(Entry));
        public View NextView
        {
            get => (View)GetValue(NextViewProperty);
            set => SetValue(NextViewProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            this.Completed += (sender, e) =>
            {
                this.OnNext();
            };
        }

        public void OnNext()
        {
            NextView?.Focus();
        }
    }
}
