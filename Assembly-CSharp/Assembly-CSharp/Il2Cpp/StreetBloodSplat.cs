using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001B8 RID: 440
	public class StreetBloodSplat : MonoBehaviour
	{
		// Token: 0x060030F8 RID: 12536 RVA: 0x000BB23C File Offset: 0x000B943C
		// Note: this type is marked as 'beforefieldinit'.
		static StreetBloodSplat()
		{
			Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StreetBloodSplat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr);
			StreetBloodSplat.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr, 100667135);
			StreetBloodSplat.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr, 100667136);
			StreetBloodSplat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr, 100667137);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x000BB2A8 File Offset: 0x000B94A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84811, XrefRangeEnd = 84834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetBloodSplat.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000BB2DC File Offset: 0x000B94DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84834, XrefRangeEnd = 84847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetBloodSplat.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000BB310 File Offset: 0x000B9510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetBloodSplat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetBloodSplat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetBloodSplat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000219E4 File Offset: 0x0001FBE4
		public StreetBloodSplat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
