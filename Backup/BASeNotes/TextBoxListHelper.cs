using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

namespace BASeNotes
{
    public class TextBoxListHelper : DependencyObject
    {
        private static HashSet<Thread> threadset = new HashSet<Thread>();

        public static void SetBoxText(DependencyObject obj)
        {
                if (threadset.Contains(Thread.CurrentThread))
                    return;


        }
        public static readonly DependencyProperty BoxTextProperty = DependencyProperty.RegisterAttached("BoxText",typeof(String),
            typeof(TextBoxListHelper),
            new FrameworkPropertyMetadata
                ("",
                FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnPropChanged));
                
                
        protected static void OnPropChanged(DependencyObject dpo, DependencyPropertyChangedEventArgs e)
        {
     

            threadset.Add(Thread.CurrentThread);
            






            threadset.Remove(Thread.CurrentThread);
        }   





    }
}
