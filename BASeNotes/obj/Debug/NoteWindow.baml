   M S B A M L   `   `   `  ����D  @BASeNotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BASeNotes	BASeNotes  5      N JWPFToolkit.Extended, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nulldEclr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit.ExtendedMicrosoft.Windows.Controls 5          BASeNotes.NoteWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.31016.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      'localclr-namespace:BASeNotes    5      WtoolkitEclr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit.Extended    5      -   5          � Title$  
NoteWindow��5      $	��328��6   $	��473��6%   .��5
      �  � RowDefinitions 5   
   �� 5      $
��141* �6   �� 5      $
��121* �6   .+�5   
   o� -   5        $��notemenu��5      $��22��6   $	��Top=�6+    � DataContext 6C   ��  �� ElementName$ lstNotes�� �� Path$ SelectedItem�.@�5      m� -   5        $��mnuFile��5   %   $
��File��6   .@�5      m� -   5        $��
mnuFileNew��5   (   $	��New��6    m� Icon 5      �� 5      $ ��Resources/document-new.png��6    $��16��6E   $��16��6P   6^   5      m� 5      -   5        $��mnuSave��5   )   $
��Save��6    5      �� 6&   $!��Resources/document-save.png��6,   $��16��6R   $��16��6]   6k   5      m� 5      -   5        $��	mnuSaveAs��5   /   $��
Save As...��6    5      �� 5      $$��Resources/document-save-as.png��6    $��16��6I   $��16��6T   6b   5      m� 5       -   5        $��mnuOpen��5    )   $
��Open��6    5!      �� 5"      $!��Resources/document-open.png��6    $��16��6F   $��16��6Q   6_   5%      �� 5&      m� 5'      -   5        $��
mnuOptions��5'   ,   $��Options��6   6Y   �� 5(      m� 5)      -	   5        $��mnuExit��5)   )   $
��Exit��6   6R   5+      m� 5.      -
   5        $��mnuNotes��5.   &   $��Notes��6   .@�5/      m� -   5        $��mnuNotesNew��5/   (   $	��New��6   6;   m� 50      -   5        $��mnuNotesDelete��50   +   $��Delete��6   6`   52      m� 53      -   5        $��mnuAbout��53   &   $��About��6   .@�54      m� -   5        $��mnuAboutAbout��54   *   $��About��6   6_   55      56      �� 58   
   -   5        $��lstNotes��58   P   $��2��6   $
��Left=�6#   $��4,26,0,3q�6>   $	��156��6`    �� DisplayMemberPath$
 Name��59       �� SelectionMode$ Extended=�6+    J� 	AllowDrop . ��5:      �� 5;      	 �� 
TargetType"	 ��6   .�5<      -   5        5=      5@      � 5E   
   -   5        $��grdDataContentMultiple��5E   I   $��2��6   $��
166,27,4,3q�6    $y�Visible=�64    6g   �� $ lstNotes��$ SelectedItems�.+�5G      �� -   5        $��lstMultiNote��5G   O   ��.  
�������$ Single=�6c   $��Disabled=�6z   ��5H      �� 5I      .R�5J      �� $��5q�6   $��3q�6(   
�����F�
 �� CornerRadius$
 4��6T   ._�5K      9�  9� 
IsExpanded . $��0,0,0,0q�61   ��5L   "   �� 5M   &   -   5        $��0,0,0,0q�5M   I   $	��256��6Z   ��6.   �� $
 Name�6�   .��5Q   &   �� .+�5r   &   ,  &Microsoft.Windows.Controls.RichTextBox  $��richelementlist��6�   -   5         �� 	IsEnabled . !   BASeNotes.RichTextBoxHelper   DocumentXaml 5r   �   �� *Note+<  6Microsoft.Windows.Controls.RichTextBoxFormatBarManager   	FormatBar 5s   *      BASeNotes.MyFormattingBar  5u   2   5y   '   5{   #   5|   #   5}      5~      5�      5�      5�      5�      