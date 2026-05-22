using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppI2.Loc
{
	// Token: 0x02000247 RID: 583
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : global::UnityEngine.Object where G : LocalizeTarget<T>
	{
		// Token: 0x06004518 RID: 17688 RVA: 0x00101150 File Offset: 0x000FF350
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTargetDesc_Type()
		{
			Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTargetDesc_Type`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr);
			LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr, 100670209);
			LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr, 100670210);
			LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr, 100670211);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x0010120C File Offset: 0x000FF40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112841, XrefRangeEnd = 112853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanLocalize(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00101264 File Offset: 0x000FF464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112853, XrefRangeEnd = 112865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ILocalizeTarget CreateTarget(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalizeTarget>(intPtr3) : null;
			}
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x001012C0 File Offset: 0x000FF4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112865, XrefRangeEnd = 112866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeTargetDesc_Type()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTargetDesc_Type<T, G>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTargetDesc_Type<T, G>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00029893 File Offset: 0x00027A93
		public LocalizeTargetDesc_Type(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeMethodInfoPtr_CanLocalize_Public_Virtual_Boolean_Localize_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
