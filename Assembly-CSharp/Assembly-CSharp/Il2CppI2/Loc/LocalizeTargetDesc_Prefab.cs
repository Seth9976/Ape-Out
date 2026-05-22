using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppI2.Loc
{
	// Token: 0x0200024E RID: 590
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		// Token: 0x0600456D RID: 17773 RVA: 0x00102B3C File Offset: 0x00100D3C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTargetDesc_Prefab()
		{
			Il2CppClassPointerStore<LocalizeTargetDesc_Prefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTargetDesc_Prefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeTargetDesc_Prefab>.NativeClassPtr);
			LocalizeTargetDesc_Prefab.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Prefab>.NativeClassPtr, 100670269);
			LocalizeTargetDesc_Prefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Prefab>.NativeClassPtr, 100670270);
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00102B94 File Offset: 0x00100D94
		[CallerCount(0)]
		public unsafe override bool CanLocalize(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc_Prefab.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00102BEC File Offset: 0x00100DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113491, XrefRangeEnd = 113492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTargetDesc_Prefab()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTargetDesc_Prefab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTargetDesc_Prefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x000299AA File Offset: 0x00027BAA
		public LocalizeTargetDesc_Prefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
