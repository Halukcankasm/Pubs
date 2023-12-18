using Pubs.Model;
using SQLDBHelper;
using System;using System.Collections.Generic;
using System.Collections.ObjectModel;using System.Data;using System.Data.SqlClient;using System.Linq;
using MessageBox = System.Windows.MessageBox;namespace Pubs.ViewModel{	public class TitlesVM	{

		#region Properties		private SqlConnection cnn;

		public ObservableCollection<Titles> titlesList;
		#endregion Properties
		public TitlesVM()
		{
			titlesList = new ObservableCollection<Titles>();
		}

		public ObservableCollection<Titles> GetAlltitles()
		{
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[sel_titles]";
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Titles titles = new Titles();

					titles.Title_id = SqlHelper.GetNullableString(dr, "title_id");
					titles.Title = SqlHelper.GetNullableString(dr, "title");
					titles.Type = String.Concat(SqlHelper.GetNullableString(dr, "type").Where(c => !Char.IsWhiteSpace(c))); 
					titles.Pub_id = SqlHelper.GetNullableString(dr, "pub_id");
					titles.Price = SqlHelper.GetNullableDecimal(dr, "price");
					titles.Advance = SqlHelper.GetNullableDecimal(dr, "advance");
					titles.Royalty = SqlHelper.GetNullableInt(dr, "royalty");
					titles.Ytd_sales = SqlHelper.GetNullableInt(dr, "ytd_sales");
					titles.Notes = SqlHelper.GetNullableString(dr, "notes");
					titles.Pubdate = dr.GetDateTime(dr.GetOrdinal("pubdate"));
					titlesList.Add(titles);
				}
				cnn.Close();
			}
			return titlesList;
		}


		public List<AuthorsFilter> SelectAuthorsFilter()
		{
			List<AuthorsFilter> authorsFilters = new List<AuthorsFilter>();
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[sel_Authors]";
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					AuthorsFilter authors = new AuthorsFilter();

					authors.Au_id = SqlHelper.GetNullableString(dr, "au_id");
					authors.Au_name = SqlHelper.GetNullableString(dr, "au_name");
					authorsFilters.Add(authors);
				}
				cnn.Close();
			}
			return authorsFilters;
		}

        public List<string> SelectTypesOfTittle()
        {
			List<string> typesListOfTittle = new List<string>();
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[sel_TypesOfTittles]";
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					string types = null;

					types = SqlHelper.GetNullableString(dr, "type");
					typesListOfTittle.Add(types);
				}
				cnn.Close();
			}
			return typesListOfTittle;
		}

        public List<Titles> SelectTitlesByCriteria(TitlesFilter titlesFilter)
		{
			List<Titles> tittleCriteriaList = new List<Titles>();
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[sel_TitlesByCriteria]";

				cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = titlesFilter.Type;
                if (titlesFilter.Au == null)
                {
					cmd.Parameters.Add("@au_id", SqlDbType.VarChar).Value = null;
				}
                else
                {
					cmd.Parameters.Add("@au_id", SqlDbType.VarChar).Value = titlesFilter.Au.Au_id;
				}				

				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Titles titles = new Titles();

					titles.Title_id = SqlHelper.GetNullableString(dr, "title_id");
					titles.Title = SqlHelper.GetNullableString(dr, "title");
					titles.Type = String.Concat(SqlHelper.GetNullableString(dr, "type").Where(c => !Char.IsWhiteSpace(c)));
					titles.Pub_id = SqlHelper.GetNullableString(dr, "pub_id");
					titles.Price = SqlHelper.GetNullableDecimal(dr, "price");
					titles.Advance = SqlHelper.GetNullableDecimal(dr, "advance");
					titles.Royalty = SqlHelper.GetNullableInt(dr, "royalty");
					titles.Ytd_sales = SqlHelper.GetNullableInt(dr, "ytd_sales");
					titles.Notes = SqlHelper.GetNullableString(dr, "notes");
					titles.Pubdate = dr.GetDateTime(dr.GetOrdinal("pubdate"));
					tittleCriteriaList.Add(titles);
				}
				cnn.Close();
			}
			return tittleCriteriaList;
		}


		public void Inserttitles(Titles titles)
		{
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[ins_titles]";

				cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = titles.Title;
				cmd.Parameters.Add("@type", SqlDbType.Char).Value = titles.Type;
				cmd.Parameters.Add("@pub_id", SqlDbType.Char).Value = titles.Pub_id;
				cmd.Parameters.Add("@price", SqlDbType.Money).Value = titles.Price;
				cmd.Parameters.Add("@advance", SqlDbType.Money).Value = titles.Advance;
				cmd.Parameters.Add("@royalty", SqlDbType.Int).Value = titles.Royalty;
				cmd.Parameters.Add("@ytd_sales", SqlDbType.Int).Value = titles.Ytd_sales;
				cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = titles.Notes;
				cmd.Parameters.Add("@pubdate", SqlDbType.DateTime).Value = titles.Pubdate;
				var result = cmd.ExecuteNonQuery();
				cnn.Close();
			}

		}


		public void Deletetitles(int titlesId)
		{
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[del_titles]";
				cmd.Parameters.Add("@titlesId", SqlDbType.Int).Value = titlesId;

				var result = cmd.ExecuteNonQuery();
				cnn.Close();
			}
		}
		public void Updatetitles(Titles titles)
		{
			OpenDatabase();
			if (cnn.State == ConnectionState.Open)
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cnn;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "[dbo].[upd_titles]";

				cmd.Parameters.Add("@title_id", SqlDbType.VarChar).Value = titles.Title_id;
				cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = titles.Title;
				cmd.Parameters.Add("@type", SqlDbType.Char).Value = titles.Type;
				cmd.Parameters.Add("@pub_id", SqlDbType.Char).Value = titles.Pub_id;
				cmd.Parameters.Add("@price", SqlDbType.Money).Value = titles.Price;
				cmd.Parameters.Add("@advance", SqlDbType.Money).Value = titles.Advance;
				cmd.Parameters.Add("@royalty", SqlDbType.Int).Value = titles.Royalty;
				cmd.Parameters.Add("@ytd_sales", SqlDbType.Int).Value = titles.Ytd_sales;
				cmd.Parameters.Add("@notes", SqlDbType.VarChar).Value = titles.Notes;
				cmd.Parameters.Add("@pubdate", SqlDbType.DateTime).Value = titles.Pubdate;
				var result = cmd.ExecuteNonQuery();
				cnn.Close();
			}
		}


		public void OpenDatabase()
		{
			try
			{
				cnn = new SqlConnection("server=LAPTOP-S65PUQCG\\SQLEXPRESS01; database=pubs; integrated security=true");
				cnn.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Database bağlanırken sorun oluştu!.\n{ex.Message}", "Error");
			}
		}
	}}