namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb8012d4-d04a-41b4-af91-37ee1cd8c5ab");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8bad2f9f-6b3f-4fb4-b0eb-a6c755b6b05b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,189,23,232,63,16,198,14,54,16,8,237,181,221,10,44,65,54,20,40,186,161,113,119,25,118,80,100,198,213,32,75,134,40,167,77,135,254,251,40,203,105,82,187,3,246,46,178,200,199,39,62,154,86,54,72,173,84,8,37,122,47,201,109,130,88,56,187,209,117,231,101,208,206,158,158,252,57,61,1,70,71,218,214,176,218,81,192,230,242,56,116,92,216,52,206,254,51,233,81,44,109,208,65,35,253,15,71,44,183,104,67,164,38,242,207,62,177,235,163,55,154,219,176,232,243,149,122,192,70,222,178,11,248,4,217,61,249,59,148,38,236,178,226,87,42,106,187,181,209,10,148,145,68,144,114,239,200,192,5,204,37,225,59,153,164,50,140,224,72,208,109,185,105,93,33,108,157,174,224,155,93,201,45,91,201,221,250,55,170,0,132,182,66,63,131,36,56,199,13,251,234,101,63,251,154,0,139,131,220,145,114,196,154,187,16,175,106,123,25,44,46,223,210,146,46,248,222,15,27,207,83,160,72,5,35,114,133,74,55,210,64,235,181,138,83,74,85,226,43,134,114,215,98,181,112,166,107,236,15,105,58,252,56,80,175,242,56,201,239,145,159,21,175,243,223,67,111,32,79,90,87,112,126,182,71,241,150,52,242,21,129,226,154,22,210,42,52,88,113,27,193,119,56,209,142,160,224,227,86,240,94,146,172,177,196,166,53,50,196,198,45,62,194,141,83,210,232,103,185,54,184,234,121,249,96,231,158,208,243,226,90,30,63,111,173,184,67,114,157,87,76,114,158,85,102,211,103,34,14,11,147,118,45,155,65,54,121,129,68,63,156,107,42,157,155,235,58,221,178,66,148,110,232,96,58,162,169,13,110,63,5,196,23,231,27,25,242,145,61,126,248,92,156,205,63,100,227,95,29,17,30,188,123,236,237,47,159,20,182,209,224,190,126,76,127,57,92,135,79,62,94,254,2,1,33,89,237,230,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5782708b-7787-696e-41f5-5d733b2fe4bb"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8bad2f9f-6b3f-4fb4-b0eb-a6c755b6b05b"),
				CreatedInSchemaUId = new Guid("eb8012d4-d04a-41b4-af91-37ee1cd8c5ab"),
				ModifiedInSchemaUId = new Guid("eb8012d4-d04a-41b4-af91-37ee1cd8c5ab")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb8012d4-d04a-41b4-af91-37ee1cd8c5ab"));
		}

		#endregion

	}

	#endregion

}

