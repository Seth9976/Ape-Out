using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core
{
	// Token: 0x0200003C RID: 60
	public static class SpecialPluginsUtils : global::Il2CppSystem.Object
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x00018104 File Offset: 0x00016304
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialPluginsUtils()
		{
			Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core", "SpecialPluginsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664100);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664101);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664102);
			SpecialPluginsUtils.NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialPluginsUtils>.NativeClassPtr, 100664103);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00018184 File Offset: 0x00016384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123517, RefRangeEnd = 123518, XrefRangeStart = 123506, XrefRangeEnd = 123517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLookAt(TweenerCore<Quaternion, Vector3, QuaternionOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000181C8 File Offset: 0x000163C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123521, RefRangeEnd = 123525, XrefRangeStart = 123518, XrefRangeEnd = 123521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetPunch(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001820C File Offset: 0x0001640C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123525, XrefRangeEnd = 123526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetShake(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00018250 File Offset: 0x00016450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123550, RefRangeEnd = 123551, XrefRangeStart = 123526, XrefRangeEnd = 123550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCameraShakePosition(TweenerCore<Vector3, Il2CppStructArray<Vector3>, Vector3ArrayOptions> t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialPluginsUtils.NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000030E6 File Offset: 0x000012E6
		public SpecialPluginsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_SetLookAt_Internal_Static_Boolean_TweenerCore_3_Quaternion_Vector3_QuaternionOptions_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_SetPunch_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_SetShake_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShakePosition_Internal_Static_Boolean_TweenerCore_3_Vector3_Il2CppStructArray_1_Vector3_Vector3ArrayOptions_0;
	}
}
