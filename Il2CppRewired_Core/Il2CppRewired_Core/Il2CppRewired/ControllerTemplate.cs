using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data.Mapping;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000072 RID: 114
	public class ControllerTemplate : global::Il2CppSystem.Object
	{
		// Token: 0x06000FDA RID: 4058 RVA: 0x00068190 File Offset: 0x00066390
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplate()
		{
			Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr);
			ControllerTemplate.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "dBMfgEzHekDWhMsmrRiTWJogtDs");
			ControllerTemplate.NativeFieldInfoPtr_OLFKjEIqnepYWyxUudnDkNAahWp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "OLFKjEIqnepYWyxUudnDkNAahWp");
			ControllerTemplate.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "egOPTGwnsPnUJWHsXfaRAFkRlvOu");
			ControllerTemplate.NativeFieldInfoPtr_PVQnoXxoKXnqhOHteCGYWHARGGj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "PVQnoXxoKXnqhOHteCGYWHARGGj");
			ControllerTemplate.NativeFieldInfoPtr_hQnIoIGfywMJRYRoZeQbBBHCKOJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "hQnIoIGfywMJRYRoZeQbBBHCKOJ");
			ControllerTemplate.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "xQkGABJRsmzTPSmeXgqJmJTMBma");
			ControllerTemplate.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "FaxDYKiOiLbKbaDgSKQsyfLUaPD");
			ControllerTemplate.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			ControllerTemplate.NativeMethodInfoPtr__ctor_Protected_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665819);
			ControllerTemplate.NativeMethodInfoPtr__ctor_Private_Void_iHjuSiZpHAsmKbJhaDVJbfWZWjt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665820);
			ControllerTemplate.NativeMethodInfoPtr_GetElement_Protected_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665821);
			ControllerTemplate.NativeMethodInfoPtr_GetElement_Protected_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665822);
			ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_controller_Private_Virtual_Final_New_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665823);
			ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665824);
			ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_typeGuid_Private_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665825);
			ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elements_Private_Virtual_Final_New_get_IList_1_IControllerTemplateElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665826);
			ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elementCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665827);
			ControllerTemplate.NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665828);
			ControllerTemplate.NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665829);
			ControllerTemplate.NativeMethodInfoPtr_tCRcFLYTnUPAbJDxuFwsxuyiNJu_Private_Virtual_Final_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665830);
			ControllerTemplate.NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Private_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665831);
			ControllerTemplate.NativeMethodInfoPtr_GetInterfaceType_Internal_Static_Type_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665832);
			ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateAxisSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665833);
			ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateButtonSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665834);
			ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665835);
			ControllerTemplate.NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Static_IControllerTemplateElement_List_1_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665836);
			ControllerTemplate.NativeMethodInfoPtr_TzOkqqWElptSLBBTPvoGuKdtCpQ_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665837);
			ControllerTemplate.NativeMethodInfoPtr_yONouhJwoewHiSNrbCTShpaekFzb_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, 100665838);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000683F0 File Offset: 0x000665F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplate(global::Il2CppSystem.Object payload)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr__ctor_Protected_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0006843C File Offset: 0x0006663C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 259342, RefRangeEnd = 259349, XrefRangeStart = 258997, XrefRangeEnd = 259342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplate(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr__ctor_Private_Void_iHjuSiZpHAsmKbJhaDVJbfWZWjt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00068488 File Offset: 0x00066688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259380, RefRangeEnd = 259382, XrefRangeStart = 259349, XrefRangeEnd = 259380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IControllerTemplateElement GetElement(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_GetElement_Protected_IControllerTemplateElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000684D4 File Offset: 0x000666D4
		[CallerCount(252)]
		[CachedScanResults(RefRangeStart = 259386, RefRangeEnd = 259638, XrefRangeStart = 259382, XrefRangeEnd = 259386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetElement<T>(int id) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.MethodInfoStoreGeneric_GetElement_Protected_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0006851C File Offset: 0x0006671C
		public unsafe virtual Controller Rewired.IControllerTemplate.controller
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259638, XrefRangeEnd = 259642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_controller_Private_Virtual_Final_New_get_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0006855C File Offset: 0x0006675C
		public unsafe virtual string Rewired.IControllerTemplate.name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259642, XrefRangeEnd = 259646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00068594 File Offset: 0x00066794
		public unsafe virtual Guid Rewired.IControllerTemplate.typeGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259646, XrefRangeEnd = 259657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_typeGuid_Private_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x000685D0 File Offset: 0x000667D0
		public unsafe virtual IList<IControllerTemplateElement> Rewired.IControllerTemplate.elements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259657, XrefRangeEnd = 259661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elements_Private_Virtual_Final_New_get_IList_1_IControllerTemplateElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IControllerTemplateElement>>(intPtr3) : null;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00068610 File Offset: 0x00066810
		public unsafe virtual int Rewired.IControllerTemplate.elementCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259661, XrefRangeEnd = 259665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elementCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0006864C File Offset: 0x0006684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259665, XrefRangeEnd = 259672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IControllerTemplateElement sZjwxTKUgulbQhNhFDPlXtyIAMg(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_IControllerTemplateElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00068698 File Offset: 0x00066898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259672, XrefRangeEnd = 259679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T sZjwxTKUgulbQhNhFDPlXtyIAMg<T>(int A_1) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.MethodInfoStoreGeneric_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000686E0 File Offset: 0x000668E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259679, XrefRangeEnd = 259684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int tCRcFLYTnUPAbJDxuFwsxuyiNJu(ControllerElementTarget A_1, IList<ControllerTemplateElementTarget> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_tCRcFLYTnUPAbJDxuFwsxuyiNJu_Private_Virtual_Final_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00068744 File Offset: 0x00066944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259700, RefRangeEnd = 259701, XrefRangeStart = 259684, XrefRangeEnd = 259700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int tgZDemgXSXTDHPCCrMqaNPbkJdJd(ControllerElementTarget A_1, ref IList<ControllerTemplateElementTarget> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Private_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			A_2 = ((intPtr4 == 0) ? null : new IList<ControllerTemplateElementTarget>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x000687C0 File Offset: 0x000669C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259701, XrefRangeEnd = 259736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetInterfaceType(ControllerTemplateElementType elementType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elementType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_GetInterfaceType_Internal_Static_Type_ControllerTemplateElementType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00068800 File Offset: 0x00066A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259745, RefRangeEnd = 259746, XrefRangeStart = 259736, XrefRangeEnd = 259745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> KIwfMGfwpQEhwKuPqIJJIiSjvkj(Controller A_0, IControllerTemplateAxisSource A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateAxisSource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>>(intPtr3) : null;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00068858 File Offset: 0x00066A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259746, XrefRangeEnd = 259750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> KIwfMGfwpQEhwKuPqIJJIiSjvkj(Controller A_0, IControllerTemplateButtonSource A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateButtonSource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>>(intPtr3) : null;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000688B0 File Offset: 0x00066AB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259767, RefRangeEnd = 259770, XrefRangeStart = 259750, XrefRangeEnd = 259767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> KIwfMGfwpQEhwKuPqIJJIiSjvkj(Controller A_0, IControllerElementTarget A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerElementTarget_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>>(intPtr3) : null;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00068908 File Offset: 0x00066B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259770, XrefRangeEnd = 259775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IControllerTemplateElement cDnaXNudHhkGVwNJBkjCspzORSz(List<IControllerTemplateElement> A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Static_IControllerTemplateElement_List_1_IControllerTemplateElement_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0006895C File Offset: 0x00066B5C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 259780, RefRangeEnd = 259794, XrefRangeStart = 259775, XrefRangeEnd = 259780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL TzOkqqWElptSLBBTPvoGuKdtCpQ(IControllerTemplate A_0, ADictionary<int, IControllerTemplateElement> A_1, int A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_TzOkqqWElptSLBBTPvoGuKdtCpQ_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>(intPtr3) : null;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000689C0 File Offset: 0x00066BC0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 259799, RefRangeEnd = 259814, XrefRangeStart = 259794, XrefRangeEnd = 259799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL yONouhJwoewHiSNrbCTShpaekFzb(IControllerTemplate A_0, ADictionary<int, IControllerTemplateElement> A_1, int A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.NativeMethodInfoPtr_yONouhJwoewHiSNrbCTShpaekFzb_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>(intPtr3) : null;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00007352 File Offset: 0x00005552
		public ControllerTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00068A24 File Offset: 0x00066C24
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0000735B File Offset: 0x0000555B
		public unsafe string dBMfgEzHekDWhMsmrRiTWJogtDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00068A4C File Offset: 0x00066C4C
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0000737A File Offset: 0x0000557A
		public unsafe Guid OLFKjEIqnepYWyxUudnDkNAahWp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_OLFKjEIqnepYWyxUudnDkNAahWp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_OLFKjEIqnepYWyxUudnDkNAahWp)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00068A74 File Offset: 0x00066C74
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00007395 File Offset: 0x00005595
		public unsafe Controller egOPTGwnsPnUJWHsXfaRAFkRlvOu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00068AA4 File Offset: 0x00066CA4
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000073B4 File Offset: 0x000055B4
		public unsafe ADictionary<int, IControllerTemplateElement> PVQnoXxoKXnqhOHteCGYWHARGGj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_PVQnoXxoKXnqhOHteCGYWHARGGj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<int, IControllerTemplateElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_PVQnoXxoKXnqhOHteCGYWHARGGj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00068AD4 File Offset: 0x00066CD4
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000073D3 File Offset: 0x000055D3
		public unsafe ADictionary<string, IControllerTemplateElement> hQnIoIGfywMJRYRoZeQbBBHCKOJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_hQnIoIGfywMJRYRoZeQbBBHCKOJ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ADictionary<string, IControllerTemplateElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_hQnIoIGfywMJRYRoZeQbBBHCKOJ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00068B04 File Offset: 0x00066D04
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000073F2 File Offset: 0x000055F2
		public unsafe Il2CppReferenceArray<IControllerTemplateElement> xQkGABJRsmzTPSmeXgqJmJTMBma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IControllerTemplateElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00068B34 File Offset: 0x00066D34
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00007411 File Offset: 0x00005611
		public unsafe ReadOnlyCollection<IControllerTemplateElement> FaxDYKiOiLbKbaDgSKQsyfLUaPD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<IControllerTemplateElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00068B64 File Offset: 0x00066D64
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00007430 File Offset: 0x00005630
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_OLFKjEIqnepYWyxUudnDkNAahWp;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_egOPTGwnsPnUJWHsXfaRAFkRlvOu;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_PVQnoXxoKXnqhOHteCGYWHARGGj;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_hQnIoIGfywMJRYRoZeQbBBHCKOJ;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Object_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_iHjuSiZpHAsmKbJhaDVJbfWZWjt_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Protected_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Protected_T_Int32_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplate_get_controller_Private_Virtual_Final_New_get_Controller_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplate_get_name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplate_get_typeGuid_Private_Virtual_Final_New_get_Guid_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elements_Private_Virtual_Final_New_get_IList_1_IControllerTemplateElement_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplate_get_elementCount_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_T_Int32_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_tCRcFLYTnUPAbJDxuFwsxuyiNJu_Private_Virtual_Final_New_Int32_ControllerElementTarget_IList_1_ControllerTemplateElementTarget_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Private_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaceType_Internal_Static_Type_ControllerTemplateElementType_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateAxisSource_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerTemplateButtonSource_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_KIwfMGfwpQEhwKuPqIJJIiSjvkj_Private_Static_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_Controller_IControllerElementTarget_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_cDnaXNudHhkGVwNJBkjCspzORSz_Private_Static_IControllerTemplateElement_List_1_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_TzOkqqWElptSLBBTPvoGuKdtCpQ_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_yONouhJwoewHiSNrbCTShpaekFzb_Private_Static_xrqwjVCopyODingacGCyftGDqkL_IControllerTemplate_ADictionary_2_Int32_IControllerTemplateElement_Int32_0;

		// Token: 0x0200028C RID: 652
		public class hVndtURQiZvFqDAtSlIbDHuddloG : global::Il2CppSystem.Object
		{
			// Token: 0x06003B4C RID: 15180 RVA: 0x0011DA5C File Offset: 0x0011BC5C
			// Note: this type is marked as 'beforefieldinit'.
			static hVndtURQiZvFqDAtSlIbDHuddloG()
			{
				Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "hVndtURQiZvFqDAtSlIbDHuddloG");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, "mcZTbbPGwEArYoSxgzyGmeIyAph");
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, "CbRqAjZxgMVAIemGtzhaFTknHqR");
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, "dBMfgEzHekDWhMsmrRiTWJogtDs");
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, "HLmDmUQWoPLmPsyHTHuhoXXcGIu");
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665839);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665840);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_descriptiveName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665841);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_type_Public_Virtual_Final_New_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665842);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665843);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665844);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665845);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665846);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665847);
				ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr, 100665848);
			}

			// Token: 0x06003B4D RID: 15181 RVA: 0x0011DBB4 File Offset: 0x0011BDB4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 258008, RefRangeEnd = 258011, XrefRangeStart = 258004, XrefRangeEnd = 258008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe hVndtURQiZvFqDAtSlIbDHuddloG(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06003B4E RID: 15182 RVA: 0x0011DC30 File Offset: 0x0011BE30
			public unsafe virtual int id
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258011, XrefRangeEnd = 258015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011E4 RID: 4580
			// (get) Token: 0x06003B4F RID: 15183 RVA: 0x0011DC6C File Offset: 0x0011BE6C
			public unsafe virtual string descriptiveName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258015, XrefRangeEnd = 258019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_descriptiveName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170011E5 RID: 4581
			// (get) Token: 0x06003B50 RID: 15184 RVA: 0x0011DCA4 File Offset: 0x0011BEA4
			public unsafe virtual ControllerTemplateElementType type
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258019, XrefRangeEnd = 258023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_type_Public_Virtual_Final_New_get_ControllerTemplateElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011E6 RID: 4582
			// (get) Token: 0x06003B51 RID: 15185 RVA: 0x0011DCE0 File Offset: 0x0011BEE0
			public unsafe virtual IControllerTemplate parent
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_IControllerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr3) : null;
				}
			}

			// Token: 0x170011E7 RID: 4583
			// (get) Token: 0x06003B52 RID: 15186 RVA: 0x0011DD20 File Offset: 0x0011BF20
			public unsafe virtual int elementCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B53 RID: 15187 RVA: 0x0011DD68 File Offset: 0x0011BF68
			[CallerCount(0)]
			public unsafe virtual IControllerTemplateElement GetElement(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
				}
			}

			// Token: 0x06003B54 RID: 15188 RVA: 0x0011DDC0 File Offset: 0x0011BFC0
			[CallerCount(0)]
			public unsafe virtual int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(find));
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				list = ((intPtr4 == 0) ? null : new IList<ControllerTemplateElementTarget>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x06003B55 RID: 15189 RVA: 0x0011DE48 File Offset: 0x0011C048
			public unsafe virtual IControllerTemplateElementSource source
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementSource>(intPtr3) : null;
				}
			}

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x06003B56 RID: 15190 RVA: 0x0011DE94 File Offset: 0x0011C094
			public unsafe virtual bool exists
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B57 RID: 15191 RVA: 0x000151C6 File Offset: 0x000133C6
			public hVndtURQiZvFqDAtSlIbDHuddloG(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011DE RID: 4574
			// (get) Token: 0x06003B58 RID: 15192 RVA: 0x0011DEDC File Offset: 0x0011C0DC
			// (set) Token: 0x06003B59 RID: 15193 RVA: 0x000151CF File Offset: 0x000133CF
			public unsafe IControllerTemplate mcZTbbPGwEArYoSxgzyGmeIyAph
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011DF RID: 4575
			// (get) Token: 0x06003B5A RID: 15194 RVA: 0x0011DF0C File Offset: 0x0011C10C
			// (set) Token: 0x06003B5B RID: 15195 RVA: 0x000151EE File Offset: 0x000133EE
			public unsafe int CbRqAjZxgMVAIemGtzhaFTknHqR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR)) = value;
				}
			}

			// Token: 0x170011E0 RID: 4576
			// (get) Token: 0x06003B5C RID: 15196 RVA: 0x0011DF34 File Offset: 0x0011C134
			// (set) Token: 0x06003B5D RID: 15197 RVA: 0x00015209 File Offset: 0x00013409
			public unsafe string dBMfgEzHekDWhMsmrRiTWJogtDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170011E1 RID: 4577
			// (get) Token: 0x06003B5E RID: 15198 RVA: 0x0011DF5C File Offset: 0x0011C15C
			// (set) Token: 0x06003B5F RID: 15199 RVA: 0x00015228 File Offset: 0x00013428
			public unsafe ControllerTemplateElementType HLmDmUQWoPLmPsyHTHuhoXXcGIu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu)) = value;
				}
			}

			// Token: 0x170011E2 RID: 4578
			// (get) Token: 0x06003B60 RID: 15200 RVA: 0x0011DF84 File Offset: 0x0011C184
			// (set) Token: 0x06003B61 RID: 15201 RVA: 0x00015243 File Offset: 0x00013443
			public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
				}
			}

			// Token: 0x040031B3 RID: 12723
			private static readonly IntPtr NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph;

			// Token: 0x040031B4 RID: 12724
			private static readonly IntPtr NativeFieldInfoPtr_CbRqAjZxgMVAIemGtzhaFTknHqR;

			// Token: 0x040031B5 RID: 12725
			private static readonly IntPtr NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs;

			// Token: 0x040031B6 RID: 12726
			private static readonly IntPtr NativeFieldInfoPtr_HLmDmUQWoPLmPsyHTHuhoXXcGIu;

			// Token: 0x040031B7 RID: 12727
			private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

			// Token: 0x040031B8 RID: 12728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_0;

			// Token: 0x040031B9 RID: 12729
			private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040031BA RID: 12730
			private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040031BB RID: 12731
			private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_Virtual_Final_New_get_ControllerTemplateElementType_0;

			// Token: 0x040031BC RID: 12732
			private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_IControllerTemplate_0;

			// Token: 0x040031BD RID: 12733
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x040031BE RID: 12734
			private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Abstract_Virtual_New_IControllerTemplateElement_Int32_0;

			// Token: 0x040031BF RID: 12735
			private static readonly IntPtr NativeMethodInfoPtr_GetElementTargets_Public_Abstract_Virtual_New_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0;

			// Token: 0x040031C0 RID: 12736
			private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Abstract_Virtual_New_get_IControllerTemplateElementSource_0;

			// Token: 0x040031C1 RID: 12737
			private static readonly IntPtr NativeMethodInfoPtr_get_exists_Public_Abstract_Virtual_New_get_Boolean_0;
		}

		// Token: 0x0200028D RID: 653
		public class nAcOATVtDifZewrtFqNblbLYBtn : ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG
		{
			// Token: 0x06003B62 RID: 15202 RVA: 0x0011DFAC File Offset: 0x0011C1AC
			// Note: this type is marked as 'beforefieldinit'.
			static nAcOATVtDifZewrtFqNblbLYBtn()
			{
				Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "nAcOATVtDifZewrtFqNblbLYBtn");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr);
				ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_sDudvlYoqWfECkZMsUEtrLGgMhzF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr, "sDudvlYoqWfECkZMsUEtrLGgMhzF");
				ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_opjZcapUTaTuciXZynCrsMeyoSy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr, "opjZcapUTaTuciXZynCrsMeyoSy");
				ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr, 100665849);
				ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr, 100665850);
			}

			// Token: 0x06003B63 RID: 15203 RVA: 0x0011E028 File Offset: 0x0011C228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258023, XrefRangeEnd = 258028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe nAcOATVtDifZewrtFqNblbLYBtn(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> sourceElements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceElements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011EC RID: 4588
			// (get) Token: 0x06003B64 RID: 15204 RVA: 0x0011E0B4 File Offset: 0x0011C2B4
			public unsafe override bool BKgAAYYDRlfKHVKytbUtlZMUffg
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258028, XrefRangeEnd = 258033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B65 RID: 15205 RVA: 0x0001525E File Offset: 0x0001345E
			public nAcOATVtDifZewrtFqNblbLYBtn(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011EA RID: 4586
			// (get) Token: 0x06003B66 RID: 15206 RVA: 0x0011E0FC File Offset: 0x0011C2FC
			// (set) Token: 0x06003B67 RID: 15207 RVA: 0x00015267 File Offset: 0x00013467
			public unsafe int sDudvlYoqWfECkZMsUEtrLGgMhzF
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_sDudvlYoqWfECkZMsUEtrLGgMhzF);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_sDudvlYoqWfECkZMsUEtrLGgMhzF)) = value;
				}
			}

			// Token: 0x170011EB RID: 4587
			// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0011E124 File Offset: 0x0011C324
			// (set) Token: 0x06003B69 RID: 15209 RVA: 0x00015282 File Offset: 0x00013482
			public unsafe Il2CppReferenceArray<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> opjZcapUTaTuciXZynCrsMeyoSy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_opjZcapUTaTuciXZynCrsMeyoSy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn.NativeFieldInfoPtr_opjZcapUTaTuciXZynCrsMeyoSy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031C2 RID: 12738
			private static readonly IntPtr NativeFieldInfoPtr_sDudvlYoqWfECkZMsUEtrLGgMhzF;

			// Token: 0x040031C3 RID: 12739
			private static readonly IntPtr NativeFieldInfoPtr_opjZcapUTaTuciXZynCrsMeyoSy;

			// Token: 0x040031C4 RID: 12740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0;

			// Token: 0x040031C5 RID: 12741
			private static readonly IntPtr NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0;
		}

		// Token: 0x0200028E RID: 654
		public class xrqwjVCopyODingacGCyftGDqkL : ControllerTemplate.nAcOATVtDifZewrtFqNblbLYBtn
		{
			// Token: 0x06003B6A RID: 15210 RVA: 0x0011E154 File Offset: 0x0011C354
			// Note: this type is marked as 'beforefieldinit'.
			static xrqwjVCopyODingacGCyftGDqkL()
			{
				Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "xrqwjVCopyODingacGCyftGDqkL");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_AVkxxtMdUzXDfetzWWOXzwXnkLW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, "AVkxxtMdUzXDfetzWWOXzwXnkLW");
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_gAMHzMcGesZADjHMYhsNmevTMOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, "gAMHzMcGesZADjHMYhsNmevTMOP");
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_odCQoDNioxIfQALaDfWkMlfNjnMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, "odCQoDNioxIfQALaDfWkMlfNjnMp");
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_String_String_ControllerTemplateElementType_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665851);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_floatValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665852);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665853);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665854);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665855);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_positiveDescriptiveName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665856);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_negativeDescriptiveName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665857);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_value_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665858);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_valuePrev_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665859);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_source_Private_Virtual_Final_New_get_IControllerTemplateAxisSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665860);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_LxbDackRNNESijTHElPraMsvnsiF_Private_Virtual_Final_New_String_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665861);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_value_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665862);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_valuePrev_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665863);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justPressed_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665864);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justReleased_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665865);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justChangedState_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665866);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressure_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665867);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressurePrev_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665868);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_source_Private_Virtual_Final_New_get_IControllerTemplateButtonSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665869);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665870);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665871);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_GetElement_Public_Virtual_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665872);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_GetElementTargets_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665873);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_AsAxis_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665874);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_AsButton_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665875);
				ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_VGLxgobERaraWkNZPneCMLbRAFA_Private_Static_Boolean_ControllerElementTarget_IControllerElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr, 100665876);
			}

			// Token: 0x06003B6B RID: 15211 RVA: 0x0011E3C4 File Offset: 0x0011C5C4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 258041, RefRangeEnd = 258045, XrefRangeStart = 258033, XrefRangeEnd = 258041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe xrqwjVCopyODingacGCyftGDqkL(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, FTRbVIakQDtduAElaDZqEnVrNpq target, IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> sourceElements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceElements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_String_String_ControllerTemplateElementType_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0011E48C File Offset: 0x0011C68C
			public unsafe float znCTazKQcNswsDAuGuFvCkxQqaH
			{
				[CallerCount(26)]
				[CachedScanResults(RefRangeStart = 258049, RefRangeEnd = 258075, XrefRangeStart = 258045, XrefRangeEnd = 258049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_floatValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x06003B6D RID: 15213 RVA: 0x0011E4C8 File Offset: 0x0011C6C8
			public unsafe float dimlGcURqCBsehdqGlkKkYvaSAM
			{
				[CallerCount(26)]
				[CachedScanResults(RefRangeStart = 258079, RefRangeEnd = 258105, XrefRangeStart = 258075, XrefRangeEnd = 258079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x06003B6E RID: 15214 RVA: 0x0011E504 File Offset: 0x0011C704
			public unsafe bool vXqHxLjHEAtFSEgxhbauqDNBpWu
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258110, RefRangeEnd = 258112, XrefRangeStart = 258105, XrefRangeEnd = 258110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x06003B6F RID: 15215 RVA: 0x0011E540 File Offset: 0x0011C740
			public unsafe bool hQPWNcdbRkbXEjWQKGdPyHaunq
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258117, RefRangeEnd = 258119, XrefRangeStart = 258112, XrefRangeEnd = 258117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F4 RID: 4596
			// (get) Token: 0x06003B70 RID: 15216 RVA: 0x0011E57C File Offset: 0x0011C77C
			public unsafe virtual string pgSxULnUAjqrHWCFbPPyidiusZA
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258119, XrefRangeEnd = 258123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_positiveDescriptiveName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170011F5 RID: 4597
			// (get) Token: 0x06003B71 RID: 15217 RVA: 0x0011E5B4 File Offset: 0x0011C7B4
			public unsafe virtual string bmNBaiXhqutDTJPwxKhCUDNtDkAk
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258123, XrefRangeEnd = 258127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_negativeDescriptiveName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x06003B72 RID: 15218 RVA: 0x0011E5EC File Offset: 0x0011C7EC
			public unsafe virtual float UMGiTNawJYSeQnbObKYdibZTbwZ
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258127, XrefRangeEnd = 258134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_value_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x06003B73 RID: 15219 RVA: 0x0011E628 File Offset: 0x0011C828
			public unsafe virtual float SKJCuTKxTSPnwOpdCNAsQpHGNv
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258134, XrefRangeEnd = 258141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_valuePrev_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x06003B74 RID: 15220 RVA: 0x0011E664 File Offset: 0x0011C864
			public unsafe virtual IControllerTemplateAxisSource rJSbYHJmBqQklswdEfQSuBALTuI
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258141, XrefRangeEnd = 258145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_source_Private_Virtual_Final_New_get_IControllerTemplateAxisSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxisSource>(intPtr3) : null;
				}
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x0011E6A4 File Offset: 0x0011C8A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258145, XrefRangeEnd = 258149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string LxbDackRNNESijTHElPraMsvnsiF(AxisRange A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_LxbDackRNNESijTHElPraMsvnsiF_Private_Virtual_Final_New_String_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x06003B76 RID: 15222 RVA: 0x0011E6E8 File Offset: 0x0011C8E8
			public unsafe virtual bool JUgbgoelQUpDUwBOAXUnVGJkmaw
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258149, XrefRangeEnd = 258156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_value_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FA RID: 4602
			// (get) Token: 0x06003B77 RID: 15223 RVA: 0x0011E724 File Offset: 0x0011C924
			public unsafe virtual bool FxTniwtXRbNDayjhXLgRTwieWfX
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258156, XrefRangeEnd = 258163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_valuePrev_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FB RID: 4603
			// (get) Token: 0x06003B78 RID: 15224 RVA: 0x0011E760 File Offset: 0x0011C960
			public unsafe virtual bool OhskeBGDjOMjoHRTaUPUjJcnCSYC
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258163, XrefRangeEnd = 258169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justPressed_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FC RID: 4604
			// (get) Token: 0x06003B79 RID: 15225 RVA: 0x0011E79C File Offset: 0x0011C99C
			public unsafe virtual bool ufEKLKmkWrjYXbHpoWoSFHjGjGXB
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258169, XrefRangeEnd = 258175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justReleased_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FD RID: 4605
			// (get) Token: 0x06003B7A RID: 15226 RVA: 0x0011E7D8 File Offset: 0x0011C9D8
			public unsafe virtual bool soogoCIDSHnMxmxVEpphzuGlapjB
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258175, XrefRangeEnd = 258181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justChangedState_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FE RID: 4606
			// (get) Token: 0x06003B7B RID: 15227 RVA: 0x0011E814 File Offset: 0x0011CA14
			public unsafe virtual float eNmNGTjBhEiqeaMAsAgjotfZTcu
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258181, XrefRangeEnd = 258188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressure_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011FF RID: 4607
			// (get) Token: 0x06003B7C RID: 15228 RVA: 0x0011E850 File Offset: 0x0011CA50
			public unsafe virtual float iANBjmFDNqqITDDFrHyboIPGaGq
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258188, XrefRangeEnd = 258195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressurePrev_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001200 RID: 4608
			// (get) Token: 0x06003B7D RID: 15229 RVA: 0x0011E88C File Offset: 0x0011CA8C
			public unsafe virtual IControllerTemplateButtonSource ovrFlzPsjhYIksXUfgOpXWMjkCl
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258195, XrefRangeEnd = 258199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_source_Private_Virtual_Final_New_get_IControllerTemplateButtonSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButtonSource>(intPtr3) : null;
				}
			}

			// Token: 0x17001201 RID: 4609
			// (get) Token: 0x06003B7E RID: 15230 RVA: 0x0011E8CC File Offset: 0x0011CACC
			public unsafe override IControllerTemplateElementSource source
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258199, XrefRangeEnd = 258203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementSource>(intPtr3) : null;
				}
			}

			// Token: 0x17001202 RID: 4610
			// (get) Token: 0x06003B7F RID: 15231 RVA: 0x0011E918 File Offset: 0x0011CB18
			public unsafe override int elementCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B80 RID: 15232 RVA: 0x0011E960 File Offset: 0x0011CB60
			[CallerCount(0)]
			public unsafe override IControllerTemplateElement GetElement(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_GetElement_Public_Virtual_IControllerTemplateElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
				}
			}

			// Token: 0x06003B81 RID: 15233 RVA: 0x0011E9B8 File Offset: 0x0011CBB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258203, XrefRangeEnd = 258230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(find));
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(list);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_GetElementTargets_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				list = ((intPtr4 == 0) ? null : new IList<ControllerTemplateElementTarget>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x17001203 RID: 4611
			// (get) Token: 0x06003B82 RID: 15234 RVA: 0x0011EA40 File Offset: 0x0011CC40
			public unsafe virtual IControllerTemplateAxis AsAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258230, XrefRangeEnd = 258234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_AsAxis_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001204 RID: 4612
			// (get) Token: 0x06003B83 RID: 15235 RVA: 0x0011EA80 File Offset: 0x0011CC80
			public unsafe virtual IControllerTemplateButton AsButton
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258234, XrefRangeEnd = 258238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_get_AsButton_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x06003B84 RID: 15236 RVA: 0x0011EAC0 File Offset: 0x0011CCC0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 258247, RefRangeEnd = 258251, XrefRangeStart = 258238, XrefRangeEnd = 258247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool VGLxgobERaraWkNZPneCMLbRAFA(ControllerElementTarget A_0, IControllerElementTarget A_1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeMethodInfoPtr_VGLxgobERaraWkNZPneCMLbRAFA_Private_Static_Boolean_ControllerElementTarget_IControllerElementTarget_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003B85 RID: 15237 RVA: 0x000152A1 File Offset: 0x000134A1
			public xrqwjVCopyODingacGCyftGDqkL(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011ED RID: 4589
			// (get) Token: 0x06003B86 RID: 15238 RVA: 0x0011EB18 File Offset: 0x0011CD18
			// (set) Token: 0x06003B87 RID: 15239 RVA: 0x000152AA File Offset: 0x000134AA
			public unsafe FTRbVIakQDtduAElaDZqEnVrNpq AVkxxtMdUzXDfetzWWOXzwXnkLW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_AVkxxtMdUzXDfetzWWOXzwXnkLW);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FTRbVIakQDtduAElaDZqEnVrNpq>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_AVkxxtMdUzXDfetzWWOXzwXnkLW), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011EE RID: 4590
			// (get) Token: 0x06003B88 RID: 15240 RVA: 0x0011EB48 File Offset: 0x0011CD48
			// (set) Token: 0x06003B89 RID: 15241 RVA: 0x000152C9 File Offset: 0x000134C9
			public unsafe string gAMHzMcGesZADjHMYhsNmevTMOP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_gAMHzMcGesZADjHMYhsNmevTMOP);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_gAMHzMcGesZADjHMYhsNmevTMOP), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x06003B8A RID: 15242 RVA: 0x0011EB70 File Offset: 0x0011CD70
			// (set) Token: 0x06003B8B RID: 15243 RVA: 0x000152E8 File Offset: 0x000134E8
			public unsafe string odCQoDNioxIfQALaDfWkMlfNjnMp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_odCQoDNioxIfQALaDfWkMlfNjnMp);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL.NativeFieldInfoPtr_odCQoDNioxIfQALaDfWkMlfNjnMp), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040031C6 RID: 12742
			private static readonly IntPtr NativeFieldInfoPtr_AVkxxtMdUzXDfetzWWOXzwXnkLW;

			// Token: 0x040031C7 RID: 12743
			private static readonly IntPtr NativeFieldInfoPtr_gAMHzMcGesZADjHMYhsNmevTMOP;

			// Token: 0x040031C8 RID: 12744
			private static readonly IntPtr NativeFieldInfoPtr_odCQoDNioxIfQALaDfWkMlfNjnMp;

			// Token: 0x040031C9 RID: 12745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_String_String_ControllerTemplateElementType_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0;

			// Token: 0x040031CA RID: 12746
			private static readonly IntPtr NativeMethodInfoPtr_get_floatValue_Public_get_Single_0;

			// Token: 0x040031CB RID: 12747
			private static readonly IntPtr NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0;

			// Token: 0x040031CC RID: 12748
			private static readonly IntPtr NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0;

			// Token: 0x040031CD RID: 12749
			private static readonly IntPtr NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0;

			// Token: 0x040031CE RID: 12750
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_positiveDescriptiveName_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040031CF RID: 12751
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_negativeDescriptiveName_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040031D0 RID: 12752
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_value_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x040031D1 RID: 12753
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_valuePrev_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x040031D2 RID: 12754
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateAxis_get_source_Private_Virtual_Final_New_get_IControllerTemplateAxisSource_0;

			// Token: 0x040031D3 RID: 12755
			private static readonly IntPtr NativeMethodInfoPtr_LxbDackRNNESijTHElPraMsvnsiF_Private_Virtual_Final_New_String_AxisRange_0;

			// Token: 0x040031D4 RID: 12756
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_value_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040031D5 RID: 12757
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_valuePrev_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040031D6 RID: 12758
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justPressed_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040031D7 RID: 12759
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justReleased_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040031D8 RID: 12760
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_justChangedState_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040031D9 RID: 12761
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressure_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x040031DA RID: 12762
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_pressurePrev_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x040031DB RID: 12763
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_IControllerTemplateButton_get_source_Private_Virtual_Final_New_get_IControllerTemplateButtonSource_0;

			// Token: 0x040031DC RID: 12764
			private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0;

			// Token: 0x040031DD RID: 12765
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0;

			// Token: 0x040031DE RID: 12766
			private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Virtual_IControllerTemplateElement_Int32_0;

			// Token: 0x040031DF RID: 12767
			private static readonly IntPtr NativeMethodInfoPtr_GetElementTargets_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0;

			// Token: 0x040031E0 RID: 12768
			private static readonly IntPtr NativeMethodInfoPtr_get_AsAxis_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x040031E1 RID: 12769
			private static readonly IntPtr NativeMethodInfoPtr_get_AsButton_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x040031E2 RID: 12770
			private static readonly IntPtr NativeMethodInfoPtr_VGLxgobERaraWkNZPneCMLbRAFA_Private_Static_Boolean_ControllerElementTarget_IControllerElementTarget_0;
		}

		// Token: 0x0200028F RID: 655
		public sealed class OPawqylOUKSSoTKmBZLjUVcWkAU : ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL
		{
			// Token: 0x06003B8C RID: 15244 RVA: 0x0011EB98 File Offset: 0x0011CD98
			// Note: this type is marked as 'beforefieldinit'.
			static OPawqylOUKSSoTKmBZLjUVcWkAU()
			{
				Il2CppClassPointerStore<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "OPawqylOUKSSoTKmBZLjUVcWkAU");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>.NativeClassPtr);
				ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>.NativeClassPtr, 100665877);
				ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_OPawqylOUKSSoTKmBZLjUVcWkAU_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>.NativeClassPtr, 100665878);
			}

			// Token: 0x06003B8D RID: 15245 RVA: 0x0011EBEC File Offset: 0x0011CDEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258255, RefRangeEnd = 258256, XrefRangeStart = 258251, XrefRangeEnd = 258255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OPawqylOUKSSoTKmBZLjUVcWkAU(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, FTRbVIakQDtduAElaDZqEnVrNpq target, IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> sourceElements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceElements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B8E RID: 15246 RVA: 0x0011ECA4 File Offset: 0x0011CEA4
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 258264, RefRangeEnd = 258279, XrefRangeStart = 258256, XrefRangeEnd = 258264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU vlHkkxaKIMBHKYWpINVenaDBhUm(IControllerTemplate A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_OPawqylOUKSSoTKmBZLjUVcWkAU_IControllerTemplate_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplate.OPawqylOUKSSoTKmBZLjUVcWkAU>(intPtr3) : null;
				}
			}

			// Token: 0x06003B8F RID: 15247 RVA: 0x00015307 File Offset: 0x00013507
			public OPawqylOUKSSoTKmBZLjUVcWkAU(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040031E3 RID: 12771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0;

			// Token: 0x040031E4 RID: 12772
			private static readonly IntPtr NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_OPawqylOUKSSoTKmBZLjUVcWkAU_IControllerTemplate_0;
		}

		// Token: 0x02000290 RID: 656
		public sealed class paGpvlkMlOuzpAceKiNBtpmHPfR : ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL
		{
			// Token: 0x06003B90 RID: 15248 RVA: 0x0011ECE8 File Offset: 0x0011CEE8
			// Note: this type is marked as 'beforefieldinit'.
			static paGpvlkMlOuzpAceKiNBtpmHPfR()
			{
				Il2CppClassPointerStore<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "paGpvlkMlOuzpAceKiNBtpmHPfR");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>.NativeClassPtr);
				ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>.NativeClassPtr, 100665879);
				ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_paGpvlkMlOuzpAceKiNBtpmHPfR_IControllerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>.NativeClassPtr, 100665880);
			}

			// Token: 0x06003B91 RID: 15249 RVA: 0x0011ED3C File Offset: 0x0011CF3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258283, RefRangeEnd = 258284, XrefRangeStart = 258279, XrefRangeEnd = 258283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe paGpvlkMlOuzpAceKiNBtpmHPfR(IControllerTemplate parent, int id, string name, string positiveName, string negativeName, FTRbVIakQDtduAElaDZqEnVrNpq target, IList<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz> sourceElements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positiveName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(negativeName);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceElements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B92 RID: 15250 RVA: 0x0011EDF4 File Offset: 0x0011CFF4
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 258292, RefRangeEnd = 258308, XrefRangeStart = 258284, XrefRangeEnd = 258292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR vlHkkxaKIMBHKYWpINVenaDBhUm(IControllerTemplate A_0)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_paGpvlkMlOuzpAceKiNBtpmHPfR_IControllerTemplate_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplate.paGpvlkMlOuzpAceKiNBtpmHPfR>(intPtr3) : null;
				}
			}

			// Token: 0x06003B93 RID: 15251 RVA: 0x00015310 File Offset: 0x00013510
			public paGpvlkMlOuzpAceKiNBtpmHPfR(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040031E5 RID: 12773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_String_String_FTRbVIakQDtduAElaDZqEnVrNpq_IList_1_YaxBHmiEXToVwhxMaTvPbcyzTpz_0;

			// Token: 0x040031E6 RID: 12774
			private static readonly IntPtr NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Internal_Static_paGpvlkMlOuzpAceKiNBtpmHPfR_IControllerTemplate_0;
		}

		// Token: 0x02000291 RID: 657
		public class TeEFfeUuavQUqWQcSiuCNHaZfHR : ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG
		{
			// Token: 0x06003B94 RID: 15252 RVA: 0x0011EE38 File Offset: 0x0011D038
			// Note: this type is marked as 'beforefieldinit'.
			static TeEFfeUuavQUqWQcSiuCNHaZfHR()
			{
				Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "TeEFfeUuavQUqWQcSiuCNHaZfHR");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, "bmcVHPhFqcClKFnlNjKbtEssOMVv");
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, "xQkGABJRsmzTPSmeXgqJmJTMBma");
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665881);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665882);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665883);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665884);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Public_Virtual_IControllerTemplateElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665885);
				ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr, 100665886);
			}

			// Token: 0x06003B95 RID: 15253 RVA: 0x0011EF04 File Offset: 0x0011D104
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 258310, RefRangeEnd = 258327, XrefRangeStart = 258308, XrefRangeEnd = 258310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TeEFfeUuavQUqWQcSiuCNHaZfHR(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001207 RID: 4615
			// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0011EF90 File Offset: 0x0011D190
			public unsafe override bool BKgAAYYDRlfKHVKytbUtlZMUffg
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258327, XrefRangeEnd = 258331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001208 RID: 4616
			// (get) Token: 0x06003B97 RID: 15255 RVA: 0x0011EFD8 File Offset: 0x0011D1D8
			public unsafe override IControllerTemplateElementSource biBJftmjAXeWoBqMpeqfZEjZwtg
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258331, XrefRangeEnd = 258337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElementSource>(intPtr3) : null;
				}
			}

			// Token: 0x17001209 RID: 4617
			// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0011F024 File Offset: 0x0011D224
			public unsafe override int TqNhowXkMSdyvCoxdcpOaUxhnNSd
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003B99 RID: 15257 RVA: 0x0011F06C File Offset: 0x0011D26C
			[CallerCount(0)]
			public unsafe override IControllerTemplateElement ffDeAbKJpVsIgLYjXxEUfwosxXOK(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Public_Virtual_IControllerTemplateElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateElement>(intPtr3) : null;
				}
			}

			// Token: 0x06003B9A RID: 15258 RVA: 0x0011F0C4 File Offset: 0x0011D2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258337, XrefRangeEnd = 258338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int tgZDemgXSXTDHPCCrMqaNPbkJdJd(ControllerElementTarget A_1, ref IList<ControllerTemplateElementTarget> A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1));
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(A_2);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				A_2 = ((intPtr4 == 0) ? null : new IList<ControllerTemplateElementTarget>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06003B9B RID: 15259 RVA: 0x00015319 File Offset: 0x00013519
			public TeEFfeUuavQUqWQcSiuCNHaZfHR(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001205 RID: 4613
			// (get) Token: 0x06003B9C RID: 15260 RVA: 0x0011F14C File Offset: 0x0011D34C
			// (set) Token: 0x06003B9D RID: 15261 RVA: 0x00015322 File Offset: 0x00013522
			public unsafe int bmcVHPhFqcClKFnlNjKbtEssOMVv
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv)) = value;
				}
			}

			// Token: 0x17001206 RID: 4614
			// (get) Token: 0x06003B9E RID: 15262 RVA: 0x0011F174 File Offset: 0x0011D374
			// (set) Token: 0x06003B9F RID: 15263 RVA: 0x0001533D File Offset: 0x0001353D
			public unsafe Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> xQkGABJRsmzTPSmeXgqJmJTMBma
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040031E7 RID: 12775
			private static readonly IntPtr NativeFieldInfoPtr_bmcVHPhFqcClKFnlNjKbtEssOMVv;

			// Token: 0x040031E8 RID: 12776
			private static readonly IntPtr NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma;

			// Token: 0x040031E9 RID: 12777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x040031EA RID: 12778
			private static readonly IntPtr NativeMethodInfoPtr_get_exists_Public_Virtual_get_Boolean_0;

			// Token: 0x040031EB RID: 12779
			private static readonly IntPtr NativeMethodInfoPtr_get_source_Public_Virtual_get_IControllerTemplateElementSource_0;

			// Token: 0x040031EC RID: 12780
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Virtual_get_Int32_0;

			// Token: 0x040031ED RID: 12781
			private static readonly IntPtr NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Public_Virtual_IControllerTemplateElement_Int32_0;

			// Token: 0x040031EE RID: 12782
			private static readonly IntPtr NativeMethodInfoPtr_tgZDemgXSXTDHPCCrMqaNPbkJdJd_Public_Virtual_Int32_ControllerElementTarget_byref_IList_1_ControllerTemplateElementTarget_0;
		}

		// Token: 0x02000292 RID: 658
		public class jVblzCZOGILPHqDOesHYvegkCid : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003BA0 RID: 15264 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
			// Note: this type is marked as 'beforefieldinit'.
			static jVblzCZOGILPHqDOesHYvegkCid()
			{
				Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "jVblzCZOGILPHqDOesHYvegkCid");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr);
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, "VuNtfSShWAqeaQqQEFcvvjLFjka");
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, "yCKlRrTGKbJjxmiFFEhFhDPnnRCe");
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, 100665887);
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, 100665888);
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, 100665889);
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, 100665890);
				ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr, 100665891);
			}

			// Token: 0x06003BA1 RID: 15265 RVA: 0x0011F270 File Offset: 0x0011D470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258338, XrefRangeEnd = 258339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe jVblzCZOGILPHqDOesHYvegkCid(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700120D RID: 4621
			// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x0011F2FC File Offset: 0x0011D4FC
			public unsafe virtual Vector2 value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258339, XrefRangeEnd = 258349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700120E RID: 4622
			// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x0011F338 File Offset: 0x0011D538
			public unsafe virtual Vector2 valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258349, XrefRangeEnd = 258359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700120F RID: 4623
			// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x0011F374 File Offset: 0x0011D574
			public unsafe virtual IControllerTemplateAxis horizontal
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258359, XrefRangeEnd = 258369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001210 RID: 4624
			// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x0011F3B4 File Offset: 0x0011D5B4
			public unsafe virtual IControllerTemplateAxis vertical
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258369, XrefRangeEnd = 258379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003BA6 RID: 15270 RVA: 0x0001535C File Offset: 0x0001355C
			public jVblzCZOGILPHqDOesHYvegkCid(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700120A RID: 4618
			// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x0011F3F4 File Offset: 0x0011D5F4
			// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x00015365 File Offset: 0x00013565
			public unsafe static int VuNtfSShWAqeaQqQEFcvvjLFjka
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka, (void*)(&value));
				}
			}

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0011F410 File Offset: 0x0011D610
			// (set) Token: 0x06003BAA RID: 15274 RVA: 0x00015373 File Offset: 0x00013573
			public unsafe static int yCKlRrTGKbJjxmiFFEhFhDPnnRCe
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe, (void*)(&value));
				}
			}

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x06003BAB RID: 15275 RVA: 0x0011F42C File Offset: 0x0011D62C
			// (set) Token: 0x06003BAC RID: 15276 RVA: 0x00015381 File Offset: 0x00013581
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x040031EF RID: 12783
			private static readonly IntPtr NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka;

			// Token: 0x040031F0 RID: 12784
			private static readonly IntPtr NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe;

			// Token: 0x040031F1 RID: 12785
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x040031F2 RID: 12786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x040031F3 RID: 12787
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x040031F4 RID: 12788
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x040031F5 RID: 12789
			private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x040031F6 RID: 12790
			private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;
		}

		// Token: 0x02000293 RID: 659
		public class lEfyqnrnjkAEygTXwmxtylGfvDIx : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003BAD RID: 15277 RVA: 0x0011F448 File Offset: 0x0011D648
			// Note: this type is marked as 'beforefieldinit'.
			static lEfyqnrnjkAEygTXwmxtylGfvDIx()
			{
				Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "lEfyqnrnjkAEygTXwmxtylGfvDIx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, "VuNtfSShWAqeaQqQEFcvvjLFjka");
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, "yCKlRrTGKbJjxmiFFEhFhDPnnRCe");
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_oFfkAHdysQavCfmWMNsEFCiqcXU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, "oFfkAHdysQavCfmWMNsEFCiqcXU");
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665892);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665893);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665894);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665895);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665896);
				ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_depth_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr, 100665897);
			}

			// Token: 0x06003BAE RID: 15278 RVA: 0x0011F53C File Offset: 0x0011D73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe lEfyqnrnjkAEygTXwmxtylGfvDIx(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06003BAF RID: 15279 RVA: 0x0011F5C8 File Offset: 0x0011D7C8
			public unsafe virtual Vector3 value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258379, XrefRangeEnd = 258391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x0011F604 File Offset: 0x0011D804
			public unsafe virtual Vector3 valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258391, XrefRangeEnd = 258403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x0011F640 File Offset: 0x0011D840
			public unsafe virtual IControllerTemplateAxis horizontal
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258403, XrefRangeEnd = 258413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x0011F680 File Offset: 0x0011D880
			public unsafe virtual IControllerTemplateAxis vertical
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258413, XrefRangeEnd = 258423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x0011F6C0 File Offset: 0x0011D8C0
			public unsafe virtual IControllerTemplateAxis depth
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258423, XrefRangeEnd = 258433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeMethodInfoPtr_get_depth_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003BB4 RID: 15284 RVA: 0x0001538F File Offset: 0x0001358F
			public lEfyqnrnjkAEygTXwmxtylGfvDIx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x0011F700 File Offset: 0x0011D900
			// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x00015398 File Offset: 0x00013598
			public unsafe static int VuNtfSShWAqeaQqQEFcvvjLFjka
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka, (void*)(&value));
				}
			}

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x0011F71C File Offset: 0x0011D91C
			// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x000153A6 File Offset: 0x000135A6
			public unsafe static int yCKlRrTGKbJjxmiFFEhFhDPnnRCe
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe, (void*)(&value));
				}
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x0011F738 File Offset: 0x0011D938
			// (set) Token: 0x06003BBA RID: 15290 RVA: 0x000153B4 File Offset: 0x000135B4
			public unsafe static int oFfkAHdysQavCfmWMNsEFCiqcXU
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_oFfkAHdysQavCfmWMNsEFCiqcXU, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_oFfkAHdysQavCfmWMNsEFCiqcXU, (void*)(&value));
				}
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x06003BBB RID: 15291 RVA: 0x0011F754 File Offset: 0x0011D954
			// (set) Token: 0x06003BBC RID: 15292 RVA: 0x000153C2 File Offset: 0x000135C2
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x040031F7 RID: 12791
			private static readonly IntPtr NativeFieldInfoPtr_VuNtfSShWAqeaQqQEFcvvjLFjka;

			// Token: 0x040031F8 RID: 12792
			private static readonly IntPtr NativeFieldInfoPtr_yCKlRrTGKbJjxmiFFEhFhDPnnRCe;

			// Token: 0x040031F9 RID: 12793
			private static readonly IntPtr NativeFieldInfoPtr_oFfkAHdysQavCfmWMNsEFCiqcXU;

			// Token: 0x040031FA RID: 12794
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x040031FB RID: 12795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x040031FC RID: 12796
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x040031FD RID: 12797
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x040031FE RID: 12798
			private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x040031FF RID: 12799
			private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x04003200 RID: 12800
			private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;
		}

		// Token: 0x02000294 RID: 660
		public class FmJClzYqmMtYyAiTZBQYzeLHgEOk : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003BBD RID: 15293 RVA: 0x0011F770 File Offset: 0x0011D970
			// Note: this type is marked as 'beforefieldinit'.
			static FmJClzYqmMtYyAiTZBQYzeLHgEOk()
			{
				Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "FmJClzYqmMtYyAiTZBQYzeLHgEOk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_pwfQtxUaGvEJsiZhzDtzgPiomaG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "pwfQtxUaGvEJsiZhzDtzgPiomaG");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_mDyBQznGjHQvJPRhJFhIpVqRMiE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "mDyBQznGjHQvJPRhJFhIpVqRMiE");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_FeUOpzlsIQriZqgcVxpirHrUJjw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "FeUOpzlsIQriZqgcVxpirHrUJjw");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_itIMRSXmsdSJboOJCHYxBjkGkxYW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "itIMRSXmsdSJboOJCHYxBjkGkxYW");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_NShmCQYMgUIrWULkCLgRDDLPhSB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "NShmCQYMgUIrWULkCLgRDDLPhSB");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZQESpprDjomCOvuyWZwoFftKCbS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "ZQESpprDjomCOvuyWZwoFftKCbS");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665898);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665899);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionPrev_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665900);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665901);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationPrev_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665902);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665903);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665904);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665905);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665906);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665907);
				ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr, 100665908);
			}

			// Token: 0x06003BBE RID: 15294 RVA: 0x0011F904 File Offset: 0x0011DB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FmJClzYqmMtYyAiTZBQYzeLHgEOk(IControllerTemplate parent, int id, string name, ControllerTemplateElementType elementType, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x06003BBF RID: 15295 RVA: 0x0011F990 File Offset: 0x0011DB90
			public unsafe virtual Vector3 position
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258433, XrefRangeEnd = 258445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001222 RID: 4642
			// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x0011F9CC File Offset: 0x0011DBCC
			public unsafe virtual Vector3 positionPrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258445, XrefRangeEnd = 258457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionPrev_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x0011FA08 File Offset: 0x0011DC08
			public unsafe virtual Vector3 rotation
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258457, XrefRangeEnd = 258469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x0011FA44 File Offset: 0x0011DC44
			public unsafe virtual Vector3 rotationPrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258469, XrefRangeEnd = 258481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationPrev_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001225 RID: 4645
			// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x0011FA80 File Offset: 0x0011DC80
			public unsafe virtual IControllerTemplateAxis positionX
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258481, XrefRangeEnd = 258491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001226 RID: 4646
			// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0011FAC0 File Offset: 0x0011DCC0
			public unsafe virtual IControllerTemplateAxis positionY
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258491, XrefRangeEnd = 258501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001227 RID: 4647
			// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x0011FB00 File Offset: 0x0011DD00
			public unsafe virtual IControllerTemplateAxis positionZ
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258501, XrefRangeEnd = 258511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_positionZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001228 RID: 4648
			// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0011FB40 File Offset: 0x0011DD40
			public unsafe virtual IControllerTemplateAxis rotationX
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258511, XrefRangeEnd = 258521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001229 RID: 4649
			// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x0011FB80 File Offset: 0x0011DD80
			public unsafe virtual IControllerTemplateAxis rotationY
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258521, XrefRangeEnd = 258531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x1700122A RID: 4650
			// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x0011FBC0 File Offset: 0x0011DDC0
			public unsafe virtual IControllerTemplateAxis rotationZ
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258531, XrefRangeEnd = 258541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeMethodInfoPtr_get_rotationZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003BC9 RID: 15305 RVA: 0x000153D0 File Offset: 0x000135D0
			public FmJClzYqmMtYyAiTZBQYzeLHgEOk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x06003BCA RID: 15306 RVA: 0x0011FC00 File Offset: 0x0011DE00
			// (set) Token: 0x06003BCB RID: 15307 RVA: 0x000153D9 File Offset: 0x000135D9
			public unsafe static int pwfQtxUaGvEJsiZhzDtzgPiomaG
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_pwfQtxUaGvEJsiZhzDtzgPiomaG, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_pwfQtxUaGvEJsiZhzDtzgPiomaG, (void*)(&value));
				}
			}

			// Token: 0x1700121B RID: 4635
			// (get) Token: 0x06003BCC RID: 15308 RVA: 0x0011FC1C File Offset: 0x0011DE1C
			// (set) Token: 0x06003BCD RID: 15309 RVA: 0x000153E7 File Offset: 0x000135E7
			public unsafe static int mDyBQznGjHQvJPRhJFhIpVqRMiE
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_mDyBQznGjHQvJPRhJFhIpVqRMiE, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_mDyBQznGjHQvJPRhJFhIpVqRMiE, (void*)(&value));
				}
			}

			// Token: 0x1700121C RID: 4636
			// (get) Token: 0x06003BCE RID: 15310 RVA: 0x0011FC38 File Offset: 0x0011DE38
			// (set) Token: 0x06003BCF RID: 15311 RVA: 0x000153F5 File Offset: 0x000135F5
			public unsafe static int FeUOpzlsIQriZqgcVxpirHrUJjw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_FeUOpzlsIQriZqgcVxpirHrUJjw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_FeUOpzlsIQriZqgcVxpirHrUJjw, (void*)(&value));
				}
			}

			// Token: 0x1700121D RID: 4637
			// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x0011FC54 File Offset: 0x0011DE54
			// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x00015403 File Offset: 0x00013603
			public unsafe static int itIMRSXmsdSJboOJCHYxBjkGkxYW
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_itIMRSXmsdSJboOJCHYxBjkGkxYW, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_itIMRSXmsdSJboOJCHYxBjkGkxYW, (void*)(&value));
				}
			}

			// Token: 0x1700121E RID: 4638
			// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x0011FC70 File Offset: 0x0011DE70
			// (set) Token: 0x06003BD3 RID: 15315 RVA: 0x00015411 File Offset: 0x00013611
			public unsafe static int NShmCQYMgUIrWULkCLgRDDLPhSB
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_NShmCQYMgUIrWULkCLgRDDLPhSB, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_NShmCQYMgUIrWULkCLgRDDLPhSB, (void*)(&value));
				}
			}

			// Token: 0x1700121F RID: 4639
			// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x0011FC8C File Offset: 0x0011DE8C
			// (set) Token: 0x06003BD5 RID: 15317 RVA: 0x0001541F File Offset: 0x0001361F
			public unsafe static int ZQESpprDjomCOvuyWZwoFftKCbS
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZQESpprDjomCOvuyWZwoFftKCbS, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZQESpprDjomCOvuyWZwoFftKCbS, (void*)(&value));
				}
			}

			// Token: 0x17001220 RID: 4640
			// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x0011FCA8 File Offset: 0x0011DEA8
			// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x0001542D File Offset: 0x0001362D
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x04003201 RID: 12801
			private static readonly IntPtr NativeFieldInfoPtr_pwfQtxUaGvEJsiZhzDtzgPiomaG;

			// Token: 0x04003202 RID: 12802
			private static readonly IntPtr NativeFieldInfoPtr_mDyBQznGjHQvJPRhJFhIpVqRMiE;

			// Token: 0x04003203 RID: 12803
			private static readonly IntPtr NativeFieldInfoPtr_FeUOpzlsIQriZqgcVxpirHrUJjw;

			// Token: 0x04003204 RID: 12804
			private static readonly IntPtr NativeFieldInfoPtr_itIMRSXmsdSJboOJCHYxBjkGkxYW;

			// Token: 0x04003205 RID: 12805
			private static readonly IntPtr NativeFieldInfoPtr_NShmCQYMgUIrWULkCLgRDDLPhSB;

			// Token: 0x04003206 RID: 12806
			private static readonly IntPtr NativeFieldInfoPtr_ZQESpprDjomCOvuyWZwoFftKCbS;

			// Token: 0x04003207 RID: 12807
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x04003208 RID: 12808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IControllerTemplate_Int32_String_ControllerTemplateElementType_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x04003209 RID: 12809
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400320A RID: 12810
			private static readonly IntPtr NativeMethodInfoPtr_get_positionPrev_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400320B RID: 12811
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400320C RID: 12812
			private static readonly IntPtr NativeMethodInfoPtr_get_rotationPrev_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x0400320D RID: 12813
			private static readonly IntPtr NativeMethodInfoPtr_get_positionX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x0400320E RID: 12814
			private static readonly IntPtr NativeMethodInfoPtr_get_positionY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x0400320F RID: 12815
			private static readonly IntPtr NativeMethodInfoPtr_get_positionZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x04003210 RID: 12816
			private static readonly IntPtr NativeMethodInfoPtr_get_rotationX_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x04003211 RID: 12817
			private static readonly IntPtr NativeMethodInfoPtr_get_rotationY_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x04003212 RID: 12818
			private static readonly IntPtr NativeMethodInfoPtr_get_rotationZ_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;
		}

		// Token: 0x02000295 RID: 661
		public sealed class BYNbKrBGRqNXeXfwnFpAwYwWEdTD : ControllerTemplate.lEfyqnrnjkAEygTXwmxtylGfvDIx
		{
			// Token: 0x06003BD8 RID: 15320 RVA: 0x0011FCC4 File Offset: 0x0011DEC4
			// Note: this type is marked as 'beforefieldinit'.
			static BYNbKrBGRqNXeXfwnFpAwYwWEdTD()
			{
				Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "BYNbKrBGRqNXeXfwnFpAwYwWEdTD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr);
				ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr, 100665909);
				ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr, 100665910);
				ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr, 100665911);
			}

			// Token: 0x06003BD9 RID: 15321 RVA: 0x0011FD40 File Offset: 0x0011DF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258541, XrefRangeEnd = 258542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BYNbKrBGRqNXeXfwnFpAwYwWEdTD(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BDA RID: 15322 RVA: 0x0011FDC0 File Offset: 0x0011DFC0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258552, RefRangeEnd = 258553, XrefRangeStart = 258542, XrefRangeEnd = 258552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BYNbKrBGRqNXeXfwnFpAwYwWEdTD(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL xAxis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL yAxis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL zAxis)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zAxis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x06003BDB RID: 15323 RVA: 0x0011FE64 File Offset: 0x0011E064
			public unsafe IControllerTemplateAxis rotation
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258553, XrefRangeEnd = 258563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003BDC RID: 15324 RVA: 0x0001543B File Offset: 0x0001363B
			public BYNbKrBGRqNXeXfwnFpAwYwWEdTD(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122B RID: 4651
			// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0011FEA4 File Offset: 0x0011E0A4
			// (set) Token: 0x06003BDE RID: 15326 RVA: 0x00015444 File Offset: 0x00013644
			public new unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.BYNbKrBGRqNXeXfwnFpAwYwWEdTD.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x04003213 RID: 12819
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x04003214 RID: 12820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x04003215 RID: 12821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x04003216 RID: 12822
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;
		}

		// Token: 0x02000296 RID: 662
		public sealed class GHeAjLuWyJEzSCsVKOKDFkNNsec : ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid
		{
			// Token: 0x06003BDF RID: 15327 RVA: 0x0011FEC0 File Offset: 0x0011E0C0
			// Note: this type is marked as 'beforefieldinit'.
			static GHeAjLuWyJEzSCsVKOKDFkNNsec()
			{
				Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "GHeAjLuWyJEzSCsVKOKDFkNNsec");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr);
				ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_HrqFyORYtcYgUocredyBLdEVeea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr, "HrqFyORYtcYgUocredyBLdEVeea");
				ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr, 100665912);
				ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr, 100665913);
				ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr, 100665914);
			}

			// Token: 0x06003BE0 RID: 15328 RVA: 0x0011FF50 File Offset: 0x0011E150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258563, XrefRangeEnd = 258564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GHeAjLuWyJEzSCsVKOKDFkNNsec(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BE1 RID: 15329 RVA: 0x0011FFD0 File Offset: 0x0011E1D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258574, RefRangeEnd = 258575, XrefRangeStart = 258564, XrefRangeEnd = 258574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GHeAjLuWyJEzSCsVKOKDFkNNsec(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL xAxis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL yAxis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL button)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700122F RID: 4655
			// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x00120074 File Offset: 0x0011E274
			public unsafe IControllerTemplateButton press
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258575, XrefRangeEnd = 258585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x06003BE3 RID: 15331 RVA: 0x00015452 File Offset: 0x00013652
			public GHeAjLuWyJEzSCsVKOKDFkNNsec(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x001200B4 File Offset: 0x0011E2B4
			// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x0001545B File Offset: 0x0001365B
			public unsafe static int HrqFyORYtcYgUocredyBLdEVeea
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_HrqFyORYtcYgUocredyBLdEVeea, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_HrqFyORYtcYgUocredyBLdEVeea, (void*)(&value));
				}
			}

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x001200D0 File Offset: 0x0011E2D0
			// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00015469 File Offset: 0x00013669
			public new unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.GHeAjLuWyJEzSCsVKOKDFkNNsec.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x04003217 RID: 12823
			private static readonly IntPtr NativeFieldInfoPtr_HrqFyORYtcYgUocredyBLdEVeea;

			// Token: 0x04003218 RID: 12824
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x04003219 RID: 12825
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x0400321A RID: 12826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x0400321B RID: 12827
			private static readonly IntPtr NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0;
		}

		// Token: 0x02000297 RID: 663
		public sealed class kcNpfODNLCunrUTacfqYCoPuCYy : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003BE8 RID: 15336 RVA: 0x001200EC File Offset: 0x0011E2EC
			// Note: this type is marked as 'beforefieldinit'.
			static kcNpfODNLCunrUTacfqYCoPuCYy()
			{
				Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "kcNpfODNLCunrUTacfqYCoPuCYy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "JNsVRJuidmGGptuYkyrLeOPrUGf");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "UHyMaPGHANrtUdATGcsnpQWjZPv");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "gEiUUxkYNQnyLvuoOuqdqUdENWS");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "KUWYKKpGaQgLJjiAIGXXGiJKoIs");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_kmdonJtasSNlBbnVVhYiddqSyKm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "kmdonJtasSNlBbnVVhYiddqSyKm");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665915);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665916);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665917);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665918);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665919);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665920);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665921);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665922);
				ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr, 100665923);
			}

			// Token: 0x06003BE9 RID: 15337 RVA: 0x00120244 File Offset: 0x0011E444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258585, XrefRangeEnd = 258586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe kcNpfODNLCunrUTacfqYCoPuCYy(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BEA RID: 15338 RVA: 0x001202C4 File Offset: 0x0011E4C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258600, RefRangeEnd = 258601, XrefRangeStart = 258586, XrefRangeEnd = 258600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe kcNpfODNLCunrUTacfqYCoPuCYy(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL up, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL right, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL down, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL left, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL press)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(down);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x06003BEB RID: 15339 RVA: 0x00120390 File Offset: 0x0011E590
			public unsafe Vector2 value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258601, XrefRangeEnd = 258616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001237 RID: 4663
			// (get) Token: 0x06003BEC RID: 15340 RVA: 0x001203CC File Offset: 0x0011E5CC
			public unsafe Vector2 valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258616, XrefRangeEnd = 258631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001238 RID: 4664
			// (get) Token: 0x06003BED RID: 15341 RVA: 0x00120408 File Offset: 0x0011E608
			public unsafe IControllerTemplateButton up
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258631, XrefRangeEnd = 258641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001239 RID: 4665
			// (get) Token: 0x06003BEE RID: 15342 RVA: 0x00120448 File Offset: 0x0011E648
			public unsafe IControllerTemplateButton right
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258641, XrefRangeEnd = 258651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x06003BEF RID: 15343 RVA: 0x00120488 File Offset: 0x0011E688
			public unsafe IControllerTemplateButton down
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258651, XrefRangeEnd = 258661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x1700123B RID: 4667
			// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x001204C8 File Offset: 0x0011E6C8
			public unsafe IControllerTemplateButton left
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258661, XrefRangeEnd = 258671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x1700123C RID: 4668
			// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00120508 File Offset: 0x0011E708
			public unsafe IControllerTemplateButton press
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258671, XrefRangeEnd = 258681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x06003BF2 RID: 15346 RVA: 0x00015477 File Offset: 0x00013677
			public kcNpfODNLCunrUTacfqYCoPuCYy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001230 RID: 4656
			// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00120548 File Offset: 0x0011E748
			// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x00015480 File Offset: 0x00013680
			public unsafe static int JNsVRJuidmGGptuYkyrLeOPrUGf
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf, (void*)(&value));
				}
			}

			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00120564 File Offset: 0x0011E764
			// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x0001548E File Offset: 0x0001368E
			public unsafe static int UHyMaPGHANrtUdATGcsnpQWjZPv
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv, (void*)(&value));
				}
			}

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x00120580 File Offset: 0x0011E780
			// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x0001549C File Offset: 0x0001369C
			public unsafe static int gEiUUxkYNQnyLvuoOuqdqUdENWS
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS, (void*)(&value));
				}
			}

			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x0012059C File Offset: 0x0011E79C
			// (set) Token: 0x06003BFA RID: 15354 RVA: 0x000154AA File Offset: 0x000136AA
			public unsafe static int KUWYKKpGaQgLJjiAIGXXGiJKoIs
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs, (void*)(&value));
				}
			}

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x06003BFB RID: 15355 RVA: 0x001205B8 File Offset: 0x0011E7B8
			// (set) Token: 0x06003BFC RID: 15356 RVA: 0x000154B8 File Offset: 0x000136B8
			public unsafe static int kmdonJtasSNlBbnVVhYiddqSyKm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_kmdonJtasSNlBbnVVhYiddqSyKm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_kmdonJtasSNlBbnVVhYiddqSyKm, (void*)(&value));
				}
			}

			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x06003BFD RID: 15357 RVA: 0x001205D4 File Offset: 0x0011E7D4
			// (set) Token: 0x06003BFE RID: 15358 RVA: 0x000154C6 File Offset: 0x000136C6
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kcNpfODNLCunrUTacfqYCoPuCYy.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x0400321C RID: 12828
			private static readonly IntPtr NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf;

			// Token: 0x0400321D RID: 12829
			private static readonly IntPtr NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv;

			// Token: 0x0400321E RID: 12830
			private static readonly IntPtr NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS;

			// Token: 0x0400321F RID: 12831
			private static readonly IntPtr NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs;

			// Token: 0x04003220 RID: 12832
			private static readonly IntPtr NativeFieldInfoPtr_kmdonJtasSNlBbnVVhYiddqSyKm;

			// Token: 0x04003221 RID: 12833
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x04003222 RID: 12834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x04003223 RID: 12835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x04003224 RID: 12836
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04003225 RID: 12837
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04003226 RID: 12838
			private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003227 RID: 12839
			private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003228 RID: 12840
			private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003229 RID: 12841
			private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x0400322A RID: 12842
			private static readonly IntPtr NativeMethodInfoPtr_get_press_Public_Virtual_Final_New_get_IControllerTemplateButton_0;
		}

		// Token: 0x02000298 RID: 664
		public sealed class tFxXgkEotEDZKwRMGmBJNYUychC : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003BFF RID: 15359 RVA: 0x001205F0 File Offset: 0x0011E7F0
			// Note: this type is marked as 'beforefieldinit'.
			static tFxXgkEotEDZKwRMGmBJNYUychC()
			{
				Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "tFxXgkEotEDZKwRMGmBJNYUychC");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_yQKpiKChKKCBLcQxoNzVGwpltJcF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, "yQKpiKChKKCBLcQxoNzVGwpltJcF");
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_vNhFYJOczEwOfsizCsKCmScceme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, "vNhFYJOczEwOfsizCsKCmScceme");
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665924);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665925);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665926);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665927);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_throttle_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665928);
				ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_minDetent_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr, 100665929);
			}

			// Token: 0x06003C00 RID: 15360 RVA: 0x001206D0 File Offset: 0x0011E8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258681, XrefRangeEnd = 258682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe tFxXgkEotEDZKwRMGmBJNYUychC(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C01 RID: 15361 RVA: 0x00120750 File Offset: 0x0011E950
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258690, RefRangeEnd = 258691, XrefRangeStart = 258682, XrefRangeEnd = 258690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe tFxXgkEotEDZKwRMGmBJNYUychC(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL axis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL zeroDetentButton)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(zeroDetentButton);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001240 RID: 4672
			// (get) Token: 0x06003C02 RID: 15362 RVA: 0x001207E4 File Offset: 0x0011E9E4
			public unsafe float value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258691, XrefRangeEnd = 258700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001241 RID: 4673
			// (get) Token: 0x06003C03 RID: 15363 RVA: 0x00120820 File Offset: 0x0011EA20
			public unsafe float valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258700, XrefRangeEnd = 258709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001242 RID: 4674
			// (get) Token: 0x06003C04 RID: 15364 RVA: 0x0012085C File Offset: 0x0011EA5C
			public unsafe IControllerTemplateAxis throttle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258709, XrefRangeEnd = 258719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_throttle_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001243 RID: 4675
			// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0012089C File Offset: 0x0011EA9C
			public unsafe IControllerTemplateButton minDetent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258719, XrefRangeEnd = 258729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeMethodInfoPtr_get_minDetent_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x06003C06 RID: 15366 RVA: 0x000154D4 File Offset: 0x000136D4
			public tFxXgkEotEDZKwRMGmBJNYUychC(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700123D RID: 4669
			// (get) Token: 0x06003C07 RID: 15367 RVA: 0x001208DC File Offset: 0x0011EADC
			// (set) Token: 0x06003C08 RID: 15368 RVA: 0x000154DD File Offset: 0x000136DD
			public unsafe static int yQKpiKChKKCBLcQxoNzVGwpltJcF
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_yQKpiKChKKCBLcQxoNzVGwpltJcF, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_yQKpiKChKKCBLcQxoNzVGwpltJcF, (void*)(&value));
				}
			}

			// Token: 0x1700123E RID: 4670
			// (get) Token: 0x06003C09 RID: 15369 RVA: 0x001208F8 File Offset: 0x0011EAF8
			// (set) Token: 0x06003C0A RID: 15370 RVA: 0x000154EB File Offset: 0x000136EB
			public unsafe static int vNhFYJOczEwOfsizCsKCmScceme
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_vNhFYJOczEwOfsizCsKCmScceme, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_vNhFYJOczEwOfsizCsKCmScceme, (void*)(&value));
				}
			}

			// Token: 0x1700123F RID: 4671
			// (get) Token: 0x06003C0B RID: 15371 RVA: 0x00120914 File Offset: 0x0011EB14
			// (set) Token: 0x06003C0C RID: 15372 RVA: 0x000154F9 File Offset: 0x000136F9
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.tFxXgkEotEDZKwRMGmBJNYUychC.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x0400322B RID: 12843
			private static readonly IntPtr NativeFieldInfoPtr_yQKpiKChKKCBLcQxoNzVGwpltJcF;

			// Token: 0x0400322C RID: 12844
			private static readonly IntPtr NativeFieldInfoPtr_vNhFYJOczEwOfsizCsKCmScceme;

			// Token: 0x0400322D RID: 12845
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x0400322E RID: 12846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x0400322F RID: 12847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x04003230 RID: 12848
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04003231 RID: 12849
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04003232 RID: 12850
			private static readonly IntPtr NativeMethodInfoPtr_get_throttle_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x04003233 RID: 12851
			private static readonly IntPtr NativeMethodInfoPtr_get_minDetent_Public_Virtual_Final_New_get_IControllerTemplateButton_0;
		}

		// Token: 0x02000299 RID: 665
		public sealed class WfDnastyfqOYBLSmHgygvsAtNBc : ControllerTemplate.TeEFfeUuavQUqWQcSiuCNHaZfHR
		{
			// Token: 0x06003C0D RID: 15373 RVA: 0x00120930 File Offset: 0x0011EB30
			// Note: this type is marked as 'beforefieldinit'.
			static WfDnastyfqOYBLSmHgygvsAtNBc()
			{
				Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "WfDnastyfqOYBLSmHgygvsAtNBc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "JNsVRJuidmGGptuYkyrLeOPrUGf");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_biKCdqierIucdcjcoJVrOKcRSKBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "biKCdqierIucdcjcoJVrOKcRSKBy");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "UHyMaPGHANrtUdATGcsnpQWjZPv");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_YPILNLfSEGqCwUHsVkdCkWTjwgU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "YPILNLfSEGqCwUHsVkdCkWTjwgU");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "gEiUUxkYNQnyLvuoOuqdqUdENWS");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_OaKfENjhpabxyxorYXrINuygBGOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "OaKfENjhpabxyxorYXrINuygBGOR");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "KUWYKKpGaQgLJjiAIGXXGiJKoIs");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_dBrylCzFChPHdRUpMcEclCrSvnE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "dBrylCzFChPHdRUpMcEclCrSvnE");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665930);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665931);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665932);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665933);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665934);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_upRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665935);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665936);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_downRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665937);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665938);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_downLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665939);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665940);
				ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_upLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr, 100665941);
			}

			// Token: 0x06003C0E RID: 15374 RVA: 0x00120B00 File Offset: 0x0011ED00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258729, XrefRangeEnd = 258730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WfDnastyfqOYBLSmHgygvsAtNBc(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C0F RID: 15375 RVA: 0x00120B80 File Offset: 0x0011ED80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258750, RefRangeEnd = 258751, XrefRangeStart = 258730, XrefRangeEnd = 258750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WfDnastyfqOYBLSmHgygvsAtNBc(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL up, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL upRight, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL right, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL downRight, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL down, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL downLeft, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL left, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL upLeft)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(up);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upRight);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downRight);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(down);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downLeft);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upLeft);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700124D RID: 4685
			// (get) Token: 0x06003C10 RID: 15376 RVA: 0x00120C88 File Offset: 0x0011EE88
			public unsafe Vector2 value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258751, XrefRangeEnd = 258774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700124E RID: 4686
			// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00120CC4 File Offset: 0x0011EEC4
			public unsafe Vector2 valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258774, XrefRangeEnd = 258797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700124F RID: 4687
			// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00120D00 File Offset: 0x0011EF00
			public unsafe IControllerTemplateButton up
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258797, XrefRangeEnd = 258807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001250 RID: 4688
			// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00120D40 File Offset: 0x0011EF40
			public unsafe IControllerTemplateButton upRight
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258807, XrefRangeEnd = 258817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_upRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001251 RID: 4689
			// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00120D80 File Offset: 0x0011EF80
			public unsafe IControllerTemplateButton right
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258817, XrefRangeEnd = 258827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001252 RID: 4690
			// (get) Token: 0x06003C15 RID: 15381 RVA: 0x00120DC0 File Offset: 0x0011EFC0
			public unsafe IControllerTemplateButton downRight
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258827, XrefRangeEnd = 258837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_downRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00120E00 File Offset: 0x0011F000
			public unsafe IControllerTemplateButton down
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258837, XrefRangeEnd = 258847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x06003C17 RID: 15383 RVA: 0x00120E40 File Offset: 0x0011F040
			public unsafe IControllerTemplateButton downLeft
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258847, XrefRangeEnd = 258857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_downLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001255 RID: 4693
			// (get) Token: 0x06003C18 RID: 15384 RVA: 0x00120E80 File Offset: 0x0011F080
			public unsafe IControllerTemplateButton left
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258857, XrefRangeEnd = 258867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x17001256 RID: 4694
			// (get) Token: 0x06003C19 RID: 15385 RVA: 0x00120EC0 File Offset: 0x0011F0C0
			public unsafe IControllerTemplateButton upLeft
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258867, XrefRangeEnd = 258877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeMethodInfoPtr_get_upLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr3) : null;
				}
			}

			// Token: 0x06003C1A RID: 15386 RVA: 0x00015507 File Offset: 0x00013707
			public WfDnastyfqOYBLSmHgygvsAtNBc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001244 RID: 4676
			// (get) Token: 0x06003C1B RID: 15387 RVA: 0x00120F00 File Offset: 0x0011F100
			// (set) Token: 0x06003C1C RID: 15388 RVA: 0x00015510 File Offset: 0x00013710
			public unsafe static int JNsVRJuidmGGptuYkyrLeOPrUGf
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf, (void*)(&value));
				}
			}

			// Token: 0x17001245 RID: 4677
			// (get) Token: 0x06003C1D RID: 15389 RVA: 0x00120F1C File Offset: 0x0011F11C
			// (set) Token: 0x06003C1E RID: 15390 RVA: 0x0001551E File Offset: 0x0001371E
			public unsafe static int biKCdqierIucdcjcoJVrOKcRSKBy
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_biKCdqierIucdcjcoJVrOKcRSKBy, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_biKCdqierIucdcjcoJVrOKcRSKBy, (void*)(&value));
				}
			}

			// Token: 0x17001246 RID: 4678
			// (get) Token: 0x06003C1F RID: 15391 RVA: 0x00120F38 File Offset: 0x0011F138
			// (set) Token: 0x06003C20 RID: 15392 RVA: 0x0001552C File Offset: 0x0001372C
			public unsafe static int UHyMaPGHANrtUdATGcsnpQWjZPv
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv, (void*)(&value));
				}
			}

			// Token: 0x17001247 RID: 4679
			// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00120F54 File Offset: 0x0011F154
			// (set) Token: 0x06003C22 RID: 15394 RVA: 0x0001553A File Offset: 0x0001373A
			public unsafe static int YPILNLfSEGqCwUHsVkdCkWTjwgU
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_YPILNLfSEGqCwUHsVkdCkWTjwgU, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_YPILNLfSEGqCwUHsVkdCkWTjwgU, (void*)(&value));
				}
			}

			// Token: 0x17001248 RID: 4680
			// (get) Token: 0x06003C23 RID: 15395 RVA: 0x00120F70 File Offset: 0x0011F170
			// (set) Token: 0x06003C24 RID: 15396 RVA: 0x00015548 File Offset: 0x00013748
			public unsafe static int gEiUUxkYNQnyLvuoOuqdqUdENWS
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS, (void*)(&value));
				}
			}

			// Token: 0x17001249 RID: 4681
			// (get) Token: 0x06003C25 RID: 15397 RVA: 0x00120F8C File Offset: 0x0011F18C
			// (set) Token: 0x06003C26 RID: 15398 RVA: 0x00015556 File Offset: 0x00013756
			public unsafe static int OaKfENjhpabxyxorYXrINuygBGOR
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_OaKfENjhpabxyxorYXrINuygBGOR, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_OaKfENjhpabxyxorYXrINuygBGOR, (void*)(&value));
				}
			}

			// Token: 0x1700124A RID: 4682
			// (get) Token: 0x06003C27 RID: 15399 RVA: 0x00120FA8 File Offset: 0x0011F1A8
			// (set) Token: 0x06003C28 RID: 15400 RVA: 0x00015564 File Offset: 0x00013764
			public unsafe static int KUWYKKpGaQgLJjiAIGXXGiJKoIs
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs, (void*)(&value));
				}
			}

			// Token: 0x1700124B RID: 4683
			// (get) Token: 0x06003C29 RID: 15401 RVA: 0x00120FC4 File Offset: 0x0011F1C4
			// (set) Token: 0x06003C2A RID: 15402 RVA: 0x00015572 File Offset: 0x00013772
			public unsafe static int dBrylCzFChPHdRUpMcEclCrSvnE
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_dBrylCzFChPHdRUpMcEclCrSvnE, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_dBrylCzFChPHdRUpMcEclCrSvnE, (void*)(&value));
				}
			}

			// Token: 0x1700124C RID: 4684
			// (get) Token: 0x06003C2B RID: 15403 RVA: 0x00120FE0 File Offset: 0x0011F1E0
			// (set) Token: 0x06003C2C RID: 15404 RVA: 0x00015580 File Offset: 0x00013780
			public unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.WfDnastyfqOYBLSmHgygvsAtNBc.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x04003234 RID: 12852
			private static readonly IntPtr NativeFieldInfoPtr_JNsVRJuidmGGptuYkyrLeOPrUGf;

			// Token: 0x04003235 RID: 12853
			private static readonly IntPtr NativeFieldInfoPtr_biKCdqierIucdcjcoJVrOKcRSKBy;

			// Token: 0x04003236 RID: 12854
			private static readonly IntPtr NativeFieldInfoPtr_UHyMaPGHANrtUdATGcsnpQWjZPv;

			// Token: 0x04003237 RID: 12855
			private static readonly IntPtr NativeFieldInfoPtr_YPILNLfSEGqCwUHsVkdCkWTjwgU;

			// Token: 0x04003238 RID: 12856
			private static readonly IntPtr NativeFieldInfoPtr_gEiUUxkYNQnyLvuoOuqdqUdENWS;

			// Token: 0x04003239 RID: 12857
			private static readonly IntPtr NativeFieldInfoPtr_OaKfENjhpabxyxorYXrINuygBGOR;

			// Token: 0x0400323A RID: 12858
			private static readonly IntPtr NativeFieldInfoPtr_KUWYKKpGaQgLJjiAIGXXGiJKoIs;

			// Token: 0x0400323B RID: 12859
			private static readonly IntPtr NativeFieldInfoPtr_dBrylCzFChPHdRUpMcEclCrSvnE;

			// Token: 0x0400323C RID: 12860
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x0400323D RID: 12861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x0400323E RID: 12862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x0400323F RID: 12863
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04003240 RID: 12864
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04003241 RID: 12865
			private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003242 RID: 12866
			private static readonly IntPtr NativeMethodInfoPtr_get_upRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003243 RID: 12867
			private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003244 RID: 12868
			private static readonly IntPtr NativeMethodInfoPtr_get_downRight_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003245 RID: 12869
			private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003246 RID: 12870
			private static readonly IntPtr NativeMethodInfoPtr_get_downLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003247 RID: 12871
			private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Virtual_Final_New_get_IControllerTemplateButton_0;

			// Token: 0x04003248 RID: 12872
			private static readonly IntPtr NativeMethodInfoPtr_get_upLeft_Public_Virtual_Final_New_get_IControllerTemplateButton_0;
		}

		// Token: 0x0200029A RID: 666
		public sealed class UpOjLFxDYzPNCdjqoTOeHPZvBsP : ControllerTemplate.jVblzCZOGILPHqDOesHYvegkCid
		{
			// Token: 0x06003C2D RID: 15405 RVA: 0x00120FFC File Offset: 0x0011F1FC
			// Note: this type is marked as 'beforefieldinit'.
			static UpOjLFxDYzPNCdjqoTOeHPZvBsP()
			{
				Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "UpOjLFxDYzPNCdjqoTOeHPZvBsP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr);
				ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr, 100665942);
				ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr, 100665943);
				ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr, 100665944);
				ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr_get_pushPull_Public_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr, 100665945);
			}

			// Token: 0x06003C2E RID: 15406 RVA: 0x0012108C File Offset: 0x0011F28C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258877, XrefRangeEnd = 258878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpOjLFxDYzPNCdjqoTOeHPZvBsP(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C2F RID: 15407 RVA: 0x0012110C File Offset: 0x0011F30C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258891, RefRangeEnd = 258892, XrefRangeStart = 258878, XrefRangeEnd = 258891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpOjLFxDYzPNCdjqoTOeHPZvBsP(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL rollAxis, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL pitchAxis)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rollAxis);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pitchAxis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x06003C30 RID: 15408 RVA: 0x001211A0 File Offset: 0x0011F3A0
			public unsafe IControllerTemplateAxis rotation
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258892, XrefRangeEnd = 258902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x06003C31 RID: 15409 RVA: 0x001211E0 File Offset: 0x0011F3E0
			public unsafe IControllerTemplateAxis pushPull
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258902, XrefRangeEnd = 258912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeMethodInfoPtr_get_pushPull_Public_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003C32 RID: 15410 RVA: 0x0001558E File Offset: 0x0001378E
			public UpOjLFxDYzPNCdjqoTOeHPZvBsP(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001257 RID: 4695
			// (get) Token: 0x06003C33 RID: 15411 RVA: 0x00121220 File Offset: 0x0011F420
			// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00015597 File Offset: 0x00013797
			public new unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.UpOjLFxDYzPNCdjqoTOeHPZvBsP.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x04003249 RID: 12873
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x0400324A RID: 12874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x0400324B RID: 12875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;

			// Token: 0x0400324C RID: 12876
			private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;

			// Token: 0x0400324D RID: 12877
			private static readonly IntPtr NativeMethodInfoPtr_get_pushPull_Public_Virtual_Final_New_get_IControllerTemplateAxis_0;
		}

		// Token: 0x0200029B RID: 667
		public sealed class kJRDLEVsZQBiAiTFoMQjFPxHEgS : ControllerTemplate.FmJClzYqmMtYyAiTZBQYzeLHgEOk
		{
			// Token: 0x06003C35 RID: 15413 RVA: 0x0012123C File Offset: 0x0011F43C
			// Note: this type is marked as 'beforefieldinit'.
			static kJRDLEVsZQBiAiTFoMQjFPxHEgS()
			{
				Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "kJRDLEVsZQBiAiTFoMQjFPxHEgS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr);
				ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr, "ZsvFaffBiXnslZweBOxoUBiwGpn");
				ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr, 100665946);
				ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr, 100665947);
			}

			// Token: 0x06003C36 RID: 15414 RVA: 0x001212A4 File Offset: 0x0011F4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258912, XrefRangeEnd = 258913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe kJRDLEVsZQBiAiTFoMQjFPxHEgS(IControllerTemplate parent, int id, string name, Il2CppReferenceArray<ControllerTemplate.hVndtURQiZvFqDAtSlIbDHuddloG> elements)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C37 RID: 15415 RVA: 0x00121324 File Offset: 0x0011F524
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258942, RefRangeEnd = 258943, XrefRangeStart = 258913, XrefRangeEnd = 258942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe kJRDLEVsZQBiAiTFoMQjFPxHEgS(IControllerTemplate parent, int id, string name, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL positionX, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL positionY, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL positionZ, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL rotationX, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL rotationY, ControllerTemplate.xrqwjVCopyODingacGCyftGDqkL rotationZ)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positionX);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positionY);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positionZ);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotationX);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotationY);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotationZ);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C38 RID: 15416 RVA: 0x000155A5 File Offset: 0x000137A5
			public kJRDLEVsZQBiAiTFoMQjFPxHEgS(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06003C39 RID: 15417 RVA: 0x00121404 File Offset: 0x0011F604
			// (set) Token: 0x06003C3A RID: 15418 RVA: 0x000155AE File Offset: 0x000137AE
			public new unsafe static int ZsvFaffBiXnslZweBOxoUBiwGpn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerTemplate.kJRDLEVsZQBiAiTFoMQjFPxHEgS.NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn, (void*)(&value));
				}
			}

			// Token: 0x0400324E RID: 12878
			private static readonly IntPtr NativeFieldInfoPtr_ZsvFaffBiXnslZweBOxoUBiwGpn;

			// Token: 0x0400324F RID: 12879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IControllerTemplate_Int32_String_Il2CppReferenceArray_1_hVndtURQiZvFqDAtSlIbDHuddloG_0;

			// Token: 0x04003250 RID: 12880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IControllerTemplate_Int32_String_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_xrqwjVCopyODingacGCyftGDqkL_0;
		}

		// Token: 0x0200029C RID: 668
		public class YaxBHmiEXToVwhxMaTvPbcyzTpz : global::Il2CppSystem.Object
		{
			// Token: 0x06003C3B RID: 15419 RVA: 0x00121420 File Offset: 0x0011F620
			// Note: this type is marked as 'beforefieldinit'.
			static YaxBHmiEXToVwhxMaTvPbcyzTpz()
			{
				Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "YaxBHmiEXToVwhxMaTvPbcyzTpz");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, "GGGVwMYDkxCdXGBbfYmviLbbnxc");
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, "QOvYBMumHBTKRswPnUjkbLxwisx");
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665948);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665949);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665950);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665951);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665952);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_floatValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665953);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665954);
				ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Public_Static_YaxBHmiEXToVwhxMaTvPbcyzTpz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr, 100665955);
			}

			// Token: 0x06003C3C RID: 15420 RVA: 0x00121514 File Offset: 0x0011F714
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 223384, RefRangeEnd = 223386, XrefRangeStart = 223384, XrefRangeEnd = 223386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YaxBHmiEXToVwhxMaTvPbcyzTpz(IControllerElementTarget target, Controller.Element element)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700125D RID: 4701
			// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00121574 File Offset: 0x0011F774
			public unsafe bool vXqHxLjHEAtFSEgxhbauqDNBpWu
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258952, RefRangeEnd = 258954, XrefRangeStart = 258943, XrefRangeEnd = 258952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700125E RID: 4702
			// (get) Token: 0x06003C3E RID: 15422 RVA: 0x001215B0 File Offset: 0x0011F7B0
			public unsafe bool hQPWNcdbRkbXEjWQKGdPyHaunq
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258963, RefRangeEnd = 258965, XrefRangeStart = 258954, XrefRangeEnd = 258963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700125F RID: 4703
			// (get) Token: 0x06003C3F RID: 15423 RVA: 0x001215EC File Offset: 0x0011F7EC
			public unsafe bool jFlJzlqCcxsqKMuUjmERKTwSaeS
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 258970, RefRangeEnd = 258971, XrefRangeStart = 258965, XrefRangeEnd = 258970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001260 RID: 4704
			// (get) Token: 0x06003C40 RID: 15424 RVA: 0x00121628 File Offset: 0x0011F828
			public unsafe bool sKLtTIQeAIhDYsPAaKpoDMkUEQQ
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 258976, RefRangeEnd = 258977, XrefRangeStart = 258971, XrefRangeEnd = 258976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001261 RID: 4705
			// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00121664 File Offset: 0x0011F864
			public unsafe float znCTazKQcNswsDAuGuFvCkxQqaH
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258982, RefRangeEnd = 258984, XrefRangeStart = 258977, XrefRangeEnd = 258982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_floatValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001262 RID: 4706
			// (get) Token: 0x06003C42 RID: 15426 RVA: 0x001216A0 File Offset: 0x0011F8A0
			public unsafe float dimlGcURqCBsehdqGlkKkYvaSAM
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 258989, RefRangeEnd = 258991, XrefRangeStart = 258984, XrefRangeEnd = 258989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C43 RID: 15427 RVA: 0x001216DC File Offset: 0x0011F8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258991, XrefRangeEnd = 258996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz vlHkkxaKIMBHKYWpINVenaDBhUm()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Public_Static_YaxBHmiEXToVwhxMaTvPbcyzTpz_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz>(intPtr3) : null;
			}

			// Token: 0x06003C44 RID: 15428 RVA: 0x000155BC File Offset: 0x000137BC
			public YaxBHmiEXToVwhxMaTvPbcyzTpz(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700125B RID: 4699
			// (get) Token: 0x06003C45 RID: 15429 RVA: 0x00121710 File Offset: 0x0011F910
			// (set) Token: 0x06003C46 RID: 15430 RVA: 0x000155C5 File Offset: 0x000137C5
			public unsafe Controller.Element GGGVwMYDkxCdXGBbfYmviLbbnxc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller.Element>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700125C RID: 4700
			// (get) Token: 0x06003C47 RID: 15431 RVA: 0x00121740 File Offset: 0x0011F940
			// (set) Token: 0x06003C48 RID: 15432 RVA: 0x000155E4 File Offset: 0x000137E4
			public unsafe IControllerElementTarget QOvYBMumHBTKRswPnUjkbLxwisx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IControllerElementTarget>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.YaxBHmiEXToVwhxMaTvPbcyzTpz.NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003251 RID: 12881
			private static readonly IntPtr NativeFieldInfoPtr_GGGVwMYDkxCdXGBbfYmviLbbnxc;

			// Token: 0x04003252 RID: 12882
			private static readonly IntPtr NativeFieldInfoPtr_QOvYBMumHBTKRswPnUjkbLxwisx;

			// Token: 0x04003253 RID: 12883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IControllerElementTarget_Element_0;

			// Token: 0x04003254 RID: 12884
			private static readonly IntPtr NativeMethodInfoPtr_get_boolValue_Public_get_Boolean_0;

			// Token: 0x04003255 RID: 12885
			private static readonly IntPtr NativeMethodInfoPtr_get_boolValuePrev_Public_get_Boolean_0;

			// Token: 0x04003256 RID: 12886
			private static readonly IntPtr NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0;

			// Token: 0x04003257 RID: 12887
			private static readonly IntPtr NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0;

			// Token: 0x04003258 RID: 12888
			private static readonly IntPtr NativeMethodInfoPtr_get_floatValue_Public_get_Single_0;

			// Token: 0x04003259 RID: 12889
			private static readonly IntPtr NativeMethodInfoPtr_get_floatValuePrev_Public_get_Single_0;

			// Token: 0x0400325A RID: 12890
			private static readonly IntPtr NativeMethodInfoPtr_vlHkkxaKIMBHKYWpINVenaDBhUm_Public_Static_YaxBHmiEXToVwhxMaTvPbcyzTpz_0;
		}

		// Token: 0x0200029D RID: 669
		public class iHjuSiZpHAsmKbJhaDVJbfWZWjt : global::Il2CppSystem.Object
		{
			// Token: 0x06003C49 RID: 15433 RVA: 0x00121770 File Offset: 0x0011F970
			// Note: this type is marked as 'beforefieldinit'.
			static iHjuSiZpHAsmKbJhaDVJbfWZWjt()
			{
				Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr, "iHjuSiZpHAsmKbJhaDVJbfWZWjt");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr);
				ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_QKvAbvGQCqsWmgnxkoolhIHttGup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr, "QKvAbvGQCqsWmgnxkoolhIHttGup");
				ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_ZKBvyRyczTghHfmeomFemJvhBiS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr, "ZKBvyRyczTghHfmeomFemJvhBiS");
				ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeMethodInfoPtr__ctor_Public_Void_Controller_IHardwareControllerTemplateMap_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr, 100665956);
			}

			// Token: 0x06003C4A RID: 15434 RVA: 0x001217D8 File Offset: 0x0011F9D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258996, RefRangeEnd = 258997, XrefRangeStart = 258996, XrefRangeEnd = 258996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe iHjuSiZpHAsmKbJhaDVJbfWZWjt(Controller controller, IHardwareControllerTemplateMap_Internal templateMap)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(templateMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeMethodInfoPtr__ctor_Public_Void_Controller_IHardwareControllerTemplateMap_Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C4B RID: 15435 RVA: 0x00015603 File Offset: 0x00013803
			public iHjuSiZpHAsmKbJhaDVJbfWZWjt(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001263 RID: 4707
			// (get) Token: 0x06003C4C RID: 15436 RVA: 0x00121838 File Offset: 0x0011FA38
			// (set) Token: 0x06003C4D RID: 15437 RVA: 0x0001560C File Offset: 0x0001380C
			public unsafe Controller QKvAbvGQCqsWmgnxkoolhIHttGup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_QKvAbvGQCqsWmgnxkoolhIHttGup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_QKvAbvGQCqsWmgnxkoolhIHttGup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001264 RID: 4708
			// (get) Token: 0x06003C4E RID: 15438 RVA: 0x00121868 File Offset: 0x0011FA68
			// (set) Token: 0x06003C4F RID: 15439 RVA: 0x0001562B File Offset: 0x0001382B
			public unsafe IHardwareControllerTemplateMap_Internal ZKBvyRyczTghHfmeomFemJvhBiS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_ZKBvyRyczTghHfmeomFemJvhBiS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHardwareControllerTemplateMap_Internal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplate.iHjuSiZpHAsmKbJhaDVJbfWZWjt.NativeFieldInfoPtr_ZKBvyRyczTghHfmeomFemJvhBiS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400325B RID: 12891
			private static readonly IntPtr NativeFieldInfoPtr_QKvAbvGQCqsWmgnxkoolhIHttGup;

			// Token: 0x0400325C RID: 12892
			private static readonly IntPtr NativeFieldInfoPtr_ZKBvyRyczTghHfmeomFemJvhBiS;

			// Token: 0x0400325D RID: 12893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Controller_IHardwareControllerTemplateMap_Internal_0;
		}

		// Token: 0x0200029E RID: 670
		private sealed class MethodInfoStoreGeneric_GetElement_Protected_T_Int32_0<T>
		{
			// Token: 0x0400325E RID: 12894
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ControllerTemplate.NativeMethodInfoPtr_GetElement_Protected_T_Int32_0, Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200029F RID: 671
		private sealed class MethodInfoStoreGeneric_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_T_Int32_0<T>
		{
			// Token: 0x0400325F RID: 12895
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ControllerTemplate.NativeMethodInfoPtr_sZjwxTKUgulbQhNhFDPlXtyIAMg_Private_Virtual_Final_New_T_Int32_0, Il2CppClassPointerStore<ControllerTemplate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
