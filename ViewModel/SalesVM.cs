using SQLDBHelper;
using System;
using System.Collections.ObjectModel;


		public List<SalesDetail> GetSalesDetailWithColumn(SalesCriteria salesCriteria)
				cmd.Parameters.Add("@ord_date", SqlDbType.DateTime).Value = salesCriteria.Ord_date;
				cmd.Parameters.Add("@stor_name", SqlDbType.VarChar).Value = salesCriteria.Str_name;
				cmd.Parameters.Add("@title_type", SqlDbType.VarChar).Value = salesCriteria.Title_type;
				SqlDataReader dr = cmd.ExecuteReader();

		public List<string> SelectStoreNames()
		{
			var StoresNames = new List<string>();
				SqlDataReader dr = cmd.ExecuteReader();
		}

		public void InsertSales(Sales sales)