   M S B A M L   `   `   `  ����R  NMathematical Operations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Mathematical_Operations.ViewsMathematical_Operations.Views  5      W0clr-namespace:Mathematical_Operations.ViewModels"Mathematical_Operations.ViewModels  5      2    ,Mathematical_Operations.Views.CalculatorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Mathematical_Operations.Views     5      G
viewmodels0clr-namespace:Mathematical_Operations.ViewModels     5      -   5        $��
Calculator��5
        � 	Resources  5       �� 
TargetType �� Property �� Value �� RelativeSource�� 5   
   %  '��       �� 5      " ��6   .�5      ��  � ��$ 40��6+   �� 5       � ��$ 40��6*   �� 5       � ��$ 5q�6+   �� 5       � �� 6,   �� *ButtonPushedCommand+�� 5       � �� 65   �� *	Content+ �� *Self+5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��* �6    � ColumnDefinitions 5"   
   �� 5#      $��* �6   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $��* �6   .+�5,   
   �� $��1��6   $��1q�6   $��1��62   $��5��6B   
�������$��40��6i   ���#c5c5c5._�5-      �� $��Center=�6   $��18(�63   ��6A   �� *
Expression+5.      �� 50   
   $��2��6   $��1��6   .��6.   761   �� 51   
   $��2��6   $��2��6   .��6.   861   �� 52   
   $��2��6   $��3��6   .��6.   961   �� 53   
   $��2��6   $��4��6   .��6.   +61   �� 54   
   $��2��6   $��5��6   ��6.   �� *ClearCommand+.��6O   CE6S   �� 56   
   $��3��6   $��1��6   .��6.   461   �� 57   
   $��3��6   $��2��6   .��6.   561   �� 58   
   $��3��6   $��3��6   .��6.   661   �� 59   
   $��3��6   $��4��6   .��6.   -61   �� 5:   
   $��3��6   $��5��6   ��6.   �� *EqualsCommand+.��6P   =6S   �� 5<   
   $��4��6   $��1��6   .��6.   161   �� 5=   
   $��4��6   $��2��6   .��6.   261   �� 5>   
   $��4��6   $��3��6   .��6.   361   �� 5?   
   $��4��6   $��4��6   .��6.   *61   �� 5A   
   $
��auto��6   $��5��6   $��1��6+   $��2��6;   .��6O   06R   �� 5B   
   $��5��6   $��3��6   .��6/   .62   �� 5C   
   $��5��6   $��4��6   .��6/   /62   5D      5E      