using Pubs.Model;
using SQLDBHelper;
using System;
using System.Collections.ObjectModel;
		#region Properties

		#endregion Properties
		public AuthorsVM()
				SqlDataReader dr = cmd.ExecuteReader();
					authorsList.Add(authors);
				return authorsList;
			return null;

				cmd.Parameters.Add("@au_id", SqlDbType.VarChar).Value = authors.Au_id;
				cmd.Parameters.Add("@authorsId", SqlDbType.Int).Value = authorsId;

				var result = cmd.ExecuteNonQuery();

				cmd.Parameters.Add("@au_id", SqlDbType.VarChar).Value = authors.Au_id;