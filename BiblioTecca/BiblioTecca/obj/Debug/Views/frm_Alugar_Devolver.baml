   M S B A M L   `   `   `  ����F  BBiblioTecca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BiblioTecca.ViewsBiblioTecca.Views  5   	   +    %BiblioTecca.Views.frm_Alugar_Devolver   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BiblioTecca.Views     5   	   -   5          �Name$   fmr_Livros_Alugar_Devolver��5   	    � Title$  Livros - Alugar / Devolver��5   	   $	��300��6,   $	��585��69    � Icon$: 4/BiblioTecca;component/Icons/Folders-Application.ico��6E   ���	#FFE2E2E2.��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ txt_IdLivro_Buscar��5
      $
��Left=�6.   $��23��6I   $��	96,63,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��193��6�   6�   �� 5   
   -   5        $ txt_NomeLivro_Locacao��5      $
��Left=�61   $��23��6L   $��	96,91,0,0q�6X   $
 Wrap=�6k   $	��Top=�6   $	��193��6�   {�.  6�   �� 5   
   -   5         ��Name$ lbl_Livro_Locacao��5      $��Livro��6+   $
��Left=�6;   $��	17,91,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ txt_NomePessoa_Locacao��5      $
��Left=�62   $��23��6M   $��
365,91,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��200��6�   {�.  6�   �� 5   
   -   5        $ lbl_Pessoa_Locacao��5      $��Pessoa��6,   $
��Left=�6=   $��
314,88,0,0q�6X   $	��Top=�6l    J� RenderTransformOrigin$ 0.147,0.468&�6�   �� 5   
   -   5        $ lbl_Status_Locacao��5      $��Status��6,   $
��Left=�6=   $��
17,171,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ lbl_CodLivro_Locacao��5      $��	Cod Livro��6.   $
��Left=�6B   $��	13,65,0,0q�6]   $	��Top=�6p   �� 5   
   -	   5        $ txt_CpfPessoa_Locacao��5      $
��Left=�61   $��23��6L   $��
365,63,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��200��6�   6�   �� 5   
   -
   5        $ lbl_Cpf_Pessoa_Locacao��5      $	��CPF��60   $
��Left=�6>   $��
314,63,0,0q�6Y   $	��Top=�6m   $ 0.581,-0.671&�6�   �� 5   
   -   5         ��Name$ txt_Situacao��5      $
��Left=�6)   $��
96,175,0,0q�6D   $	��Top=�6X   $	��120��6p   {�.  .@�5      �� $��Disponível��6   $
��Left=�60   $	��118��6K   �� 5      $��Indisponível��6   $
��Left=�62   $	��118��6M   5      �� 5   
   -   5         ��Name$* $btn_fmr_Livros_Alugar_Devolver_Locar��5      $��Alugar��6?   $
��Left=�6P   $��330,238,0,0q�6k   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $- 'btn_fmr_Livros_Alugar_Devolver_Cancelar��5      $��Cancelar��6B   $
��Left=�6U   $��490,238,0,0q�6p   $	��Top=�6�   $��75��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 txt_Data_Limite_Devolucao��5      $
��Left=�68   $��365,179,0,0q�6S   $	��Top=�6h   $	��200��6�   {�.  6�   �� 5   
   -   5        $ lbl_Data_Limite_Devolucao��5      $��Data Limite Devolução��63   $
��Left=�6S   $��231,180,0,0q�6n   $	��Top=�6�     5   
   -   5        $	 txt_Data_Devolucao��5      $
��Left=�61   $��365,208,0,0q�6L   $	��Top=�6a   $	��200��6y   �� 5   
   -   5        $ lbl_Data_Devolucao��5      $��Data Devolução��6,   $
��Left=�6E   $��266,206,0,0q�6`   $	��Top=�6u   �� 5   
   -   5        $- 'btn_fmr_Livros_Alugar_Devolver_Devolver��5      $��Devolver��6B   $
��Left=�6U   $��410,238,0,0q�6p   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $  txt_ColetaneaLivro_Locacao��5      $
��Left=�66   $��23��6Q   $��
96,119,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��193��6�   {�.  6�   �� 5   
   -   5        $$ txt_LivroClassificacao_Locacao��5      $
��Left=�6:   $��23��6U   $��
96,147,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��193��6�   {�.  6�   �� 5    
   -   5        $  lbl_ColetaneaLivro_Locacao��5       $��
Coletânea��64   $
��Left=�6H   $��
14,117,0,0q�6c   $	��Top=�6w   $ 0.586,1.801&�6�   �� 5!   
   -   5        $ lbl_LivroClassificacao��5!      $��Classificação��60   $
��Left=�6H   $��
14,147,0,0q�6c   $	��Top=�6w   $ 0.586,1.801&�6�   �� 5"   
   -   5        $ txt_IdLocacao_Buscar��5"      $
��Left=�60   $��23��6K   $��	96,24,0,0q�6W   $
 Wrap=�6j   $	��Top=�6~   $	��193��6�   6�   �� 5#   
   -   5        $ lbl_CodLocacao��5#      $��Cod Locação��6(   $
��Left=�6>   $��	14,24,0,0q�6Y   $	��Top=�6l   5%      5&      