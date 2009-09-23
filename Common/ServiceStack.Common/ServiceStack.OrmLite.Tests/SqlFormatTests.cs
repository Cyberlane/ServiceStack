using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using ServiceStack.OrmLite.Tests.Models;

namespace ServiceStack.OrmLite.Tests
{
	[TestFixture]
	public class SqlFormatTests
		: OrmLiteTestBase
	{
		[Test]
		public void SqlJoin_joins_int_ids()
		{
			var ids = new List<int> { 1, 2, 3 };
			Assert.That(ids.SqlJoin(), Is.EqualTo("1,2,3"));
		}

		[Test]
		public void SqlJoin_joins_string_ids()
		{
			var ids = new List<string> { "1", "2", "3" };
			Assert.That(ids.SqlJoin(), Is.EqualTo("'1','2','3'"));
		}

	}
}