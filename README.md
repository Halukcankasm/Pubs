


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


##  Custom Components
When creating custom components, it is important where and how intensively they are used. For example, if a data grid will be used everywhere in the application and the application does not consist of a single solution, if it will be used in libraries that exist in multiple solutions that are referenced, it will be easier to use these custom components by creating them in a library and referencing the libraries to be used. For example;

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/7d3424ea-4281-43bc-a481-0afbbf20ba6a)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/2389f971-0a13-44a7-9190-728b69a042fe)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/dfc37a07-344d-4621-8944-240b9a2b5d0e)

In this example, as an example, we created a class for a custom data grid in a class library, derived the class from the datagrid class and customized it with styler on the UI side. In this class derived from DataGrid, if the style was not edited, it would have taken the style of Data Grid as the base, but here we defined the style of the custom datagrid using Resource Dicitionary.

Resource Dictionary is a XAML page where styles are defined and used to build the application. If you want to customize an existing component and want to use that style everywhere, you can use Resource Dictionary. 

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/9eb5bf18-5264-4687-bf47-f167dc619177)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/f39d8f4b-50e2-4f17-880e-dbbe798542e9)

With both examples we have customized the components in the UI, one of the different ones can be done with UserControl. 
UserControl can be integrated as desired by creating custom components and using it in the solution.

With both examples we have customized the components in the UI, one of the different ones can be done with UserControl. UserControl can be integrated as desired by creating custom components and using it in the solution.

For example, if we make a filtering page as UserPage:

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/bfeae871-cc00-4827-af6b-04c6cda4f456)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/8d233331-1eb0-4fd6-8595-8da26076406e)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/05fe0c9e-e4fa-4832-b886-480c577fc7bb)

the created page is a custom page created by combining multiple components.

New DependencyProperties have been created in the custom components here, DependencyProperties have been added to the poreperty to use the binding property of the property to be used via UI. In the existing component, if there is a need for one more property, what needs to be done is to create a new Dependency Property. For example, in ComboBoxes, when you want the "All" option to be added to the item list as the first item default, you can do this by defining a DepencyProperty. 
For example;

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/5b1c7ccf-4788-4013-a94e-b34f03f7e41b)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/dda9ad2d-d465-4ee3-bb8f-f38e7a1ce3d9)

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/3294c67c-4379-4d17-9dad-747fb155635b)

And also by making arrangements with the style of the special ComBox, we made arrangements in the ItemTemplate of the ComboBox and arranged the display of 2 objects. 

Like ; 

![image](https://github.com/Halukcankasm/Pubs/assets/65433322/95df8200-2b34-4e4c-8dde-19af651dd8e4)


##  OutPut the Pubs Desktop App:


##  Gift 
![SalesGift](https://github.com/Halukcankasm/Pubs/assets/65433322/5bcd4d0a-98f7-4433-993c-822068050a26)
![EmployeeGift](https://github.com/Halukcankasm/Pubs/assets/65433322/0c500355-7ad1-46d2-8ebc-614d4c38b495)

##  Video 
https://github.com/Halukcankasm/Pubs/assets/65433322/d9264ff7-555e-45d9-9c2f-2abc64d03d5f








