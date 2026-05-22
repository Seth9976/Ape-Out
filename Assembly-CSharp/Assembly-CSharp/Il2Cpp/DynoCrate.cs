using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000BD RID: 189
	public class DynoCrate : StaticBreakable
	{
		// Token: 0x06001693 RID: 5779 RVA: 0x00073FF0 File Offset: 0x000721F0
		// Note: this type is marked as 'beforefieldinit'.
		static DynoCrate()
		{
			Il2CppClassPointerStore<DynoCrate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynoCrate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr);
			DynoCrate.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr, "offSet");
			DynoCrate.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr, 100665190);
			DynoCrate.NativeMethodInfoPtr_Break_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr, 100665191);
			DynoCrate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr, 100665192);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00074070 File Offset: 0x00072270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55889, XrefRangeEnd = 55920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoCrate.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000740A4 File Offset: 0x000722A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55920, XrefRangeEnd = 55964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynoCrate.NativeMethodInfoPtr_Break_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000740E0 File Offset: 0x000722E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55964, XrefRangeEnd = 55965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynoCrate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynoCrate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynoCrate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0001042E File Offset: 0x0000E62E
		public DynoCrate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0007411C File Offset: 0x0007231C
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00010437 File Offset: 0x0000E637
		public unsafe Vector3 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCrate.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynoCrate.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
