using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;

namespace BASeNotes
{
    [Serializable] 
    class NoteItem : ISerializable 
    {
        private String _Note;
        public String Name { get; set; }
        private ObservableCollection<String> mTags;
        public ObservableCollection<String> Tags { get { return mTags; }  
            set {
                
                //Tags=value;
                //loop and add all the tags from the "set" value to our collection; this prevents
                //disruption to any bound controls.
                Tags.Clear();
                foreach (String loopadd in value)
                {
                    Tags.Add(loopadd);


                }

            }
        
        }

   
        public String Note { get { return _Note; }
            set
            {
                _Note = value;
                ModifiedDate = DateTime.Now;
            }
        }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public String NoteText
        {


            get
            {
                RichTextBox tempbox = new RichTextBox();

                var stream = new MemoryStream(Encoding.UTF8.GetBytes(Note));
                var doc = (FlowDocument)XamlReader.Load(stream);
                tempbox.Document = doc;
                TextRange textRange = new TextRange(
                    // TextPointer to the start of content in the RichTextBox.
        tempbox.Document.ContentStart,
                    // TextPointer to the end of content in the RichTextBox.
        tempbox.Document.ContentEnd
        );

                return textRange.Text;

            }
          
        }
          
            //notes have names and a note... of course the latter is sort of a prerequisite...
        public NoteItem(String pName)
        {
            Name = pName;
            Note= @"<FlowDocument PagePadding=""5,0,5,0"" AllowDrop=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""><Paragraph> New Note.</Paragraph></FlowDocument>";            



        }

        public NoteItem(String pName, String pNote)
        {
            Name = pName;
            Note = pNote;
            CreationDate = DateTime.Now;
            ModifiedDate=DateTime.Now;
            
        }
        public NoteItem(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Note = info.GetString("Note");
            CreationDate = info.GetDateTime("CreationDate");
            ModifiedDate = info.GetDateTime("ModifiedDate");



        }

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Note", Note);
            info.AddValue("CreationDate", CreationDate);
            info.AddValue("ModifiedDate", ModifiedDate);
        }

        #endregion
    }
}
