using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using BASeNotes.Properties;
using Microsoft.Win32;
using Path=System.IO.Path;

namespace BASeNotes
{
    /// <summary>
    /// Interaction logic for NoteWindow.xaml
    /// </summary>
    public partial class NoteWindow : Window
    {
        private ObservableCollection<NoteItem> _Notes;
        public NoteWindow()
        {
            InitializeComponent();
        }

        private void mnuNewNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {

        }
        private static String getappdatafolder()
        {
            String appdata = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appdata = System.IO.Path.Combine(appdata, "BASeNotes");
            if (!Directory.Exists(appdata))
            {
                Directory.CreateDirectory(appdata);


            }
            return appdata;
            
        }
        private static string getnotedatafilename()
        {
            String appdata = getappdatafolder();
            string datafilename = "notes.dat";
            String Notedatafile = System.IO.Path.Combine(appdata, datafilename);
            return Notedatafile;




        }

        private void LoadDefaultData()
        {
            String Notedatafile = getnotedatafilename();

            LoadNotes(Notedatafile);
        }
        private void LoadNotes()
        {
            Microsoft.Win32.OpenFileDialog ofd = new OpenFileDialog()
            {
                CheckFileExists=true,AddExtension=true,Filter=BaseNotesFileFilter


            };
            if(ofd.ShowDialog(this).Value)
            {

                mLoadedFile = ofd.FileName;
                LoadNotes(mLoadedFile);




            }
            else
            {
                return;
            }


        }

        private bool LoadNotes(string Notedatafile)
        {
            ObservableCollection<NoteItem> loadeddata;
            if (File.Exists(Notedatafile))
            {
                try
                {
                    BinaryFormatter notereader = new BinaryFormatter();
                    FileStream readfile = new FileStream(Notedatafile, FileMode.Open);
                    loadeddata = (ObservableCollection<NoteItem>)notereader.Deserialize(readfile);
                }
                catch
                {
                    return false;

                }
                UpdateState();
                _Notes=loadeddata;
                lstNotes.ItemsSource=_Notes; 
                return true;


            }
            else
            {
                return false;
            }
        }

        private void createtestnotedata()
        {
            _Notes = new ObservableCollection<NoteItem>();

            const string Notesampletext =
                @"<FlowDocument PagePadding=""5,0,5,0"" AllowDrop=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""><Paragraph> This is sample text demonstrating the display of Note data for sample Number {0}; of course, normally each note would be different</Paragraph><Paragraph>and display different data. Additionally note how it (should) wrap as well as display a scroll bar for text that exceeds the display amount.</Paragraph><Paragraph>ideally it would simply expand the expander content area by resizing the textbox to fit the new height....</Paragraph></FlowDocument>";            



                    
            for (int i = 0; i<50; i++)
            {
                _Notes.Add(new NoteItem ("Note #" + i.ToString(),String.Format(Notesampletext,i)));


            }






        }

        private void reloaddisplay()
        {
            //clear all the expanders...
            //sviewexpanders.Content = _Notes;
            //stackexpanders.Children.Clear();
            lstNotes.ItemsSource=_Notes;
            
            /*
            foreach (NoteItem loopnote in _Notes)
            {
                //create a new Expander...
                Expander newExpander = new Expander();


                BulletDecorator bdec = new BulletDecorator();
                

                
                //set the text of the expander to the note name, and create a textbox inside the expander containing the note.
                //put that textbox inside a scrollviewer, actually... just in case.
                //ScrollViewer expanderscroller = new ScrollViewer();
                TextBox notebox = new TextBox();
                TextBlock headerblock = new TextBlock();
                TextBlock TBBullet = new TextBlock();
                TBBullet.FontSize = 24;
                TBBullet.Text = "•";
                headerblock.Text = loopnote.Name;
                headerblock.Margin = new Thickness(0,0,0,0);
                bdec.Background = SystemColors.GradientActiveCaptionBrush;
                bdec.Bullet = TBBullet;
                bdec.Child = headerblock;
                bdec.Margin=new Thickness(3,2,3,2);
                newExpander.Header = bdec;
                notebox.Tag = loopnote; //set tag to the actual note.
                notebox.TextWrapping=TextWrapping.WrapWithOverflow;
                notebox.TextChanged+=new TextChangedEventHandler(notebox_TextChanged);
                notebox.Text = loopnote.Note;
                notebox.Margin= new Thickness(0,0,0,0);
                //expanderscroller.Content = notebox;
                //Grid ExpanderContentGrid = new Grid();
                //ExpanderContentGrid.Children.Add(notebox);
                //newExpander.Content = ExpanderContentGrid;

                newExpander.Content=notebox;

                


                stackexpanders.Children.Add(newExpander);

                

            }

            */
        }

void  notebox_TextChanged(object sender, TextChangedEventArgs e)
{
    Debug.Print("The Notebox has detected a change...");
    TextBox changedbox = (TextBox)sender;
    NoteItem itemchanged = (NoteItem)changedbox.Tag;
    Debug.Print("Item that changed was named " + itemchanged.Name);


}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //On load, we want to:
            //Load all stored notes
            createtestnotedata();
            reloaddisplay();
        }
        public const String BaseNotesFileFilter = "BASeNotes Files(*.bcn)|*.bcn|All Files(*.*)|*.*";
        private void SaveNotes()
        {
            //Saves the notes; if there is an existing filename, it saves there. otherwise, it prompts for a filename.
            if (mLoadedFile == "")
            {
                Microsoft.Win32.SaveFileDialog sfd = new SaveFileDialog
                                                         {
                                                             AddExtension = true,
                                                             Filter = BaseNotesFileFilter,
                                                             Title = "Save Note Database"
                                                         };
                if (sfd.ShowDialog(this).Value)
                {
                    //they chose a file...
                    mLoadedFile = sfd.FileName;
                    


                }
                else
                {
                    return;
                }






            }
            SaveNotes(mLoadedFile);



        }
        
        private void SaveNotes(String sFilename)
        {
            BinaryFormatter sformatter = new BinaryFormatter();
            FileStream outstream = new FileStream(sFilename,FileMode.Create);
            sformatter.Serialize(outstream, _Notes);
            isDirty=false;
            mLoadedFile=sFilename;
            UpdateState();

        }
        /// <summary>
        /// Called whenever the state of the current file changes; usually on save/load.
        /// </summary>
        private void UpdateState()
        {
            Title = "BASeNotes - " + Path.GetFileName(mLoadedFile);
        }

        String mLoadedFile = "";
        bool isDirty=false;
        private void mnuFileNew_Click(object sender, RoutedEventArgs e)
        {

            String usemessage = "The Current File has not been Saved. Save now?";

            if (mLoadedFile != "")
                usemessage = "File, " + Path.GetFileName(mLoadedFile) + " has changed. Save changes?";
            if (isDirty)
            {
                switch(Microsoft.Windows.Controls.MessageBox.Show(usemessage,"File not Saved",MessageBoxButton.YesNoCancel))
                {
                    case MessageBoxResult.Yes:
                        SaveNotes();
                        break;
                    case MessageBoxResult.No:
                        break;
                        case MessageBoxResult.Cancel:
                        return;



                }



            }
            mLoadedFile = "";
            isDirty=false;
            _Notes = new ObservableCollection<NoteItem>();
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveNotes();
        }

        private void mnuSaveAs_Click(object sender, RoutedEventArgs e)
        {
            mLoadedFile = "";
            SaveNotes();
        }

        private void mnuExit_Click_1(object sender, RoutedEventArgs e)
        {

               String usemessage = "The Current File has not been Saved. Save now?";

            if (mLoadedFile != "")
                usemessage = "File, " + Path.GetFileName(mLoadedFile) + " has changed. Save changes?";
            if (isDirty)
            {
                switch(MessageBox.Show(usemessage,"File not Saved",MessageBoxButton.YesNoCancel))
                {
                    case MessageBoxResult.Yes:
                        SaveNotes();
                        break;
                    case MessageBoxResult.No:
                        break;
                        case MessageBoxResult.Cancel:
                        return;



                }



            }


            Close();
        }

        private void mnuNotesNew_Click(object sender, RoutedEventArgs e)
        {
            //add an item.
            //lstNotes.SelectedIndex = lstNotes.ItemsSource .Add(new NoteItem("New Note",""));
            var creatednote = new NoteItem("New Note");
            _Notes.Add(creatednote);
           // lstNotes.SelectedItem = creatednote;
        }

        private void mnuNotesDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete " + lstNotes.SelectedItems.Count.ToString() + " Items?","Confirm Delete",MessageBoxButton.YesNo)==MessageBoxResult.Yes)
                foreach(var itemloop in lstNotes.SelectedItems)
                    lstNotes.Items.Remove(itemloop);
        }

        private void lstNotes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.Print("lstNotes_SelectionChanged");
            lstMultiNote.ItemsSource = lstNotes.SelectedItems;
            //foreach (var loopit in e.AddedItems)
            //{
            if (lstNotes.SelectedItems.Count == 1)
            {





            }



        }
        private RichTextBox Getboxforbutton(Button buttonfor)
        {
            if(buttonfor==null) return null;
            ToolBar parenttoolbar = buttonfor.Parent as ToolBar;
            StackPanel expandit = VisualTreeHelper.GetParent(parenttoolbar) as StackPanel;
            RichTextBox gotbox = expandit.Children[1] as RichTextBox;
            return gotbox;

        }
        private ToolBar GetToolbarforTextBox(RichTextBox boxfor)
        {
            if(boxfor==null) return null;
            StackPanel spanel = VisualTreeHelper.GetParent(boxfor) as StackPanel;
            return spanel.Children[0] as ToolBar;



        }

        private void CutToolbar_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox workBox = Getboxforbutton(sender as Button);
            if(workBox==null) return;


            
            Debug.Print("Cut Toolbar clicked.");
        }

        private void CopyToolbar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PasteToolbar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoldToolbar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ItalicToolbar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void richelementlist_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //RichTextBox rtext = sender as RichTextBox;
            //object currentValue = rtext.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            //ToolBar barbox = GetToolbarforTextBox(rtext);
            
            //Bold.IsChecked = (currentValue == DependencyProperty.UnsetValue) ? false : currentValue != null && currentValue.Equals(FontWeights.Bold); ;
        }

        private void mnuNotes_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            //Enabled/Disable "Delete" Item based on wether there is a selected item.
            mnuNotesDelete.IsEnabled = (lstNotes.SelectedItems.Count > 0);
        }

        private void richelementlist_TextChanged(object sender, TextChangedEventArgs e)
        {
            isDirty=true;
        }

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            LoadNotes();
        }

        private void mnuOptions_Click(object sender, RoutedEventArgs e)
        {
            (new SettingsPage()).Show();
        }
        private static object GetObjectDataFromPoint(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                        element = VisualTreeHelper.GetParent(element) as UIElement;

                    if (element == source)
                        return null;



                }

                if (data != DependencyProperty.UnsetValue)
                    return data;



            }
            return null;
        }
        private void lstNotes_DragOver(object sender, DragEventArgs e)
        {
            Debug.Print(sender.GetType().Name);
            ListBoxItem litem = sender as ListBoxItem;
            if (litem != null)
            {
                
                lstNotes.SelectedItem=litem;
                lstMultiNote.ItemsSource = lstNotes.SelectedItems;

            }

        }

        


    }
}
