﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace OracleDataContext
{
	/// <summary>
	/// Database       : testdata
	/// Data Source    : dbhost
	/// Server Version : 11.2.0.1.0
	/// </summary>
	public partial class testdataDB : LinqToDB.Data.DataConnection
	{
		public ITable<ALLTYPE>               ALLTYPES              { get { return this.GetTable<ALLTYPE>(); } }
		public ITable<BINARYDATA>            BINARYDATAs           { get { return this.GetTable<BINARYDATA>(); } }
		public ITable<CHILD>                 Children              { get { return this.GetTable<CHILD>(); } }
		public ITable<DATATYPETEST>          DATATYPETESTs         { get { return this.GetTable<DATATYPETEST>(); } }
		public ITable<DOCTOR>                DOCTORs               { get { return this.GetTable<DOCTOR>(); } }
		public ITable<GRANDCHILD>            GRANDCHILDs           { get { return this.GetTable<GRANDCHILD>(); } }
		public ITable<LINQDATATYPE>          LINQDATATYPES         { get { return this.GetTable<LINQDATATYPE>(); } }
		public ITable<PARENT>                PARENTs               { get { return this.GetTable<PARENT>(); } }
		public ITable<PATIENT>               PATIENTs              { get { return this.GetTable<PATIENT>(); } }
		public ITable<PERSON>                People                { get { return this.GetTable<PERSON>(); } }
		public ITable<SEQUENCETEST>          SEQUENCETESTs         { get { return this.GetTable<SEQUENCETEST>(); } }
		public ITable<STG_TRADE_INFORMATION> STG_TRADE_INFORMATION { get { return this.GetTable<STG_TRADE_INFORMATION>(); } }
		public ITable<T_TEST_USER>           T_TEST_USER           { get { return this.GetTable<T_TEST_USER>(); } }
		public ITable<T_TEST_USER_CONTRACT>  T_TEST_USER_CONTRACT  { get { return this.GetTable<T_TEST_USER_CONTRACT>(); } }
		public ITable<TESTIDENTITY>          TESTIDENTITies        { get { return this.GetTable<TESTIDENTITY>(); } }

		public testdataDB()
		{
		}

		public testdataDB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table(Schema="TESTUSER", Name="ALLTYPES")]
	public partial class ALLTYPE
	{
		[PrimaryKey, NotNull    ] public decimal         ID                     { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        BIGINTDATATYPE         { get; set; } // NUMBER (20,0)
		[Column,        Nullable] public decimal?        NUMERICDATATYPE        { get; set; } // NUMBER
		[Column,        Nullable] public sbyte?          BITDATATYPE            { get; set; } // NUMBER (1,0)
		[Column,        Nullable] public int?            SMALLINTDATATYPE       { get; set; } // NUMBER (5,0)
		[Column,        Nullable] public decimal?        DECIMALDATATYPE        { get; set; } // NUMBER
		[Column,        Nullable] public decimal?        SMALLMONEYDATATYPE     { get; set; } // NUMBER (10,4)
		[Column,        Nullable] public long?           INTDATATYPE            { get; set; } // NUMBER (10,0)
		[Column,        Nullable] public short?          TINYINTDATATYPE        { get; set; } // NUMBER (3,0)
		[Column,        Nullable] public decimal?        MONEYDATATYPE          { get; set; } // NUMBER
		[Column,        Nullable] public double?         FLOATDATATYPE          { get; set; } // BINARY_DOUBLE
		[Column,        Nullable] public float?          REALDATATYPE           { get; set; } // BINARY_FLOAT
		[Column,        Nullable] public DateTime?       DATETIMEDATATYPE       { get; set; } // DATE
		[Column,        Nullable] public DateTime?       DATETIME2DATATYPE      { get; set; } // TIMESTAMP(6)
		[Column,        Nullable] public DateTimeOffset? DATETIMEOFFSETDATATYPE { get; set; } // TIMESTAMP(6) WITH TIME ZONE
		[Column,        Nullable] public DateTimeOffset? LOCALZONEDATATYPE      { get; set; } // TIMESTAMP(6) WITH LOCAL TIME ZONE
		[Column,        Nullable] public string          CHARDATATYPE           { get; set; } // CHAR(1)
		[Column,        Nullable] public string          VARCHARDATATYPE        { get; set; } // VARCHAR2(20)
		[Column,        Nullable] public string          TEXTDATATYPE           { get; set; } // CLOB
		[Column,        Nullable] public string          NCHARDATATYPE          { get; set; } // NCHAR(40)
		[Column,        Nullable] public string          NVARCHARDATATYPE       { get; set; } // NVARCHAR2(40)
		[Column,        Nullable] public string          NTEXTDATATYPE          { get; set; } // NCLOB
		[Column,        Nullable] public byte[]          BINARYDATATYPE         { get; set; } // BLOB
		[Column,        Nullable] public byte[]          BFILEDATATYPE          { get; set; } // BFILE
		[Column,        Nullable] public byte[]          GUIDDATATYPE           { get; set; } // RAW(16)
		[Column,        Nullable] public object          URIDATATYPE            { get; set; } // URITYPE
		[Column,        Nullable] public string          XMLDATATYPE            { get; set; } // XMLTYPE
	}

	[Table(Schema="TESTUSER", Name="BINARYDATA")]
	public partial class BINARYDATA
	{
		[PrimaryKey, NotNull] public decimal  BINARYDATAID { get; set; } // NUMBER
		[Column,     NotNull] public DateTime STAMP        { get; set; } // TIMESTAMP(6)
		[Column,     NotNull] public byte[]   DATA         { get; set; } // BLOB
	}

	[Table(Schema="TESTUSER", Name="CHILD")]
	public partial class CHILD
	{
		[Column, Nullable] public decimal? PARENTID { get; set; } // NUMBER
		[Column, Nullable] public decimal? CHILDID  { get; set; } // NUMBER
	}

	[Table(Schema="TESTUSER", Name="DATATYPETEST")]
	public partial class DATATYPETEST
	{
		[PrimaryKey, NotNull    ] public decimal   DATATYPEID { get; set; } // NUMBER
		[Column,        Nullable] public byte[]    BINARY_    { get; set; } // RAW(50)
		[Column,        Nullable] public sbyte?    BOOLEAN_   { get; set; } // NUMBER (1,0)
		[Column,        Nullable] public short?    BYTE_      { get; set; } // NUMBER (3,0)
		[Column,        Nullable] public byte[]    BYTES_     { get; set; } // BLOB
		[Column,        Nullable] public string    CHAR_      { get; set; } // NCHAR(2)
		[Column,        Nullable] public DateTime? DATETIME_  { get; set; } // DATE
		[Column,        Nullable] public decimal?  DECIMAL_   { get; set; } // NUMBER (19,5)
		[Column,        Nullable] public decimal?  DOUBLE_    { get; set; } // FLOAT(126)
		[Column,        Nullable] public byte[]    GUID_      { get; set; } // RAW(16)
		[Column,        Nullable] public int?      INT16_     { get; set; } // NUMBER (5,0)
		[Column,        Nullable] public long?     INT32_     { get; set; } // NUMBER (10,0)
		[Column,        Nullable] public decimal?  INT64_     { get; set; } // NUMBER (20,0)
		[Column,        Nullable] public decimal?  MONEY_     { get; set; } // NUMBER
		[Column,        Nullable] public short?    SBYTE_     { get; set; } // NUMBER (3,0)
		[Column,        Nullable] public decimal?  SINGLE_    { get; set; } // FLOAT(126)
		[Column,        Nullable] public byte[]    STREAM_    { get; set; } // BLOB
		[Column,        Nullable] public string    STRING_    { get; set; } // NVARCHAR2(100)
		[Column,        Nullable] public int?      UINT16_    { get; set; } // NUMBER (5,0)
		[Column,        Nullable] public long?     UINT32_    { get; set; } // NUMBER (10,0)
		[Column,        Nullable] public decimal?  UINT64_    { get; set; } // NUMBER (20,0)
		[Column,        Nullable] public string    XML_       { get; set; } // XMLTYPE
	}

	[Table(Schema="TESTUSER", Name="DOCTOR")]
	public partial class DOCTOR
	{
		[PrimaryKey, NotNull] public decimal PERSONID { get; set; } // NUMBER
		[Column,     NotNull] public string  TAXONOMY { get; set; } // NVARCHAR2(100)

		#region Associations

		/// <summary>
		/// FK_DOCTOR_PERSON
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false)]
		public PERSON PERSON { get; set; }

		#endregion
	}

	[Table(Schema="TESTUSER", Name="GRANDCHILD")]
	public partial class GRANDCHILD
	{
		[Column, Nullable] public decimal? PARENTID     { get; set; } // NUMBER
		[Column, Nullable] public decimal? CHILDID      { get; set; } // NUMBER
		[Column, Nullable] public decimal? GRANDCHILDID { get; set; } // NUMBER
	}

	[Table(Schema="TESTUSER", Name="LINQDATATYPES")]
	public partial class LINQDATATYPE
	{
		[Column, Nullable] public decimal?  ID             { get; set; } // NUMBER
		[Column, Nullable] public decimal?  MONEYVALUE     { get; set; } // NUMBER (10,4)
		[Column, Nullable] public DateTime? DATETIMEVALUE  { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public DateTime? DATETIMEVALUE2 { get; set; } // TIMESTAMP(6)
		[Column, Nullable] public decimal?  BOOLVALUE      { get; set; } // NUMBER
		[Column, Nullable] public byte[]    GUIDVALUE      { get; set; } // RAW(16)
		[Column, Nullable] public byte[]    BINARYVALUE    { get; set; } // BLOB
		[Column, Nullable] public decimal?  SMALLINTVALUE  { get; set; } // NUMBER
		[Column, Nullable] public decimal?  INTVALUE       { get; set; } // NUMBER
		[Column, Nullable] public decimal?  BIGINTVALUE    { get; set; } // NUMBER (20,0)
	}

	[Table(Schema="TESTUSER", Name="PARENT")]
	public partial class PARENT
	{
		[Column, Nullable] public decimal? PARENTID { get; set; } // NUMBER
		[Column, Nullable] public decimal? VALUE1   { get; set; } // NUMBER
	}

	[Table(Schema="TESTUSER", Name="PATIENT")]
	public partial class PATIENT
	{
		[PrimaryKey, NotNull] public decimal PERSONID  { get; set; } // NUMBER
		[Column,     NotNull] public string  DIAGNOSIS { get; set; } // NVARCHAR2(512)

		#region Associations

		/// <summary>
		/// FK_PATIENT_PERSON
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false)]
		public PERSON PERSON { get; set; }

		#endregion
	}

	[Table(Schema="TESTUSER", Name="PERSON")]
	public partial class PERSON
	{
		[PrimaryKey, NotNull    ] public decimal PERSONID   { get; set; } // NUMBER
		[Column,     NotNull    ] public string  FIRSTNAME  { get; set; } // VARCHAR2(50)
		[Column,     NotNull    ] public string  LASTNAME   { get; set; } // VARCHAR2(50)
		[Column,        Nullable] public string  MIDDLENAME { get; set; } // VARCHAR2(50)
		[Column,     NotNull    ] public string  GENDER     { get; set; } // CHAR(1)

		#region Associations

		/// <summary>
		/// FK_DOCTOR_PERSON_BackReference
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false)]
		public DOCTOR DOCTOR { get; set; }

		/// <summary>
		/// FK_PATIENT_PERSON_BackReference
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false)]
		public PATIENT PATIENT { get; set; }

		#endregion
	}

	[Table(Schema="TESTUSER", Name="SEQUENCETEST")]
	public partial class SEQUENCETEST
	{
		[PrimaryKey, NotNull] public decimal ID    { get; set; } // NUMBER
		[Column,     NotNull] public string  VALUE { get; set; } // VARCHAR2(50)
	}

	[Table(Schema="TESTUSER", Name="STG_TRADE_INFORMATION")]
	public partial class STG_TRADE_INFORMATION
	{
		[Column, NotNull    ] public decimal   STG_TRADE_ID          { get; set; } // NUMBER
		[Column, NotNull    ] public decimal   STG_TRADE_VERSION     { get; set; } // NUMBER
		[Column, NotNull    ] public decimal   INFORMATION_TYPE_ID   { get; set; } // NUMBER
		[Column,    Nullable] public string    INFORMATION_TYPE_NAME { get; set; } // VARCHAR2(50)
		[Column,    Nullable] public string    VALUE                 { get; set; } // VARCHAR2(4000)
		[Column,    Nullable] public decimal?  VALUE_AS_INTEGER      { get; set; } // NUMBER
		[Column,    Nullable] public DateTime? VALUE_AS_DATE         { get; set; } // DATE
	}

	[Table(Schema="TESTUSER", Name="T_TEST_USER")]
	public partial class T_TEST_USER
	{
		[PrimaryKey, NotNull] public decimal USER_ID { get; set; } // NUMBER
		[Column,     NotNull] public string  NAME    { get; set; } // VARCHAR2(255)

		#region Associations

		/// <summary>
		/// SYS_C0030240_BackReference
		/// </summary>
		[Association(ThisKey="USER_ID", OtherKey="USER_ID", CanBeNull=false)]
		public IEnumerable<T_TEST_USER_CONTRACT> SYSC0030240 { get; set; }

		#endregion
	}

	[Table(Schema="TESTUSER", Name="T_TEST_USER_CONTRACT")]
	public partial class T_TEST_USER_CONTRACT
	{
		[PrimaryKey, NotNull] public decimal USER_CONTRACT_ID { get; set; } // NUMBER
		[Column,     NotNull] public decimal USER_ID          { get; set; } // NUMBER
		[Column,     NotNull] public decimal CONTRACT_NO      { get; set; } // NUMBER
		[Column,     NotNull] public string  NAME             { get; set; } // VARCHAR2(255)

		#region Associations

		/// <summary>
		/// SYS_C0030240
		/// </summary>
		[Association(ThisKey="USER_ID", OtherKey="USER_ID", CanBeNull=false)]
		public T_TEST_USER SYSC0030240 { get; set; }

		#endregion
	}

	[Table(Schema="TESTUSER", Name="TESTIDENTITY")]
	public partial class TESTIDENTITY
	{
		[PrimaryKey, NotNull] public decimal ID { get; set; } // NUMBER
	}

	public static partial class testdataDBStoredProcedures
	{
		#region PERSON_UPDATE

		public static int PERSON_UPDATE(this DataConnection dataConnection, decimal? PPERSONID, string PFIRSTNAME, string PLASTNAME, string PMIDDLENAME, string PGENDER)
		{
			return dataConnection.ExecuteProc("TESTUSER.PERSON_UPDATE",
				new DataParameter("PPERSONID",   PPERSONID),
				new DataParameter("PFIRSTNAME",  PFIRSTNAME),
				new DataParameter("PLASTNAME",   PLASTNAME),
				new DataParameter("PMIDDLENAME", PMIDDLENAME),
				new DataParameter("PGENDER",     PGENDER));
		}

		#endregion

		#region PERSON_DELETE

		public static int PERSON_DELETE(this DataConnection dataConnection, decimal? PPERSONID)
		{
			return dataConnection.ExecuteProc("TESTUSER.PERSON_DELETE",
				new DataParameter("PPERSONID", PPERSONID));
		}

		#endregion

		#region OUTREFTEST

		public static int OUTREFTEST(this DataConnection dataConnection, decimal? PID, out decimal? POUTPUTID, ref decimal? PINPUTOUTPUTID, string PSTR, out string POUTPUTSTR, ref string PINPUTOUTPUTSTR)
		{
			var ret = dataConnection.ExecuteProc("TESTUSER.OUTREFTEST",
				new DataParameter("PID",             PID),
				new DataParameter("PINPUTOUTPUTID",  PINPUTOUTPUTID)  { Direction = ParameterDirection.InputOutput, Size = 22 },
				new DataParameter("PSTR",            PSTR),
				new DataParameter("PINPUTOUTPUTSTR", PINPUTOUTPUTSTR) { Direction = ParameterDirection.InputOutput });

			POUTPUTID       = Converter.ChangeTypeTo<decimal?>(((IDbDataParameter)dataConnection.Command.Parameters["POUTPUTID"]).      Value);
			PINPUTOUTPUTID  = Converter.ChangeTypeTo<decimal?>(((IDbDataParameter)dataConnection.Command.Parameters["PINPUTOUTPUTID"]). Value);
			POUTPUTSTR      = Converter.ChangeTypeTo<string>  (((IDbDataParameter)dataConnection.Command.Parameters["POUTPUTSTR"]).     Value);
			PINPUTOUTPUTSTR = Converter.ChangeTypeTo<string>  (((IDbDataParameter)dataConnection.Command.Parameters["PINPUTOUTPUTSTR"]).Value);

			return ret;
		}

		#endregion

		#region OUTREFENUMTEST

		public static int OUTREFENUMTEST(this DataConnection dataConnection, string PSTR, out string POUTPUTSTR, ref string PINPUTOUTPUTSTR)
		{
			var ret = dataConnection.ExecuteProc("TESTUSER.OUTREFENUMTEST",
				new DataParameter("PSTR",            PSTR),
				new DataParameter("PINPUTOUTPUTSTR", PINPUTOUTPUTSTR) { Direction = ParameterDirection.InputOutput });

			POUTPUTSTR      = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["POUTPUTSTR"]).     Value);
			PINPUTOUTPUTSTR = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["PINPUTOUTPUTSTR"]).Value);

			return ret;
		}

		#endregion
	}
}
