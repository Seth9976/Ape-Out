using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CD RID: 461
	public class TurnOffForDeathScreen : MonoBehaviour
	{
		// Token: 0x0600327C RID: 12924 RVA: 0x000BEF1C File Offset: 0x000BD11C
		// Note: this type is marked as 'beforefieldinit'.
		static TurnOffForDeathScreen()
		{
			Il2CppClassPointerStore<TurnOffForDeathScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TurnOffForDeathScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnOffForDeathScreen>.NativeClassPtr);
			TurnOffForDeathScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOffForDeathScreen>.NativeClassPtr, 100667223);
			TurnOffForDeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOffForDeathScreen>.NativeClassPtr, 100667224);
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000BEF74 File Offset: 0x000BD174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85825, XrefRangeEnd = 85832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOffForDeathScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000BEFA8 File Offset: 0x000BD1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TurnOffForDeathScreen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnOffForDeathScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOffForDeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000229EF File Offset: 0x00020BEF
		public TurnOffForDeathScreen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
