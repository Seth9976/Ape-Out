using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppDG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000044 RID: 68
	public class CatmullRomDecoder : ABSPathDecoder
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x000196B8 File Offset: 0x000178B8
		// Note: this type is marked as 'beforefieldinit'.
		static CatmullRomDecoder()
		{
			Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "CatmullRomDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr);
			CatmullRomDecoder.NativeFieldInfoPtr__PartialControlPs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, "_PartialControlPs");
			CatmullRomDecoder.NativeFieldInfoPtr__PartialWps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, "_PartialWps");
			CatmullRomDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664132);
			CatmullRomDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664133);
			CatmullRomDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664134);
			CatmullRomDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664135);
			CatmullRomDecoder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr, 100664136);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00019774 File Offset: 0x00017974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123917, XrefRangeEnd = 123950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CatmullRomDecoder.NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000197E4 File Offset: 0x000179E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123950, XrefRangeEnd = 123956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CatmullRomDecoder.NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00019870 File Offset: 0x00017A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123966, RefRangeEnd = 123967, XrefRangeStart = 123956, XrefRangeEnd = 123966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000198C0 File Offset: 0x00017AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123989, RefRangeEnd = 123990, XrefRangeStart = 123967, XrefRangeEnd = 123989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00019910 File Offset: 0x00017B10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CatmullRomDecoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CatmullRomDecoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CatmullRomDecoder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000032B6 File Offset: 0x000014B6
		public CatmullRomDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0001994C File Offset: 0x00017B4C
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000032BF File Offset: 0x000014BF
		public unsafe static Il2CppStructArray<ControlPoint> _PartialControlPs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CatmullRomDecoder.NativeFieldInfoPtr__PartialControlPs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ControlPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CatmullRomDecoder.NativeFieldInfoPtr__PartialControlPs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00019974 File Offset: 0x00017B74
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000032D1 File Offset: 0x000014D1
		public unsafe static Il2CppStructArray<Vector3> _PartialWps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CatmullRomDecoder.NativeFieldInfoPtr__PartialWps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CatmullRomDecoder.NativeFieldInfoPtr__PartialWps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr__PartialControlPs;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr__PartialWps;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Virtual_Void_Path_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Virtual_Vector3_Single_Il2CppStructArray_1_Vector3_Path_Il2CppStructArray_1_ControlPoint_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeToLengthTables_Internal_Void_Path_Int32_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_SetWaypointsLengths_Internal_Void_Path_Int32_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
