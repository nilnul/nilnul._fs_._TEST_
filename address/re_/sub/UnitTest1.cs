using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.fs.address;
using System;
using System.Diagnostics;

namespace nilnul._fs_._TEST_.address.re_.sub
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var a = @"c:\a\b";
			var aEnded = nilnul.fs.address_.Shield.FroAddress(a);

			var b = nilnul.fs.address_.spear_.ParentDocument.Create_allowParentAddress(a, "c");

			var bEnded= nilnul.fs.address_.Shield.FroAddress(b);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sub.Singleton.Re(
					
					a
					,a
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sup.Singleton.Re(
					
					a
					,a
				)
				,
				""
			);



			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.Re(
					
					a
					,a
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sub_.EndMatters.Singleton.Re(
					
					a
					,a
				)
				,
				""
			);

			

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sub.Singleton.Re(
					a,
					aEnded
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sup.Singleton.Re(
					a,
					aEnded
				)
				,
				""
			);


			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.sub_.EndMatters.Singleton.Re(
					a,
					aEnded
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.Re(
					a,
					aEnded
				)
				,
				""
			);


			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sub.Singleton.Re(
					
					aEnded
					,a
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sub_.EndMatters.Singleton.Re(
					
					aEnded
					,a
				)
				,
				""
			);



			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sup.Singleton.Re(
					
					aEnded
					,a
				)
				,
				""
			);

			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.Re(
					
					aEnded
					,a
				)
				,
				""
			);


			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.Re(
					
					a
					,b
				)
				,
				""
			);


			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.sub_.EndMatters.Singleton.Re(
					
					a
					,b
				)
				,
				""
			);


			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sup.Singleton.Re(
					
					a
					,b
				)
				,
				""
			);

			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.Sub.Singleton.Re(
					
					a
					,b
				)
				,
				""
			);

			#region MyRegion


			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.Re(
					
					b,a
				)
				,
				""
			);


			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.sub_.EndMatters.Singleton.Re(
					
					b,a
				)
				,
				""
			);


			nilnul.bit.vow_.False.Vow(
				nilnul.fs.address.re_.Sup.Singleton.Re(
					
					b,a
				)
				,
				""
			);

			nilnul.bit.vow_.True1.Vow(
				nilnul.fs.address.re_.Sub.Singleton.Re(
					
					b,a
				)
				,
				""
			);
			#endregion
		}
	}
}
