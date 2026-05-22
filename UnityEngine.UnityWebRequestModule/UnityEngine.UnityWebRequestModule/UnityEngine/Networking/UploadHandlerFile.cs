using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000011 RID: 17
	public sealed class UploadHandlerFile : UploadHandler
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00002723 File Offset: 0x00000923
		public static IntPtr Create(UploadHandlerFile self, string filePath)
		{
			return UploadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(filePath));
		}

		// Token: 0x040000A4 RID: 164
		private static readonly UploadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<UploadHandlerFile.CreateDelegate>("UnityEngine.Networking.UploadHandlerFile::Create");

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate IntPtr CreateDelegate(IntPtr self, IntPtr filePath);
	}
}
