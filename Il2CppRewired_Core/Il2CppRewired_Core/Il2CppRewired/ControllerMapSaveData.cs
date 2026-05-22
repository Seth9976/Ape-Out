using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppRewired
{
	// Token: 0x02000147 RID: 327
	public class ControllerMapSaveData : Object
	{
		// Token: 0x060023E7 RID: 9191 RVA: 0x000B6030 File Offset: 0x000B4230
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapSaveData()
		{
			Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr);
			ControllerMapSaveData.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, "_controller");
			ControllerMapSaveData.NativeFieldInfoPtr__map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, "_map");
			ControllerMapSaveData.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			ControllerMapSaveData.NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671023);
			ControllerMapSaveData.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671024);
			ControllerMapSaveData.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671025);
			ControllerMapSaveData.NativeMethodInfoPtr_get_mapType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671026);
			ControllerMapSaveData.NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671027);
			ControllerMapSaveData.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671028);
			ControllerMapSaveData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671029);
			ControllerMapSaveData.NativeMethodInfoPtr_get_controllerHardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671030);
			ControllerMapSaveData.NativeMethodInfoPtr_GetMap_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671031);
			ControllerMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671032);
			ControllerMapSaveData.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_T_Controller_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671033);
			ControllerMapSaveData.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_ControllerMapSaveData_Controller_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr, 100671034);
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000B618C File Offset: 0x000B438C
		public unsafe ControllerMap map
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 289948, RefRangeEnd = 289950, XrefRangeStart = 289944, XrefRangeEnd = 289948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000B61CC File Offset: 0x000B43CC
		public unsafe int categoryId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289950, XrefRangeEnd = 289957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x000B6208 File Offset: 0x000B4408
		public unsafe int layoutId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289957, XrefRangeEnd = 289964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x000B6244 File Offset: 0x000B4444
		public unsafe Type mapType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289964, XrefRangeEnd = 289971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_mapType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000B6284 File Offset: 0x000B4484
		public unsafe string mapTypeString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289971, XrefRangeEnd = 289985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000B62BC File Offset: 0x000B44BC
		public unsafe Controller controller
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289985, XrefRangeEnd = 289989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000B62FC File Offset: 0x000B44FC
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289989, XrefRangeEnd = 289996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x000B6338 File Offset: 0x000B4538
		public unsafe string controllerHardwareIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289996, XrefRangeEnd = 290005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_get_controllerHardwareIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000B6370 File Offset: 0x000B4570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290005, XrefRangeEnd = 290016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetMap<T>() where T : ControllerMap
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.MethodInfoStoreGeneric_GetMap_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000B63AC File Offset: 0x000B45AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290020, RefRangeEnd = 290025, XrefRangeStart = 290016, XrefRangeEnd = 290020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapSaveData(Controller controller, ControllerMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000B640C File Offset: 0x000B460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290025, XrefRangeEnd = 290027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T dSubCKSikOaufAaxCnPWeKqiPeHk<T>(Controller A_0, ControllerMap A_1) where T : ControllerMapSaveData
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.MethodInfoStoreGeneric_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_T_Controller_ControllerMap_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000B645C File Offset: 0x000B465C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290050, RefRangeEnd = 290053, XrefRangeStart = 290027, XrefRangeEnd = 290050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerMapSaveData dSubCKSikOaufAaxCnPWeKqiPeHk(Controller A_0, ControllerMap A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapSaveData.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_ControllerMapSaveData_Controller_ControllerMap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapSaveData>(intPtr3) : null;
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		public ControllerMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000B64B4 File Offset: 0x000B46B4
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0000E6F5 File Offset: 0x0000C8F5
		public unsafe Controller _controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr__controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000B64E4 File Offset: 0x000B46E4
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x0000E714 File Offset: 0x0000C914
		public unsafe ControllerMap _map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr__map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr__map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000B6514 File Offset: 0x000B4714
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0000E733 File Offset: 0x0000C933
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapSaveData.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeFieldInfoPtr__controller;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeFieldInfoPtr__map;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_get_mapType_Public_get_Type_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_get_mapTypeString_Public_get_String_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerHardwareIdentifier_Public_get_String_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_GetMap_Public_T_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_ControllerMap_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_T_Controller_ControllerMap_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_ControllerMapSaveData_Controller_ControllerMap_0;

		// Token: 0x02000364 RID: 868
		private sealed class MethodInfoStoreGeneric_GetMap_Public_T_0<T>
		{
			// Token: 0x04003AB1 RID: 15025
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ControllerMapSaveData.NativeMethodInfoPtr_GetMap_Public_T_0, Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000365 RID: 869
		private sealed class MethodInfoStoreGeneric_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_T_Controller_ControllerMap_0<T>
		{
			// Token: 0x04003AB2 RID: 15026
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ControllerMapSaveData.NativeMethodInfoPtr_dSubCKSikOaufAaxCnPWeKqiPeHk_Internal_Static_T_Controller_ControllerMap_0, Il2CppClassPointerStore<ControllerMapSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
