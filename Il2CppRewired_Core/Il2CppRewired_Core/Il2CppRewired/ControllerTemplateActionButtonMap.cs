using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000082 RID: 130
	public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap
	{
		// Token: 0x06001099 RID: 4249 RVA: 0x0006B8B4 File Offset: 0x00069AB4
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateActionButtonMap()
		{
			Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplateActionButtonMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr);
			ControllerTemplateActionButtonMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, "wclwqICFwBjaBPhKCYlbyjGpUgp");
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666068);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666069);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Pole_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666070);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666071);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666072);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666073);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666074);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666075);
			ControllerTemplateActionButtonMap.NativeMethodInfoPtr_zcYhDIfcnoTWecdKaBmciALpAAr_Private_ActionElementMap_IControllerElementTarget_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr, 100666076);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0006B9AC File Offset: 0x00069BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259920, XrefRangeEnd = 259927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionButtonMap(SerializedObject serializedObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0006B9F8 File Offset: 0x00069BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259927, XrefRangeEnd = 259928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionButtonMap(int templateElementIdentifierId, ActionElementMap actionElementMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref templateElementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionElementMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0006BA54 File Offset: 0x00069C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259928, XrefRangeEnd = 259929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateActionButtonMap(int elementIdentifierId, int actionId, Pole axisContribution, bool enabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateActionButtonMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementIdentifierId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisContribution;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Pole_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0006BAC8 File Offset: 0x00069CC8
		public unsafe Pole axisContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0006BB04 File Offset: 0x00069D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259929, XrefRangeEnd = 259935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TUpbRFbZCQXGnqKfXoSpZTimZpRE(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0006BB48 File Offset: 0x00069D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259935, XrefRangeEnd = 259940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0006BB8C File Offset: 0x00069D8C
		[CallerCount(0)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0006BBC0 File Offset: 0x00069DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259940, XrefRangeEnd = 259961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0006BC30 File Offset: 0x00069E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259961, XrefRangeEnd = 259974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionElementMap zcYhDIfcnoTWecdKaBmciALpAAr(IControllerElementTarget A_1, Pole A_2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateActionButtonMap.NativeMethodInfoPtr_zcYhDIfcnoTWecdKaBmciALpAAr_Private_ActionElementMap_IControllerElementTarget_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr3) : null;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00007567 File Offset: 0x00005767
		public ControllerTemplateActionButtonMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0006BC90 File Offset: 0x00069E90
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00007570 File Offset: 0x00005770
		public unsafe Pole wclwqICFwBjaBPhKCYlbyjGpUgp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionButtonMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateActionButtonMap.NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp)) = value;
			}
		}

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_wclwqICFwBjaBPhKCYlbyjGpUgp;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializedObject_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_ActionElementMap_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Pole_Boolean_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_get_axisContribution_Public_get_Pole_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Internal_Virtual_Void_SerializedObject_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Internal_Virtual_Void_SerializedObject_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_UIuoHRwxnHNAeZGLLSVgsdglwi_Internal_Virtual_Int32_IControllerTemplateElementSource_List_1_ActionElementMap_Boolean_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_zcYhDIfcnoTWecdKaBmciALpAAr_Private_ActionElementMap_IControllerElementTarget_Pole_0;
	}
}
