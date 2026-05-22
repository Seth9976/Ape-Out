using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000041 RID: 65
	public class CubicBezierDecoder : ABSPathDecoder
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x000190E4 File Offset: 0x000172E4
		// Note: this type is marked as 'beforefieldinit'.
		static CubicBezierDecoder()
		{
			Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "CubicBezierDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr);
			CubicBezierDecoder.NativeFieldInfoPtr__PartialControlPs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, "_PartialControlPs");
			CubicBezierDecoder.NativeFieldInfoPtr__PartialWps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, "_PartialWps");
			CubicBezierDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, 100664120);
			CubicBezierDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, 100664121);
			CubicBezierDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, 100664122);
			CubicBezierDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, 100664123);
			CubicBezierDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr, 100664124);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000191A0 File Offset: 0x000173A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123833, XrefRangeEnd = 123851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinalizePath(Path p, Il2CppStructArray<Vector3> wps, bool isClosedPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosedPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CubicBezierDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00019210 File Offset: 0x00017410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123851, XrefRangeEnd = 123855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetPoint(float perc, Il2CppStructArray<Vector3> wps, Path p, Il2CppStructArray<ControlPoint> controlPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CubicBezierDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001929C File Offset: 0x0001749C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123865, RefRangeEnd = 123866, XrefRangeStart = 123855, XrefRangeEnd = 123865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeToLengthTables(Path p, int subdivisions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubicBezierDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000192EC File Offset: 0x000174EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123880, RefRangeEnd = 123881, XrefRangeStart = 123866, XrefRangeEnd = 123880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaypointsLengths(Path p, int subdivisions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubicBezierDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001933C File Offset: 0x0001753C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubicBezierDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubicBezierDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubicBezierDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000326E File Offset: 0x0000146E
		public CubicBezierDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00019378 File Offset: 0x00017578
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003277 File Offset: 0x00001477
		public unsafe static Il2CppStructArray<ControlPoint> _PartialControlPs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CubicBezierDecoder.NativeFieldInfoPtr__PartialControlPs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ControlPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CubicBezierDecoder.NativeFieldInfoPtr__PartialControlPs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000193A0 File Offset: 0x000175A0
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003289 File Offset: 0x00001489
		public unsafe static Il2CppStructArray<Vector3> _PartialWps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CubicBezierDecoder.NativeFieldInfoPtr__PartialWps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CubicBezierDecoder.NativeFieldInfoPtr__PartialWps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr__PartialControlPs;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr__PartialWps;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
