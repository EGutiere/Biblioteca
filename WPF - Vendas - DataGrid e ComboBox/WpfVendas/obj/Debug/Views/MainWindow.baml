   M S B A M L   `   `   `  ����  	WpfVendas     WpfVendas.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  	Principal��5   	   $��373.056��6   $��532.692��6,    � WindowStartupLocation$ CenterScreen=�6<   .��5      � .+�5   
   o� $
��Left=�6   $��25��6*   $	��Top=�66   $	��517��6N   .@�5      m� -   5         m�Name$ menuCadastro��5      $��	Cadastros��6-   .@�5      m� -   5        $ menuCadastroCliente��5      $��Cliente��68   $
��Left=�6I   $	��145��6d   6p   m� 5	      -   5        $ menuCadastroFuncionario��5	      $��Funcionário��6<   $
��Left=�6Q   $	��156��6l   $��	0,0,-11,0q�6x   �� 5
      $
��Left=�6   $	��145��67   m� 5      -   5        $ menuCadastroSair��5      $
��Sair��65   $
��Left=�6C   $	��145��6^   6j   5      m� 5      -   5        $ menuRelatorio��5      $��Relatórios��6.   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdClientes��5      $
��Left=�6(   $��	10,30,0,0q�6C   $	��Top=�6V   $	��255��6n   $	��270��6{      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserAddRows .  	   CanUserSortColumns	 .  
   
IsReadOnly
 .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ 	ClienteId�6T     5      $
 Nome��6J   $	 130 6Y    6%   �� $ ClienteNome�6Y     5      $	 Cpf��6I   $ 80 6V    6%   �� $ 
ClienteCpf�6V     5      $ Telefone��6N   $ 80 6`    6%   �� $ ClienteTelefone�6`     5      $ Idade��6K   $ 80 6Z    6%   �� $ ClienteIdade�6Z     5      $	 Rua��6S   $ 60 6`    6%   �� $ Endereco.EnderecoRua�6`   5      �� 5   
   -   5         ��Name$ btnLInhaSelecionada��5      $��Linha selecionada��6.   $
��Left=�6J   $��
10,301,0,0q�6e   $	��Top=�6y   $	��128��6�   6�   �� 5   
   -	   5         ��Name$ cboClientes��5      $
��Left=�6(   $��
314,30,0,0q�6C   $	��Top=�6W   $	��120��6o   �� 5   
   -
   5        $ btnItemSelecionado��5      $��Item Selecionado��6-   $
��Left=�6H   $��
314,67,0,0q�6c   $	��Top=�6w   $	��128��6�   6�   5      5      