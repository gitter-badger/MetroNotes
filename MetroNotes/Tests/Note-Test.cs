using MetroNotes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MetroNotes.Test
{
	/// <summary>
	/// A test class for Data.Note
	/// </summary>
	[TestFixture]
	public class Note_Test
	{
		#region Setup and Tear down
		/// <summary>
		/// This runs only once at the beginning of all tests and is used for all tests in the 
		/// class.
		/// </summary>
		[TestFixtureSetUp]
		public void InitialSetup()
		{

		}

		/// <summary>
		/// This runs only once at the end of all tests and is used for all tests in the class.
		/// </summary>
		[TestFixtureTearDown]
		public void FinalTearDown()
		{

		}

		/// <summary>
		/// This setup funcitons runs before each test method
		/// </summary>
		[SetUp]
		public void SetupForEachTest()
		{
		}

		/// <summary>
		/// This setup funcitons runs after each test method
		/// </summary>
		[TearDown]
		public void TearDownForEachTest()
		{
		}
		#endregion

		[Test]
		public void ShouldHaveATitleProperty()
		{
			// Step 1 - Arrange
			var n = new Note();
			// Step 2 - Act
			n.Title = "A Title";
			// Step 3 - Assert  
			Assert.AreEqual("A Title", n.Title);
		}
	}
}
