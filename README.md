


# PUBS DESKTOP APPLİCATİON 
> WPF

This applicatin is desktop application with WPF who has four liblary ;

## Liblaries

- WindowsBase.
- PresentationFramework
- PresentationCore
- System

and my costem liblary for connection database or select,update,delete,insert data from sql.

## Code Generate
Code Generate is desktop app for create model or view model to WPF application. This app is helpful when create desktop application.

https://github.com/Halukcankasm/Pubs/assets/65433322/0547e318-1d2d-41d6-a4ff-76d08f332b0d

https://github.com/Halukcankasm/CodeGenerate

When run this app , connection database and create model and view model with parameter. Gived the parameter(select the database, select the table) after run the sql script 
for  insert, update, delete, select  stored prosedure. After create a model for table.

For example Employee. 
Created the model for Employe Table.
Create the Insert,Update,Select,Delete sp for Employe Table(EmployeVM).

## Custom Liblaries 

- SQLDBHelper.
- UIControl

##  SQLDBHelper:
>It is helpful when give a data from database. CCheck the data for nullable.

ForExample:

		public List<Authors> SelectAllauthors()
		{
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[sel_authorsT]";
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Authors authors = new Authors();

					authors.Au_id = SqlHelper.GetNullableString(dr, "au_id");
					authors.Au_lname = SqlHelper.GetNullableString(dr, "au_lname");
					authors.Au_fname = SqlHelper.GetNullableString(dr, "au_fname");
					authors.Phone = SqlHelper.GetNullableString(dr, "phone");
					authors.Address = SqlHelper.GetNullableString(dr, "address");
					authors.City = SqlHelper.GetNullableString(dr, "city");
					authors.State = SqlHelper.GetNullableString(dr, "state");
					authors.Zip = SqlHelper.GetNullableString(dr, "zip");
					authors.Contract = dr.GetBoolean(dr.GetOrdinal("contract"));
					authorsList.Add(authors);
				}
				return authorsList;
			}
			return null;
		}

##
        namespace SQLDBHelper
        {
            public static class SqlHelper
            {
                public static byte? GetNullableByte(SqlDataReader dr, string columnName);
                public static byte[] GetNullableByteArray(SqlDataReader dr, string columnName);
                public static DateTime? GetNullableDateTime(SqlDataReader dr, string columnName);
                public static decimal? GetNullableDecimal(SqlDataReader dr, string columnName);
                public static int? GetNullableInt(SqlDataReader dr, string columnName);
                public static short? GetNullableInt16(SqlDataReader dr, string columnName);
                public static string GetNullableString(SqlDataReader dr, string columnName);
                public static SqlConnection OpenDatabase();
            }
        }



##  UIControl:
>It has got a costem UIElemet for WPF.ForExample UIDataGrid

    <UserControl x:Class="Pubs.Source.CustomControls.UserControls.UserControlFilterPage"
                 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                 xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
                 xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
                 xmlns:local="clr-namespace:Pubs.Source.CustomControls.UserControls"
                 x:Name="CodeBehind"
                 DataContext="{Binding ElementName=CodeBehind}"
                 xmlns:UIControl="clr-namespace:UIControl;assembly=UIControl"
                 Loaded="CodeBehind_Loaded"
                 mc:Ignorable="d" 
                 d:DesignHeight="450" d:DesignWidth="800">
        <Grid>
        .
        .
        .
        .
            <Grid x:Name="dataAArea"  Grid.Column="2"  Background="White"   VerticalAlignment="Stretch"  HorizontalAlignment="Stretch" >
                <UIControl:UIDataGrid  ItemsSource="{Binding ElementName=CodeBehind, Path=GridItemSource, Mode=TwoWay}" Width="Auto" ></UIControl:UIDataGrid>
            </Grid>
        </Grid>
    </UserControl>

this data grid custom data grid , when focus or update the data , change bacground row bacground color. And has different style then base data grid.

![ChangeBacgroundGrid](https://github.com/Halukcankasm/Pubs/assets/65433322/cf9d0482-2b22-435f-8215-5f8eba4b6b1c)

and a filter page

    <Page x:Class="Pubs.View.Employee"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
          xmlns:local="clr-namespace:Pubs.View"
          xmlns:uc="clr-namespace:Pubs.Source.CustomControls.UserControls"      
          xmlns:UIControl="clr-namespace:UIControl;assembly=UIControl"
          mc:Ignorable="d" 
          d:DesignHeight="450" d:DesignWidth="800"
          x:Name="CodeBehind"
          DataContext="{Binding ElementName=CodeBehind}"
          Loaded="CodeBehind_Loaded"
          Title="Employee">

    <Grid Background="Transparent">        
        <uc:UserControlFilterPage GridItemSource="{Binding ElementName=CodeBehind, Path=EmployeDetailList, Mode=TwoWay}"  >

            <uc:UserControlFilterPage.Kriteria>
                <StackPanel Orientation="Horizontal" Margin="5" Height="Auto" VerticalAlignment="Top"  >
                    <Label  Content="Name"  Width="50"  />
                    <TextBox Width="100" Background="White" Height="{Binding (StackPanel.Height), RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type ListViewItem}}}" TextChanged="kriteriaNameChanged"/>
                </StackPanel>
            </uc:UserControlFilterPage.Kriteria>           


https://github.com/Halukcankasm/Pubs/assets/65433322/3c594d94-2d94-46d4-a9e0-371a2f7f87ad





##  OutPut the Pubs Desktop App:

https://github.com/Halukcankasm/Pubs/assets/65433322/543f17e3-fc53-4469-bfb8-66c3c0f1141e













