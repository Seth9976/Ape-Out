using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000083 RID: 131
	public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x0006BCB8 File Offset: 0x00069EB8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateActionAxisMap()
		{
			Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplateActionAxisMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr);
			ControllerTemplateActionAxisMap.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, "fQhXdDzxMfJmFQuoJwqnjqjKizF");
			ControllerTemplateActionAxisMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, "wclwqICFwBjaBPhKCYlbyjGpUgp");
			ControllerTemplateActionAxisMap.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, "EvuDNwoPLdXPTXxOXwNeRHfLnDI");
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666077);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_AxisRange_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666078);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_AxisRange_Pole_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666079);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666080);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666081);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666082);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666083);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666084);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666085);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666086);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_XGcKrBHmPsDZXMtUbJgWYOYamdm_Private_ActionElementMap_IControllerElementTarget_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666087);
			ControllerTemplateActionAxisMap.NativeMethodInfoPtr_qVIrMWtZKfXPUlHpJHibPEoLNpj_Private_ActionElementMap_IControllerElementTarget_Pole_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr, 100666088);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0006BE14 File Offset: 0x0006A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259974, XrefRangeEnd = 259982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionAxisMap(SerializedObject serializedObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0006BE60 File Offset: 0x0006A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259982, XrefRangeEnd = 259984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionAxisMap(int templateElementIdentifierId, AxisRange axisRange, ActionElementMap actionElementMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref templateElementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_AxisRange_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0006BEC8 File Offset: 0x0006A0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259984, XrefRangeEnd = 259986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionAxisMap(int elementIdentifierId, int actionId, AxisRange axisRange, Pole axisContribution, bool invert, bool enabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionAxisMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisRange;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_AxisRange_Pole_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0006BF58 File Offset: 0x0006A158
		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0006BF94 File Offset: 0x0006A194
		public unsafe Pole axisContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		public unsafe bool invert
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_get_invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0006C00C File Offset: 0x0006A20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259986, XrefRangeEnd = 260001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TUpbRFbZCQXGnqKfXoSpZTimZpRE(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0006C050 File Offset: 0x0006A250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260001, XrefRangeEnd = 260014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0006C094 File Offset: 0x0006A294
		[CallerCount(0)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0006C0C8 File Offset: 0x0006A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260014, XrefRangeEnd = 260044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int UIuoHRwxnHNAeZGLLSVgsdglwi(IControllerTemplateElementSource A_1, List<ActionElementMap> A_2, bool A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0006C138 File Offset: 0x0006A338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260057, RefRangeEnd = 260060, XrefRangeStart = 260044, XrefRangeEnd = 260057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap XGcKrBHmPsDZXMtUbJgWYOYamdm(IControllerElementTarget A_1, AxisRange A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_XGcKrBHmPsDZXMtUbJgWYOYamdm_Private_ActionElementMap_IControllerElementTarget_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0006C198 File Offset: 0x0006A398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260073, RefRangeEnd = 260074, XrefRangeStart = 260060, XrefRangeEnd = 260073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap qVIrMWtZKfXPUlHpJHibPEoLNpj(IControllerElementTarget A_1, Pole A_2, Pole A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionAxisMap.NativeMethodInfoPtr_qVIrMWtZKfXPUlHpJHibPEoLNpj_Private_ActionElementMap_IControllerElementTarget_Pole_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0000758B File Offset: 0x0000578B
		public ControllerTemplateActionAxisMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0006C204 File Offset: 0x0006A404
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00007594 File Offset: 0x00005794
		public unsafe AxisRange fQhXdDzxMfJmFQuoJwqnjqjKizF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0006C22C File Offset: 0x0006A42C
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x000075AF File Offset: 0x000057AF
		public unsafe Pole wclwqICFwBjaBPhKCYlbyjGpUgp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0006C254 File Offset: 0x0006A454
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x000075CA File Offset: 0x000057CA
		public unsafe bool EvuDNwoPLdXPTXxOXwNeRHfLnDI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionAxisMap.NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI)) = value;
			}
		}

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr_fQhXdDzxMfJmFQuoJwqnjqjKizF;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeFieldInfoPtr_EvuDNwoPLdXPTXxOXwNeRHfLnDI;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_AxisRange_ActionElementMap_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_AxisRange_Pole_Boolean_Boolean_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_get_invert_Public_get_Boolean_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_XGcKrBHmPsDZXMtUbJgWYOYamdm_Private_ActionElementMap_IControllerElementTarget_AxisRange_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_qVIrMWtZKfXPUlHpJHibPEoLNpj_Private_ActionElementMap_IControllerElementTarget_Pole_Pole_0;
	}
}
