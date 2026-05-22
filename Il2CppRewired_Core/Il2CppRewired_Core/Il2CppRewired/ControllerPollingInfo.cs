using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x0200000F RID: 15
	public sealed class ControllerPollingInfo : ValueType
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0002F518 File Offset: 0x0002D718
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerPollingInfo()
		{
			Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerPollingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr);
			ControllerPollingInfo.NativeFieldInfoPtr_DDOIYCEXVKmALHmqOlAlRcYuZpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "DDOIYCEXVKmALHmqOlAlRcYuZpc");
			ControllerPollingInfo.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "HFDLhMjPFtSioLkrcDMAnXTYLIS");
			ControllerPollingInfo.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "IfhnTjioRBhbGjEtsghiwZaIQGbU");
			ControllerPollingInfo.NativeFieldInfoPtr_jPjYNOkOWyhBPmrEKkWzgOvPGdM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "jPjYNOkOWyhBPmrEKkWzgOvPGdM");
			ControllerPollingInfo.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
			ControllerPollingInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "BSxDqfHZlHRrRHngfWyKkIxRqxNi");
			ControllerPollingInfo.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "RYFkGEtFkaatTiIhlQWJSrLicphK");
			ControllerPollingInfo.NativeFieldInfoPtr_iOiUMBnIUeBJBEUjhitpdXjTMBzX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "iOiUMBnIUeBJBEUjhitpdXjTMBzX");
			ControllerPollingInfo.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "ZPacqaCAVpflBQYrSgvMUALUMJO");
			ControllerPollingInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "LmpWzzgHGngqvdvpwzTKPbztfdh");
			ControllerPollingInfo.NativeFieldInfoPtr_IgjoGxVlTibPSrHeBbjjlfBdGCFD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, "IgjoGxVlTibPSrHeBbjjlfBdGCFD");
			ControllerPollingInfo.NativeMethodInfoPtr_get_success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663402);
			ControllerPollingInfo.NativeMethodInfoPtr_set_success_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663403);
			ControllerPollingInfo.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663404);
			ControllerPollingInfo.NativeMethodInfoPtr_set_playerId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663405);
			ControllerPollingInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663406);
			ControllerPollingInfo.NativeMethodInfoPtr_set_controllerId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663407);
			ControllerPollingInfo.NativeMethodInfoPtr_get_controllerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663408);
			ControllerPollingInfo.NativeMethodInfoPtr_set_controllerName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663409);
			ControllerPollingInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663410);
			ControllerPollingInfo.NativeMethodInfoPtr_set_controllerType_Internal_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663411);
			ControllerPollingInfo.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663412);
			ControllerPollingInfo.NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663413);
			ControllerPollingInfo.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663414);
			ControllerPollingInfo.NativeMethodInfoPtr_set_elementIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663415);
			ControllerPollingInfo.NativeMethodInfoPtr_get_axisPole_Public_get_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663416);
			ControllerPollingInfo.NativeMethodInfoPtr_set_axisPole_Internal_set_Void_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663417);
			ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663418);
			ControllerPollingInfo.NativeMethodInfoPtr_set_elementIdentifierName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663419);
			ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663420);
			ControllerPollingInfo.NativeMethodInfoPtr_set_elementIdentifierId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663421);
			ControllerPollingInfo.NativeMethodInfoPtr_get_keyboardKey_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663422);
			ControllerPollingInfo.NativeMethodInfoPtr_set_keyboardKey_Internal_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663423);
			ControllerPollingInfo.NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663424);
			ControllerPollingInfo.NativeMethodInfoPtr_get_controller_Public_get_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663425);
			ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663426);
			ControllerPollingInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Int32_String_ControllerType_ControllerElementType_Int32_Pole_String_Int32_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663427);
			ControllerPollingInfo.NativeMethodInfoPtr__ctor_Internal_Void_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663428);
			ControllerPollingInfo.NativeMethodInfoPtr_XvJJgyCeyannGfdIbEfBSTlkmZC_Internal_Static_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, 100663429);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0002F854 File Offset: 0x0002DA54
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0002F898 File Offset: 0x0002DA98
		public unsafe bool success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_success_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_success_Internal_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0002F8DC File Offset: 0x0002DADC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0002F920 File Offset: 0x0002DB20
		public unsafe int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_playerId_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0002F964 File Offset: 0x0002DB64
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_controllerId_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0002F9EC File Offset: 0x0002DBEC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0002FA28 File Offset: 0x0002DC28
		public unsafe string controllerName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_controllerName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_controllerName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0002FA70 File Offset: 0x0002DC70
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_controllerType_Internal_set_Void_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0002FB3C File Offset: 0x0002DD3C
		public unsafe ControllerElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0002FB80 File Offset: 0x0002DD80
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
		public unsafe int elementIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_elementIndex_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0002FC08 File Offset: 0x0002DE08
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0002FC4C File Offset: 0x0002DE4C
		public unsafe Pole axisPole
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_axisPole_Public_get_Pole_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_axisPole_Internal_set_Void_Pole_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0002FC90 File Offset: 0x0002DE90
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0002FCCC File Offset: 0x0002DECC
		public unsafe string elementIdentifierName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_elementIdentifierName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0002FD14 File Offset: 0x0002DF14
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0002FD58 File Offset: 0x0002DF58
		public unsafe int elementIdentifierId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_elementIdentifierId_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0002FD9C File Offset: 0x0002DF9C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0002FDE0 File Offset: 0x0002DFE0
		public unsafe KeyCode keyboardKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_keyboardKey_Public_get_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_set_keyboardKey_Internal_set_Void_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0002FE24 File Offset: 0x0002E024
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243111, XrefRangeEnd = 243121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0002FE68 File Offset: 0x0002E068
		public unsafe Controller controller
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 243129, RefRangeEnd = 243130, XrefRangeStart = 243121, XrefRangeEnd = 243129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_controller_Public_get_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller>(intPtr3) : null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0002FEAC File Offset: 0x0002E0AC
		public unsafe ControllerElementIdentifier elementIdentifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243130, XrefRangeEnd = 243136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerElementIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 243136, RefRangeEnd = 243144, XrefRangeStart = 243136, XrefRangeEnd = 243136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerPollingInfo(bool success, int playerId, int controllerId, string controllerName, ControllerType controllerType, ControllerElementType elementType, int elementIndex, Pole axisPole, string elementIdentifierName, int elementIdentifierId, KeyCode keyboardKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(controllerName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controllerType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisPole;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementIdentifierName);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementIdentifierId;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Int32_String_ControllerType_ControllerElementType_Int32_Pole_String_Int32_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 243144, RefRangeEnd = 243164, XrefRangeStart = 243144, XrefRangeEnd = 243144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerPollingInfo(ControllerPollingInfo source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr__ctor_Internal_Void_ControllerPollingInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00030030 File Offset: 0x0002E230
		[CallerCount(95)]
		[CachedScanResults(RefRangeStart = 243166, RefRangeEnd = 243261, XrefRangeStart = 243164, XrefRangeEnd = 243166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ControllerPollingInfo XvJJgyCeyannGfdIbEfBSTlkmZC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerPollingInfo.NativeMethodInfoPtr_XvJJgyCeyannGfdIbEfBSTlkmZC_Internal_Static_ControllerPollingInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ControllerPollingInfo(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002411 File Offset: 0x00000611
		public ControllerPollingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000241A File Offset: 0x0000061A
		public ControllerPollingInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0003005C File Offset: 0x0002E25C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000242C File Offset: 0x0000062C
		public unsafe bool DDOIYCEXVKmALHmqOlAlRcYuZpc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_DDOIYCEXVKmALHmqOlAlRcYuZpc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_DDOIYCEXVKmALHmqOlAlRcYuZpc)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00030084 File Offset: 0x0002E284
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002447 File Offset: 0x00000647
		public unsafe int HFDLhMjPFtSioLkrcDMAnXTYLIS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000300AC File Offset: 0x0002E2AC
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002462 File Offset: 0x00000662
		public unsafe int IfhnTjioRBhbGjEtsghiwZaIQGbU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000300D4 File Offset: 0x0002E2D4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe string jPjYNOkOWyhBPmrEKkWzgOvPGdM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_jPjYNOkOWyhBPmrEKkWzgOvPGdM);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_jPjYNOkOWyhBPmrEKkWzgOvPGdM), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000300FC File Offset: 0x0002E2FC
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00030124 File Offset: 0x0002E324
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000024B7 File Offset: 0x000006B7
		public unsafe ControllerElementType BSxDqfHZlHRrRHngfWyKkIxRqxNi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0003014C File Offset: 0x0002E34C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000024D2 File Offset: 0x000006D2
		public unsafe int RYFkGEtFkaatTiIhlQWJSrLicphK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00030174 File Offset: 0x0002E374
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000024ED File Offset: 0x000006ED
		public unsafe Pole iOiUMBnIUeBJBEUjhitpdXjTMBzX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_iOiUMBnIUeBJBEUjhitpdXjTMBzX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_iOiUMBnIUeBJBEUjhitpdXjTMBzX)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0003019C File Offset: 0x0002E39C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002508 File Offset: 0x00000708
		public unsafe string ZPacqaCAVpflBQYrSgvMUALUMJO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000301C4 File Offset: 0x0002E3C4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002527 File Offset: 0x00000727
		public unsafe int LmpWzzgHGngqvdvpwzTKPbztfdh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000301EC File Offset: 0x0002E3EC
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002542 File Offset: 0x00000742
		public unsafe KeyCode IgjoGxVlTibPSrHeBbjjlfBdGCFD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_IgjoGxVlTibPSrHeBbjjlfBdGCFD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerPollingInfo.NativeFieldInfoPtr_IgjoGxVlTibPSrHeBbjjlfBdGCFD)) = value;
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_DDOIYCEXVKmALHmqOlAlRcYuZpc;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_jPjYNOkOWyhBPmrEKkWzgOvPGdM;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_BSxDqfHZlHRrRHngfWyKkIxRqxNi;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_RYFkGEtFkaatTiIhlQWJSrLicphK;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_iOiUMBnIUeBJBEUjhitpdXjTMBzX;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_ZPacqaCAVpflBQYrSgvMUALUMJO;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_LmpWzzgHGngqvdvpwzTKPbztfdh;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_IgjoGxVlTibPSrHeBbjjlfBdGCFD;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_success_Public_get_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_success_Internal_set_Void_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Internal_set_Void_Int32_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Internal_set_Void_Int32_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerName_Public_get_String_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerName_Internal_set_Void_String_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Internal_set_Void_ControllerType_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_ControllerElementType_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_set_elementType_Internal_set_Void_ControllerElementType_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIndex_Public_get_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIndex_Internal_set_Void_Int32_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_axisPole_Public_get_Pole_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_set_axisPole_Internal_set_Void_Pole_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierName_Public_get_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIdentifierName_Internal_set_Void_String_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifierId_Public_get_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_elementIdentifierId_Internal_set_Void_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardKey_Public_get_KeyCode_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardKey_Internal_set_Void_KeyCode_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_controller_Public_get_Controller_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_elementIdentifier_Public_get_ControllerElementIdentifier_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_Int32_Int32_String_ControllerType_ControllerElementType_Int32_Pole_String_Int32_KeyCode_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ControllerPollingInfo_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_XvJJgyCeyannGfdIbEfBSTlkmZC_Internal_Static_ControllerPollingInfo_0;
	}
}
