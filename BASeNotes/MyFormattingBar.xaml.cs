using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls;
using RichTextBox=Microsoft.Windows.Controls.RichTextBox;

namespace BASeNotes
{
    /// <summary>
    /// Interaction logic for MyFormattingBar.xaml
    /// </summary>
    public partial class MyFormattingBar : UserControl, IRichTextBoxFormatBar
    {
        public MyFormattingBar()
        {
            InitializeComponent();
        }

        #region IRichTextBoxFormatBar Members

        System.Windows.Controls.RichTextBox  _Target;
        public System.Windows.Controls.RichTextBox Target
        {
            get
            {
                //throw new NotImplementedException();
                return _Target;
            }
            set
            {
                _Target = value;
                _Target.SelectionChanged += new RoutedEventHandler(_Target_SelectionChanged);
                RefreshBar();

                FormatBold.CommandTarget=_Target;
                FormatBold.Command=EditingCommands.ToggleBold;
                FormatItalic.CommandTarget=_Target;
                FormatItalic.Command = EditingCommands.ToggleItalic;

                FormatUnderline.CommandTarget=_Target;
                FormatUnderline.Command = EditingCommands.ToggleUnderline;
                
                FormatAlignLeft.CommandTarget=_Target;
                FormatAlignLeft.Command=EditingCommands.AlignLeft;

                FormatAlignCenter.CommandTarget = _Target;
                FormatAlignCenter.Command = EditingCommands.AlignCenter;


                FormatAlignRight.CommandTarget = _Target;
                FormatAlignRight.Command = EditingCommands.AlignRight;


                
                
                //throw new NotImplementedException();
            }
        }

        void _Target_SelectionChanged(object sender, RoutedEventArgs e)
        {
            RefreshBar();
        }

        #endregion

        
        public static void SetFontSize(RichTextBox target, double value)
        {
            // Make sure we have a richtextbox.
            if (target == null)
                return;

            // Make sure we have a selection. Should have one even if there is no text selected.
            if (target.Selection != null)
            {
                // Check whether there is text selected or just sitting at cursor
                if (target.Selection.IsEmpty)
                {
                    // Check to see if we are at the start of the textbox and nothing has been added yet
                    if (target.Selection.Start.Paragraph == null)
                    {
                        // Add a new paragraph object to the richtextbox with the fontsize
                        Paragraph p = new Paragraph();
                        p.FontSize = value;
                        target.Document.Blocks.Add(p);
                    }
                    else
                    {
                        // Get current position of cursor
                        TextPointer curCaret = target.CaretPosition;
                        // Get the current block object that the cursor is in
                        Block curBlock = target.Document.Blocks.Where
                            (x => x.ContentStart.CompareTo(curCaret) == -1 && x.ContentEnd.CompareTo(curCaret) == 1).FirstOrDefault();
                        if (curBlock != null)
                        {
                            Paragraph curParagraph = curBlock as Paragraph;
                            // Create a new run object with the fontsize, and add it to the current block
                            Run newRun = new Run();
                            newRun.FontSize = value;
                            curParagraph.Inlines.Add(newRun);
                            // Reset the cursor into the new block. 
                            // If we don't do this, the font size will default again when you start typing.
                            target.CaretPosition = newRun.ElementStart;
                        }
                    }
                }
                else // There is selected text, so change the fontsize of the selection
                {
                    TextRange selectionTextRange = new TextRange(target.Selection.Start, target.Selection.End);
                    selectionTextRange.ApplyPropertyValue(TextElement.FontSizeProperty, value);
                }
            }
            // Reset the focus onto the richtextbox after selecting the font in a toolbar etc
            target.Focus();
        }



        private void RefreshBar()
        {
            ComboFont.SelectedItem = _Target.Selection.GetPropertyValue(System.Windows.Controls.RichTextBox.FontFamilyProperty);
            //refresh our controls based on the new _Target value.
         /*   cmdCut.IsEnabled = _Target.Selection.Text.Length > 0;
            cmdCopy.IsEnabled = cmdCut.IsEnabled;
            cmdPaste.IsEnabled = Clipboard.ContainsData(DataFormats.Rtf) ||
                Clipboard.ContainsData(DataFormats.StringFormat) ||
                Clipboard.ContainsData(DataFormats.Xaml) || Clipboard.ContainsData(DataFormats.Bitmap);


            FormatAlignLeft.IsChecked = ((TextAlignment)_Target.Selection.GetPropertyValue(Paragraph.TextAlignmentProperty) == TextAlignment.Left);
            FormatAlignCenter.IsChecked = ((TextAlignment)_Target.Selection.GetPropertyValue(Paragraph.TextAlignmentProperty) == TextAlignment.Center);
            FormatAlignRight.IsChecked = ((TextAlignment)_Target.Selection.GetPropertyValue(Paragraph.TextAlignmentProperty) == TextAlignment.Right);
            */
        }

     /*   private void cmdCut_Click(object sender, RoutedEventArgs e)
        {
            _Target.Cut();
        }

        private void cmdCopy_Click(object sender, RoutedEventArgs e)
        {
            _Target.Copy();
        }

        private void cmdPaste_Click(object sender, RoutedEventArgs e)
        {
            _Target.Paste();
        }
        */
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
        /*
        private void AlignLeft_Click(object sender, RoutedEventArgs e)
        {
            _Target.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Left);
            RefreshBar();
        }

        private void FormatAlignCenter_Click(object sender, RoutedEventArgs e)
        {
            _Target.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Center);
            RefreshBar();
        }

        private void FormatAlignRight_Click(object sender, RoutedEventArgs e)
        {
            _Target.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Right);
            RefreshBar();
        }
*/
        private void FormatBold_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FormatItalic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FormatUnderline_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ChangeTextProperty(System.Windows.Controls.RichTextBox rtbuse,DependencyProperty dp, string value)
        {
            if (rtbuse == null) return;

            TextSelection ts = rtbuse.Selection;
            if (ts != null)
                ts.ApplyPropertyValue(dp, value);
            rtbuse.Focus();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //_Target.Selection.ApplyPropertyValue(Paragraph.SetFontFamily, ComboFont.SelectedItem);
            if(ComboFont.SelectedItem==null) return;
            ChangeTextProperty(_Target, System.Windows.Controls.RichTextBox.FontFamilyProperty, ComboFont.SelectedItem.ToString());
        }

    }
}
