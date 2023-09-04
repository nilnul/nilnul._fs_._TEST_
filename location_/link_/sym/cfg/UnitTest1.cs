using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._fs_._TEST_.location_.link_.sym.cfg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
/*docs.microsoft.com/en-us/archive/blogs/junfeng/the-symbolic-link-cannot-be-followed-because-its-type-is-disabled
The symbolic link cannot be followed because its type is disabled
Article
05/07/2012
2 minutes to read
When access a symbolic link on a file server, sometimes you may see the following error:

"The symbolic link cannot be followed because its type is disabled"

This is because by default remote to remote symbolic links are disabled. You can enable it with fsutil.

C:\Windows\system32>fsutil behavior query SymlinkEvaluation

Local to local symbolic links are enabled.
Local to remote symbolic links are enabled.
Remote to local symbolic links are disabled.
Remote to remote symbolic links are disabled.

C:\Windows\system32>fsutil behavior set SymlinkEvaluation R2R:1

C:\Windows\system32>fsutil behavior query SymlinkEvaluation

Local to local symbolic links are enabled.
Local to remote symbolic links are enabled.
Remote to local symbolic links are disabled.
Remote to remote symbolic links are enabled.

Be sure to run fsutil from elevated command prompt.
*/