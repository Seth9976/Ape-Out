using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking
{
	// Token: 0x0200000F RID: 15
	public class DownloadHandlerScript : DownloadHandler
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002642 File Offset: 0x00000842
		public static IntPtr Create(DownloadHandlerScript obj)
		{
			return DownloadHandlerScript.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002654 File Offset: 0x00000854
		public static IntPtr CreatePreallocated(DownloadHandlerScript obj, Il2CppStructArray<byte> preallocatedBuffer)
		{
			return DownloadHandlerScript.CreatePreallocatedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000266C File Offset: 0x0000086C
		public void InternalCreateScript()
		{
			base.m_Ptr = DownloadHandlerScript.Create(this);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000267B File Offset: 0x0000087B
		public void InternalCreateScript(Il2CppStructArray<byte> preallocatedBuffer)
		{
			base.m_Ptr = DownloadHandlerScript.CreatePreallocated(this, preallocatedBuffer);
		}

		// Token: 0x0400009F RID: 159
		private static readonly DownloadHandlerScript.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerScript.CreateDelegate>("UnityEngine.Networking.DownloadHandlerScript::Create");

		// Token: 0x040000A0 RID: 160
		private static readonly DownloadHandlerScript.CreatePreallocatedDelegate CreatePreallocatedDelegateField = IL2CPP.ResolveICall<DownloadHandlerScript.CreatePreallocatedDelegate>("UnityEngine.Networking.DownloadHandlerScript::CreatePreallocated");

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000182 RID: 386
		private delegate IntPtr CreateDelegate(IntPtr obj);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate IntPtr CreatePreallocatedDelegate(IntPtr obj, IntPtr preallocatedBuffer);
	}
}
