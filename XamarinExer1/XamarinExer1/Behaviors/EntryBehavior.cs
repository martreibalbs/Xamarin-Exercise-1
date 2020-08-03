using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinExer1.Behaviors
{
    public class EntryBehavior : Behavior<Entry>
    {
        public int MaxLength { get; set; }
        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);
            entry.TextChanged += EntryChanged;
            entry.TextChanged += OnEntryLengthChanged;

        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.TextChanged -= EntryChanged;
            entry.TextChanged -= OnEntryLengthChanged;
        }

        private void EntryChanged(object sender, TextChangedEventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(args.NewTextValue))
            {
               
                if (args.OldTextValue != null && args.NewTextValue.Length < args.OldTextValue.Length)
                    return;

                var value = args.NewTextValue;

                if (value.Length == 4)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                if (value.Length == 9)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                if (value.Length == 14)
                {
                    ((Entry)sender).Text += " ";
                    return;
                }

                ((Entry)sender).Text = args.NewTextValue;
            }
        }

        private void OnEntryLengthChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            
            if (entry.Text.Length > this.MaxLength)
            {
                string entryText = entry.Text;

                entryText = entryText.Remove(entryText.Length - 1);  

                entry.Text = entryText;
            }
        }
    }
}
