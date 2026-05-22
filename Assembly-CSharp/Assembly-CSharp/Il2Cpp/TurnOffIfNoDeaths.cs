using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CE RID: 462
	public class TurnOffIfNoDeaths : MonoBehaviour
	{
		// Token: 0x06003280 RID: 12928 RVA: 0x000BEFE4 File Offset: 0x000BD1E4
		// Note: this type is marked as 'beforefieldinit'.
		static TurnOffIfNoDeaths()
		{
			Il2CppClassPointerStore<TurnOffIfNoDeaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TurnOffIfNoDeaths");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnOffIfNoDeaths>.NativeClassPtr);
			TurnOffIfNoDeaths.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOffIfNoDeaths>.NativeClassPtr, 100667225);
			TurnOffIfNoDeaths.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOffIfNoDeaths>.NativeClassPtr, 100667226);
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000BF03C File Offset: 0x000BD23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85832, XrefRangeEnd = 85843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOffIfNoDeaths.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000BF070 File Offset: 0x000BD270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TurnOffIfNoDeaths()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnOffIfNoDeaths>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOffIfNoDeaths.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000229F8 File Offset: 0x00020BF8
		public TurnOffIfNoDeaths(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
