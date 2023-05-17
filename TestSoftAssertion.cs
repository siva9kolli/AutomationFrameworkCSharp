using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class TestSoftAssertion
{
	private SoftAssertions _softAssertions;

	[TestInitialize]
	public void SetUp()
	{
		_softAssertions = new SoftAssertions();
	}

	[TestCleanup]
	public void TearDown()
	{
		_softAssertions.AssertAll();
	}

	[TestMethod]
	public void TestMixedSoftAssertions()
	{
		_softAssertions.Add("Passing bool Add assertion", true, true);
		_softAssertions.Add("Failing bool Add assertion", true, false);
		_softAssertions
			.Add("Passing string Add assertion", "SameString", "SameString");
		_softAssertions
			.Add("Failing string Add assertion", "SameString", "OtherString");
		_softAssertions.Add("Passing int Add assertion", 1, 1);
		_softAssertions.Add("Failing int Add assertion", 1, 2);
		_softAssertions.AddTrue("Passing AddTrue assertion", true);
		_softAssertions.AddTrue("Failing AddTrue assertion", false);
	}
}