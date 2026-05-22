using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils
{
	// Token: 0x020001D1 RID: 465
	public static class EmptyObjects<T> : Object
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x000F2B60 File Offset: 0x000F0D60
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyObjects()
		{
			Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils", "EmptyObjects`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr);
			EmptyObjects<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr, "nCMgdFmnQSLCfMwlBKEBTFjpIGF");
			EmptyObjects<T>.NativeFieldInfoPtr_kTjsrHXiSZfSdwENSVJslqCKiAu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr, "kTjsrHXiSZfSdwENSVJslqCKiAu");
			EmptyObjects<T>.NativeMethodInfoPtr_get_array_Public_Static_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr, 100675733);
			EmptyObjects<T>.NativeMethodInfoPtr_get_EmptyReadOnlyIListT_Public_Static_get_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyObjects<T>>.NativeClassPtr, 100675734);
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000F2C1C File Offset: 0x000F0E1C
		public unsafe static Il2CppArrayBase<T> array
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 335524, RefRangeEnd = 335544, XrefRangeStart = 335517, XrefRangeEnd = 335524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyObjects<T>.NativeMethodInfoPtr_get_array_Public_Static_get_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x000F2C48 File Offset: 0x000F0E48
		public unsafe static IList<T> EmptyReadOnlyIListT
		{
			[CallerCount(77)]
			[CachedScanResults(RefRangeStart = 335558, RefRangeEnd = 335635, XrefRangeStart = 335544, XrefRangeEnd = 335558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmptyObjects<T>.NativeMethodInfoPtr_get_EmptyReadOnlyIListT_Public_Static_get_IList_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00011837 File Offset: 0x0000FA37
		public EmptyObjects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000F2C7C File Offset: 0x000F0E7C
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x00011840 File Offset: 0x0000FA40
		public unsafe static Il2CppArrayBase<T> nCMgdFmnQSLCfMwlBKEBTFjpIGF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyObjects<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyObjects<T>.NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000F2C9C File Offset: 0x000F0E9C
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x00011852 File Offset: 0x0000FA52
		public unsafe static IList<T> kTjsrHXiSZfSdwENSVJslqCKiAu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmptyObjects<T>.NativeFieldInfoPtr_kTjsrHXiSZfSdwENSVJslqCKiAu, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmptyObjects<T>.NativeFieldInfoPtr_kTjsrHXiSZfSdwENSVJslqCKiAu, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeFieldInfoPtr_nCMgdFmnQSLCfMwlBKEBTFjpIGF;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeFieldInfoPtr_kTjsrHXiSZfSdwENSVJslqCKiAu;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr_get_array_Public_Static_get_Il2CppArrayBase_1_T_0;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr_get_EmptyReadOnlyIListT_Public_Static_get_IList_1_T_0;
	}
}
