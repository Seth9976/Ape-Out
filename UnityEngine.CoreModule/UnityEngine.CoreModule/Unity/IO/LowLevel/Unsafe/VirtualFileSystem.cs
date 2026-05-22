using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x020001CE RID: 462
	public static class VirtualFileSystem
	{
		// Token: 0x06001FFD RID: 8189 RVA: 0x0007408C File Offset: 0x0007228C
		public unsafe static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize)
		{
			VirtualFileSystem.GetLocalFileSystemNameDelegate getLocalFileSystemNameDelegateField = VirtualFileSystem.GetLocalFileSystemNameDelegateField;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(vfsFileName);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(localFileName);
			return getLocalFileSystemNameDelegateField(intPtr, &intPtr2, out localFileOffset, out localFileSize);
		}

		// Token: 0x04001A15 RID: 6677
		private static readonly VirtualFileSystem.GetLocalFileSystemNameDelegate GetLocalFileSystemNameDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.GetLocalFileSystemNameDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName");

		// Token: 0x02000ABF RID: 2751
		// (Invoke) Token: 0x060033E2 RID: 13282
		private delegate bool GetLocalFileSystemNameDelegate(IntPtr vfsFileName, [Out] IntPtr localFileName, [Out] IntPtr localFileOffset, [Out] IntPtr localFileSize);
	}
}
