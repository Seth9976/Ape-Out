using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001CF RID: 463
	public class TurnOnForDeathScreen : MonoBehaviour
	{
		// Token: 0x06003284 RID: 12932 RVA: 0x000BF0AC File Offset: 0x000BD2AC
		// Note: this type is marked as 'beforefieldinit'.
		static TurnOnForDeathScreen()
		{
			Il2CppClassPointerStore<TurnOnForDeathScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TurnOnForDeathScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnOnForDeathScreen>.NativeClassPtr);
			TurnOnForDeathScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOnForDeathScreen>.NativeClassPtr, 100667227);
			TurnOnForDeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnOnForDeathScreen>.NativeClassPtr, 100667228);
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000BF104 File Offset: 0x000BD304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85843, XrefRangeEnd = 85861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOnForDeathScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x000BF138 File Offset: 0x000BD338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TurnOnForDeathScreen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnOnForDeathScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnOnForDeathScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00022A01 File Offset: 0x00020C01
		public TurnOnForDeathScreen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
