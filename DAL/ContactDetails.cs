
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _ContactDetails : SqlClientEntity
	{
		public _ContactDetails()
		{
			this.QuerySource = "ContactDetails";
			this.MappingName = "ContactDetails";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ContactDetailsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ContactDetailsID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ContactDetailsID, ContactDetailsID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ContactDetailsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ContactDetailsID
			{
				get
				{
					return new SqlParameter("@ContactDetailsID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Location
			{
				get
				{
					return new SqlParameter("@Location", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter Email
			{
				get
				{
					return new SqlParameter("@Email", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter Facebook
			{
				get
				{
					return new SqlParameter("@Facebook", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter Telephone
			{
				get
				{
					return new SqlParameter("@Telephone", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ContactDetailsID = "ContactDetailsID";
            public const string Location = "Location";
            public const string Email = "Email";
            public const string Facebook = "Facebook";
            public const string Description = "Description";
            public const string Telephone = "Telephone";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ContactDetailsID] = _ContactDetails.PropertyNames.ContactDetailsID;
					ht[Location] = _ContactDetails.PropertyNames.Location;
					ht[Email] = _ContactDetails.PropertyNames.Email;
					ht[Facebook] = _ContactDetails.PropertyNames.Facebook;
					ht[Description] = _ContactDetails.PropertyNames.Description;
					ht[Telephone] = _ContactDetails.PropertyNames.Telephone;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ContactDetailsID = "ContactDetailsID";
            public const string Location = "Location";
            public const string Email = "Email";
            public const string Facebook = "Facebook";
            public const string Description = "Description";
            public const string Telephone = "Telephone";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ContactDetailsID] = _ContactDetails.ColumnNames.ContactDetailsID;
					ht[Location] = _ContactDetails.ColumnNames.Location;
					ht[Email] = _ContactDetails.ColumnNames.Email;
					ht[Facebook] = _ContactDetails.ColumnNames.Facebook;
					ht[Description] = _ContactDetails.ColumnNames.Description;
					ht[Telephone] = _ContactDetails.ColumnNames.Telephone;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ContactDetailsID = "s_ContactDetailsID";
            public const string Location = "s_Location";
            public const string Email = "s_Email";
            public const string Facebook = "s_Facebook";
            public const string Description = "s_Description";
            public const string Telephone = "s_Telephone";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ContactDetailsID
	    {
			get
	        {
				return base.Getint(ColumnNames.ContactDetailsID);
			}
			set
	        {
				base.Setint(ColumnNames.ContactDetailsID, value);
			}
		}

		public virtual string Location
	    {
			get
	        {
				return base.Getstring(ColumnNames.Location);
			}
			set
	        {
				base.Setstring(ColumnNames.Location, value);
			}
		}

		public virtual string Email
	    {
			get
	        {
				return base.Getstring(ColumnNames.Email);
			}
			set
	        {
				base.Setstring(ColumnNames.Email, value);
			}
		}

		public virtual string Facebook
	    {
			get
	        {
				return base.Getstring(ColumnNames.Facebook);
			}
			set
	        {
				base.Setstring(ColumnNames.Facebook, value);
			}
		}

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual string Telephone
	    {
			get
	        {
				return base.Getstring(ColumnNames.Telephone);
			}
			set
	        {
				base.Setstring(ColumnNames.Telephone, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ContactDetailsID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ContactDetailsID) ? string.Empty : base.GetintAsString(ColumnNames.ContactDetailsID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ContactDetailsID);
				else
					this.ContactDetailsID = base.SetintAsString(ColumnNames.ContactDetailsID, value);
			}
		}

		public virtual string s_Location
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Location) ? string.Empty : base.GetstringAsString(ColumnNames.Location);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Location);
				else
					this.Location = base.SetstringAsString(ColumnNames.Location, value);
			}
		}

		public virtual string s_Email
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Email) ? string.Empty : base.GetstringAsString(ColumnNames.Email);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Email);
				else
					this.Email = base.SetstringAsString(ColumnNames.Email, value);
			}
		}

		public virtual string s_Facebook
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Facebook) ? string.Empty : base.GetstringAsString(ColumnNames.Facebook);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Facebook);
				else
					this.Facebook = base.SetstringAsString(ColumnNames.Facebook, value);
			}
		}

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_Telephone
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Telephone) ? string.Empty : base.GetstringAsString(ColumnNames.Telephone);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Telephone);
				else
					this.Telephone = base.SetstringAsString(ColumnNames.Telephone, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ContactDetailsID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ContactDetailsID, Parameters.ContactDetailsID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Location
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Location, Parameters.Location);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Facebook
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Facebook, Parameters.Facebook);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Telephone
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Telephone, Parameters.Telephone);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ContactDetailsID
		    {
				get
		        {
					if(_ContactDetailsID_W == null)
	        	    {
						_ContactDetailsID_W = TearOff.ContactDetailsID;
					}
					return _ContactDetailsID_W;
				}
			}

			public WhereParameter Location
		    {
				get
		        {
					if(_Location_W == null)
	        	    {
						_Location_W = TearOff.Location;
					}
					return _Location_W;
				}
			}

			public WhereParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			public WhereParameter Facebook
		    {
				get
		        {
					if(_Facebook_W == null)
	        	    {
						_Facebook_W = TearOff.Facebook;
					}
					return _Facebook_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter Telephone
		    {
				get
		        {
					if(_Telephone_W == null)
	        	    {
						_Telephone_W = TearOff.Telephone;
					}
					return _Telephone_W;
				}
			}

			private WhereParameter _ContactDetailsID_W = null;
			private WhereParameter _Location_W = null;
			private WhereParameter _Email_W = null;
			private WhereParameter _Facebook_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _Telephone_W = null;

			public void WhereClauseReset()
			{
				_ContactDetailsID_W = null;
				_Location_W = null;
				_Email_W = null;
				_Facebook_W = null;
				_Description_W = null;
				_Telephone_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ContactDetailsID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ContactDetailsID, Parameters.ContactDetailsID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Location
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Location, Parameters.Location);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Facebook
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Facebook, Parameters.Facebook);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Telephone
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Telephone, Parameters.Telephone);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ContactDetailsID
		    {
				get
		        {
					if(_ContactDetailsID_W == null)
	        	    {
						_ContactDetailsID_W = TearOff.ContactDetailsID;
					}
					return _ContactDetailsID_W;
				}
			}

			public AggregateParameter Location
		    {
				get
		        {
					if(_Location_W == null)
	        	    {
						_Location_W = TearOff.Location;
					}
					return _Location_W;
				}
			}

			public AggregateParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			public AggregateParameter Facebook
		    {
				get
		        {
					if(_Facebook_W == null)
	        	    {
						_Facebook_W = TearOff.Facebook;
					}
					return _Facebook_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter Telephone
		    {
				get
		        {
					if(_Telephone_W == null)
	        	    {
						_Telephone_W = TearOff.Telephone;
					}
					return _Telephone_W;
				}
			}

			private AggregateParameter _ContactDetailsID_W = null;
			private AggregateParameter _Location_W = null;
			private AggregateParameter _Email_W = null;
			private AggregateParameter _Facebook_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _Telephone_W = null;

			public void AggregateClauseReset()
			{
				_ContactDetailsID_W = null;
				_Location_W = null;
				_Email_W = null;
				_Facebook_W = null;
				_Description_W = null;
				_Telephone_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ContactDetailsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ContactDetailsID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ContactDetailsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ContactDetailsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ContactDetailsID);
			p.SourceColumn = ColumnNames.ContactDetailsID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ContactDetailsID);
			p.SourceColumn = ColumnNames.ContactDetailsID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Location);
			p.SourceColumn = ColumnNames.Location;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Email);
			p.SourceColumn = ColumnNames.Email;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Facebook);
			p.SourceColumn = ColumnNames.Facebook;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Telephone);
			p.SourceColumn = ColumnNames.Telephone;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
