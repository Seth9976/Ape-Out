using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DF RID: 223
	public class CredentialCache : Object
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x00006F15 File Offset: 0x00005115
		// Note: this type is marked as 'beforefieldinit'.
		static CredentialCache()
		{
			Il2CppClassPointerStore<CredentialCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CredentialCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr);
			CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100665146);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x000405C8 File Offset: 0x0003E7C8
		public unsafe static ICredentials DefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376589, XrefRangeEnd = 376593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CredentialCache.NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00006F4E File Offset: 0x0000514E
		public CredentialCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0;
	}
}
