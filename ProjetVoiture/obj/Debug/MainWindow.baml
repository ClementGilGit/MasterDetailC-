   M S B A M L   `   `   `  ����A  =Metier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:Metier;assembly=MetierMetier  5   	    ProjetVoiture   ProjetVoiture.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2l$clr-namespace:Metier;assembly=Metier     5   	     � Title$  Annuaire Voiture��5   	   $	��700��6"   $	��900��6/    � Icon$ Image/icon.png��5   	   
����  � � 	Resources 5      �� 5   
    �� Member$ l:Marque.Marques��6      Key
ListMarque  6-   .��5
      ]� .+�5   
   �� $��Bottom=�6   $8��2Master Detail by GIL Clément et LAPLANCHE Quentin��6(   $��Center=�6d   
�����_�$
��Bold"�6�   � 5   
   $
��Left=�6J   $
��Left=�6`    � DataContext 6   ��   
ListMarque �� Source# [  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      $	��160 �6'   �� 5      .+�5      �� $��0��6   $!��Sélectionnez une marque : ��6,    �� TextAlignment$ Center=�6N   $
��Bold"�6e   �� 5      -   5        $��35��5      $��1��6$   $��+��64   $
��Bold"�6@   6R   5      �� 5      -   5        $��mListBoxMarques��5   5   	 �� DisplayMemberPath$		 Nom��5      $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6.   $��1��6S   $��Stretch=�6`   
������� �� SelectedIndex$ -1��5   *   ��5   M   ��  � ContextMenu 5      �� 5      .@�5       m� -   5        $��	Supprimer��5    #   66   5!      5#      � 5$      $��2��6    5%      �� 5&      $	��160 �6'   �� 5'      .+�5)      �� $��0��6   $!��Sélectionnez un modèle : ��6,   $ Center=�6M   $
��Bold"�6d   �� 5*      -   5        $��35��5*      $��1��6%   $��+��65   $
��Bold"�6A   6S   5+      �� 5,      -   5        $��ListBoxModele��5,      $
	 Nomm��6L   $��3��5-      $

 TrueY�6H   $��Stretch=�5.      
���������5,   +   �� *
/Modeles+ 5/      �� 50      .@�51      m� -   5        $��	Supprimer��51   #   66   52      54      55      � 56   
   -   5        $��GridBG��56      # [ 6   ��57      �� 58       �� ImageSource$ Image/fond3.jpg��6    5:      �� 5;      �� 5<      $
��Auto �6    .+�5?      (� -   5        $��ImageMarque��5?      $y�Hidden=�6*   .��5@      �� -	   5        $��mImage��5@   7   ��6   �� *ImageSource+67   5A      (� 5B      -
   5        $��ImageVoiture��5B   *   $y�Hidden=�6   .��5C      �� ��6   �� */Modeles/ImageSource+5D      �� 5E      -   5        $��BorderDetail��5F   9   $��1��5E      
�����_�
���   �$��2q�6N    J� Opacity$	 0.9Q�5F      $y�Hidden=�6%   ._�5G      �  5H       �� 
TargetType �� Property �� Value��%y  '�       '�� o     '�� �     �� 5I      " �6    .�5J      ��  � ��$ 2q�68   �� 5K       � ��$ Center=�6D   5L      �� 5M      " ��6    .�5N      ��  � ��$ 17(�69   �� 5O       � ��$
 Bold"�6;   5P      �� 5Q      " ��6    .�5R      ��  �@��TextAlignment$ Center=�6>   �� 5S       � ��$ 17(�69   5T      5U      .+�5V      �� -   5        $��DetailMarque��5V   !   $y�Hidden=�65   .+�5W      � .+�5X      �� $��Nom: ��6)   �� 5Y      ��6(   �� *Nom+ �� UpdateSourceTrigger$ PropertyChanged=�5Z      � 5[      .+�5\      �� $��Pays: ��6(   �� 5]      ��6&   �� *Pays+$ PropertyChanged=�5^      � 5_      .+�5`      �� $��Fondateur: ��6(   �� 5a      ��6&   �� *	Fondateur+$ PropertyChanged=�5b      5c      �� 5d      -   5        $��DetailModele��5d   !   $y�Hidden=�65    6I   �� *
/Modeles+.+�5e      � .+�5f      �� $��Nom: ��6)   �� 5g      ��6(   �� */Nomm+$ PropertyChanged=�5h      � 5i      .+�5j      �� $��Puissance: ��6(   �� 5k      ��6&   �� *
/Puissance+$ PropertyChanged=�5l      � 5m      .+�5n      �� $��Année: ��6(   �� 5o      ��6&   �� */Annee+$ PropertyChanged=�5p      5q      5r      5s      5t      5u      5v      