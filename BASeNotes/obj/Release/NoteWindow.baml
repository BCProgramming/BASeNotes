   M S B A M L   `   `   `  ���� D  @BASeNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BASeNotes	BASeNotes  N JWPFToolkit.Extended, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nulldEclr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit.ExtendedMicrosoft.Windows.Controls     BASeNotes.NoteWindow   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.31016.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    'localclr-namespace:BASeNotes    WtoolkitEclr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit.Extended    -     � Title$  
NoteWindow��$	��328��$	��473��.���  � RowDefinitions �� $
��141* ��� $
��121* �.+�o� -   $��notemenu��$��22��$	��Top=� � DataContext ��  �� ElementName$ lstNotes�� �� Path$ SelectedItem�.@�m� -   $��mnuFile��$
��File��.@�m� -   $��
mnuFileNew��$	��New�� m� Icon �� $ ��Resources/document-new.png��$��16��$��16��m� -   $��mnuSave��$
��Save�� �� $!��Resources/document-save.png��$��16��$��16��m� -   $��	mnuSaveAs��$��
Save As...�� �� $$��Resources/document-save-as.png��$��16��$��16��m� -   $��mnuOpen��$
��Open�� �� $!��Resources/document-open.png��$��16��$��16���� m� -   $��
mnuOptions��$��Options���� m� -	   $��mnuExit��$
��Exit��m� -
   $��mnuNotes��$��Notes��.@�m� -   $��mnuNotesNew��$	��New��m� -   $��mnuNotesDelete��$��Delete��! http://i.imgur.com/ShYCwiQ.jpgm� -   $��mnuAbout��$��About��.@�m� -   $��mnuAboutAbout��$��About���� -   $��lstNotes��$��2��$
��Left=�$��4,26,0,3q�$	��156�� �� DisplayMemberPath$
 Name�� �� SelectionMode$ Extended=� J� 	AllowDrop . ���� 	 �� 
TargetType"	 ��.�-   � -   $��grdDataContentMultiple��$��2��$��
166,27,4,3q�$y�Visible=� �� $ lstNotes��$ SelectedItems�.+��� -   $��lstMultiNote����.  
�������$ Single=�$��Disabled=����� .R��� $��5q�$��3q�
�����F�
 �� CornerRadius$
 4��._�9�  9� 
IsExpanded . $��0,0,0,0q����� -   $��0,0,0,0q�$	��256������ $
 Name�.���� .+�,  &Microsoft.Windows.Controls.RichTextBox  $��richelementlist��-    �� 	IsEnabled . !   BASeNotes.RichTextBoxHelper   DocumentXaml �� *Note+<  6Microsoft.Windows.Controls.RichTextBoxFormatBarManager   	FormatBar    BASeNotes.MyFormattingBar  