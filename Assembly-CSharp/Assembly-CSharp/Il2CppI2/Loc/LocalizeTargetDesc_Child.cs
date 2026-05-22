using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppI2.Loc
{
	// Token: 0x0200024B RID: 587
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		// Token: 0x06004552 RID: 17746 RVA: 0x0010221C File Offset: 0x0010041C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTargetDesc_Child()
		{
			Il2CppClassPointerStore<LocalizeTargetDesc_Child>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTargetDesc_Child");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeTargetDesc_Child>.NativeClassPtr);
			LocalizeTargetDesc_Child.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Child>.NativeClassPtr, 100670246);
			LocalizeTargetDesc_Child.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Child>.NativeClassPtr, 100670247);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00102274 File Offset: 0x00100474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113292, XrefRangeEnd = 113296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanLocalize(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc_Child.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x001022CC File Offset: 0x001004CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113296, XrefRangeEnd = 113297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTargetDesc_Child()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTargetDesc_Child>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTargetDesc_Child.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x0002998F File Offset: 0x00027B8F
		public LocalizeTargetDesc_Child(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
