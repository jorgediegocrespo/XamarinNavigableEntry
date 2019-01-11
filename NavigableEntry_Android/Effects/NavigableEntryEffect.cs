using NavigableEntry;
using NavigableEntry_Android.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Effects")]
[assembly: ExportEffect(typeof(NavigableEntryEffect), nameof(NavigableEntryEffect))]
namespace NavigableEntry_Android.Effects
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class NavigableEntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            // Check if the attached element is of the expected type and has the NextEntry
            // property set. if so, configure the keyboard to indicate there is another entry
            // in the form and the dismiss action to focus on the next entry
            if (base.Element is NavigableEntryControl xfControl && xfControl.NextEntry != null)
            {
                var entry = (Android.Widget.EditText)Control;

                entry.ImeOptions = Android.Views.InputMethods.ImeAction.Next;
                entry.EditorAction += (sender, args) =>
                {
                    xfControl.OnNext();
                };
            }
        }

        protected override void OnDetached()
        {
            // Intentionally empty
        }
    }
}
