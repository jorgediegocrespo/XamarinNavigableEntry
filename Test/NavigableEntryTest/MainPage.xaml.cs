using Xamarin.Forms;

namespace NavigableEntryTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DefineControlsNavigation();
            DefineEffects();
        }

        private void DefineControlsNavigation()
        {
            EntryOne.NextView = EntryTwo;
            EntryTwo.NextView = EntryThree;
        }

        private void DefineEffects()
        {
            var navigableEntryEffect = "Effects.NavigableEntryEffect";
            EntryOne.Effects.Add(Effect.Resolve(navigableEntryEffect));
            EntryTwo.Effects.Add(Effect.Resolve(navigableEntryEffect));
            EntryThree.Effects.Add(Effect.Resolve(navigableEntryEffect));
        }
    }
}
