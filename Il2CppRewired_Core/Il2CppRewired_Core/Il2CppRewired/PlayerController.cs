using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000099 RID: 153
	public class PlayerController : global::Il2CppSystem.Object
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x0006F568 File Offset: 0x0006D768
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerController()
		{
			Il2CppClassPointerStore<PlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController>.NativeClassPtr);
			PlayerController.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			PlayerController.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			PlayerController.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "HFDLhMjPFtSioLkrcDMAnXTYLIS");
			PlayerController.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "xQkGABJRsmzTPSmeXgqJmJTMBma");
			PlayerController.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "GuxtgegCZiWJDenlSEVuDZKGNKPu");
			PlayerController.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "yPmaEVkiAXCCzJsPBnVnFFukdZK");
			PlayerController.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "FaxDYKiOiLbKbaDgSKQsyfLUaPD");
			PlayerController.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "pkbzarsvTGkNCTNGNnfjDNndVNz");
			PlayerController.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "qePVktyxBhmaaxMeMhRxeEftTXZn");
			PlayerController.NativeFieldInfoPtr_DthASaHdiiMwCDwPSskGaZFWmIif = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "DthASaHdiiMwCDwPSskGaZFWmIif");
			PlayerController.NativeFieldInfoPtr_fHnXBfObWlBGpqVccHzXEetSqkB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "fHnXBfObWlBGpqVccHzXEetSqkB");
			PlayerController.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "QPwyUMnDblgZagiNvxJIlyjVaauW");
			PlayerController.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "qqpveziflpDCMqhzVMsvgajLKBW");
			PlayerController.NativeMethodInfoPtr__ctor_Internal_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666193);
			PlayerController.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666194);
			PlayerController.NativeMethodInfoPtr_get_enabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666195);
			PlayerController.NativeMethodInfoPtr_set_enabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666196);
			PlayerController.NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666197);
			PlayerController.NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666198);
			PlayerController.NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666199);
			PlayerController.NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666200);
			PlayerController.NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666201);
			PlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666202);
			PlayerController.NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666203);
			PlayerController.NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666204);
			PlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666205);
			PlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666206);
			PlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666207);
			PlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666208);
			PlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666209);
			PlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666210);
			PlayerController.NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666211);
			PlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666212);
			PlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666213);
			PlayerController.NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666214);
			PlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666215);
			PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666216);
			PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666217);
			PlayerController.NativeMethodInfoPtr_get_player_Internal_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666218);
			PlayerController.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666219);
			PlayerController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Boolean_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666220);
			PlayerController.NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666221);
			PlayerController.NativeMethodInfoPtr_ClearVars_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666222);
			PlayerController.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666223);
			PlayerController.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Private_Void_Element_List_1_Element_List_1_Element_List_1_Button_List_1_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666224);
			PlayerController.NativeMethodInfoPtr_DqDqXlkoRPQMtBOZPgBoRoCwpGa_Internal_Static_Int32_IList_1_T_Predicate_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100666225);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0006F930 File Offset: 0x0006DB30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261186, RefRangeEnd = 261189, XrefRangeStart = 261079, XrefRangeEnd = 261186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerController(PlayerController.Definition definition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr__ctor_Internal_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0006F97C File Offset: 0x0006DB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261189, XrefRangeEnd = 261200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0006F9B8 File Offset: 0x0006DBB8
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0006F9F4 File Offset: 0x0006DBF4
		public unsafe virtual bool enabled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 261204, RefRangeEnd = 261210, XrefRangeStart = 261200, XrefRangeEnd = 261204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_enabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261229, RefRangeEnd = 261231, XrefRangeStart = 261210, XrefRangeEnd = 261229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_set_enabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0006FA34 File Offset: 0x0006DC34
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0006FA70 File Offset: 0x0006DC70
		public unsafe virtual int playerId
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 261235, RefRangeEnd = 261241, XrefRangeStart = 261231, XrefRangeEnd = 261235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 261247, RefRangeEnd = 261248, XrefRangeStart = 261241, XrefRangeEnd = 261247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0006FAB0 File Offset: 0x0006DCB0
		public unsafe virtual IList<PlayerController.Button> buttons
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 261252, RefRangeEnd = 261259, XrefRangeStart = 261248, XrefRangeEnd = 261252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Button>>(intPtr3) : null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0006FAF0 File Offset: 0x0006DCF0
		public unsafe virtual IList<PlayerController.Axis> axes
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 261263, RefRangeEnd = 261274, XrefRangeStart = 261259, XrefRangeEnd = 261263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Axis>>(intPtr3) : null;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0006FB30 File Offset: 0x0006DD30
		public unsafe virtual IList<PlayerController.Element> elements
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 261278, RefRangeEnd = 261288, XrefRangeStart = 261274, XrefRangeEnd = 261278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<PlayerController.Element>>(intPtr3) : null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0006FB70 File Offset: 0x0006DD70
		public unsafe virtual int buttonCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261288, XrefRangeEnd = 261292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0006FBAC File Offset: 0x0006DDAC
		public unsafe virtual int axisCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261292, XrefRangeEnd = 261296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0006FBE8 File Offset: 0x0006DDE8
		public unsafe virtual int elementCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261300, RefRangeEnd = 261302, XrefRangeStart = 261296, XrefRangeEnd = 261300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0006FC24 File Offset: 0x0006DE24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261309, RefRangeEnd = 261311, XrefRangeStart = 261302, XrefRangeEnd = 261309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0006FC68 File Offset: 0x0006DE68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261314, RefRangeEnd = 261316, XrefRangeStart = 261311, XrefRangeEnd = 261314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ButtonStateChangedEvent(Action<int, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0006FCAC File Offset: 0x0006DEAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261323, RefRangeEnd = 261325, XrefRangeStart = 261316, XrefRangeEnd = 261323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0006FCF0 File Offset: 0x0006DEF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261328, RefRangeEnd = 261330, XrefRangeStart = 261325, XrefRangeEnd = 261328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_AxisValueChangedEvent(Action<int, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0006FD34 File Offset: 0x0006DF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261337, RefRangeEnd = 261339, XrefRangeStart = 261330, XrefRangeEnd = 261337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0006FD78 File Offset: 0x0006DF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261342, RefRangeEnd = 261344, XrefRangeStart = 261339, XrefRangeEnd = 261342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_EnabledStateChangedEvent(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0006FDBC File Offset: 0x0006DFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261354, RefRangeEnd = 261356, XrefRangeStart = 261344, XrefRangeEnd = 261354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButton(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0006FE08 File Offset: 0x0006E008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261366, RefRangeEnd = 261368, XrefRangeStart = 261356, XrefRangeEnd = 261366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonDown(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0006FE54 File Offset: 0x0006E054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261378, RefRangeEnd = 261380, XrefRangeStart = 261368, XrefRangeEnd = 261378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetButtonUp(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0006FEA0 File Offset: 0x0006E0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261380, XrefRangeEnd = 261389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxis(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0006FEEC File Offset: 0x0006E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261389, XrefRangeEnd = 261398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAxisRaw(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0006FF38 File Offset: 0x0006E138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261407, RefRangeEnd = 261409, XrefRangeStart = 261398, XrefRangeEnd = 261407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PlayerController.Element GetElement(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0006FF84 File Offset: 0x0006E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261409, XrefRangeEnd = 261413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T GetElement<T>(int index) where T : PlayerController.Element
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MethodInfoStoreGeneric_GetElement_Public_Virtual_Final_New_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0006FFCC File Offset: 0x0006E1CC
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261413, XrefRangeEnd = 261422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_get_player_Internal_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0007000C File Offset: 0x0006E20C
		[CallerCount(0)]
		public unsafe void NFTSnGXuZXafcZHIgcYanOLckXY(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0007004C File Offset: 0x0006E24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261454, RefRangeEnd = 261455, XrefRangeStart = 261422, XrefRangeEnd = 261454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Boolean_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x000700A0 File Offset: 0x0006E2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261474, RefRangeEnd = 261475, XrefRangeStart = 261455, XrefRangeEnd = 261474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000700DC File Offset: 0x0006E2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261475, XrefRangeEnd = 261477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearVars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.NativeMethodInfoPtr_ClearVars_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00070118 File Offset: 0x0006E318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261489, RefRangeEnd = 261491, XrefRangeStart = 261477, XrefRangeEnd = 261489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FtpfwMCKfMCnbBBezixohHaJHAGb(PlayerController.Element A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0007015C File Offset: 0x0006E35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261514, RefRangeEnd = 261515, XrefRangeStart = 261491, XrefRangeEnd = 261514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FtpfwMCKfMCnbBBezixohHaJHAGb(PlayerController.Element A_1, List<PlayerController.Element> A_2, List<PlayerController.Element> A_3, List<PlayerController.Button> A_4, List<PlayerController.Axis> A_5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_5);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Private_Void_Element_List_1_Element_List_1_Element_List_1_Button_List_1_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000701E8 File Offset: 0x0006E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261515, XrefRangeEnd = 261520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DqDqXlkoRPQMtBOZPgBoRoCwpGa<T>(IList<T> A_0, Predicate<T> A_1, int A_2) where T : PlayerController.Element
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MethodInfoStoreGeneric_DqDqXlkoRPQMtBOZPgBoRoCwpGa_Internal_Static_Int32_IList_1_T_Predicate_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00007D4C File Offset: 0x00005F4C
		public PlayerController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0007024C File Offset: 0x0006E44C
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x00007D55 File Offset: 0x00005F55
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00070274 File Offset: 0x0006E474
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x00007D70 File Offset: 0x00005F70
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0007029C File Offset: 0x0006E49C
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x00007D8B File Offset: 0x00005F8B
		public unsafe int HFDLhMjPFtSioLkrcDMAnXTYLIS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS)) = value;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000702C4 File Offset: 0x0006E4C4
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00007DA6 File Offset: 0x00005FA6
		public unsafe AList<PlayerController.Element> xQkGABJRsmzTPSmeXgqJmJTMBma
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AList<PlayerController.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x000702F4 File Offset: 0x0006E4F4
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00007DC5 File Offset: 0x00005FC5
		public unsafe AList<PlayerController.Button> GuxtgegCZiWJDenlSEVuDZKGNKPu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AList<PlayerController.Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00070324 File Offset: 0x0006E524
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x00007DE4 File Offset: 0x00005FE4
		public unsafe AList<PlayerController.Axis> yPmaEVkiAXCCzJsPBnVnFFukdZK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AList<PlayerController.Axis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00070354 File Offset: 0x0006E554
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x00007E03 File Offset: 0x00006003
		public unsafe ReadOnlyCollection<PlayerController.Element> FaxDYKiOiLbKbaDgSKQsyfLUaPD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PlayerController.Element>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00070384 File Offset: 0x0006E584
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x00007E22 File Offset: 0x00006022
		public unsafe ReadOnlyCollection<PlayerController.Button> pkbzarsvTGkNCTNGNnfjDNndVNz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PlayerController.Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x000703B4 File Offset: 0x0006E5B4
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x00007E41 File Offset: 0x00006041
		public unsafe ReadOnlyCollection<PlayerController.Axis> qePVktyxBhmaaxMeMhRxeEftTXZn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PlayerController.Axis>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x000703E4 File Offset: 0x0006E5E4
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x00007E60 File Offset: 0x00006060
		public unsafe List<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA> DthASaHdiiMwCDwPSskGaZFWmIif
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_DthASaHdiiMwCDwPSskGaZFWmIif);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_DthASaHdiiMwCDwPSskGaZFWmIif), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00070414 File Offset: 0x0006E614
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x00007E7F File Offset: 0x0000607F
		public unsafe Action<int, bool> fHnXBfObWlBGpqVccHzXEetSqkB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_fHnXBfObWlBGpqVccHzXEetSqkB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_fHnXBfObWlBGpqVccHzXEetSqkB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00070444 File Offset: 0x0006E644
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x00007E9E File Offset: 0x0000609E
		public unsafe Action<int, float> QPwyUMnDblgZagiNvxJIlyjVaauW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00070474 File Offset: 0x0006E674
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x00007EBD File Offset: 0x000060BD
		public unsafe Action<bool> qqpveziflpDCMqhzVMsvgajLKBW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr_HFDLhMjPFtSioLkrcDMAnXTYLIS;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr_yPmaEVkiAXCCzJsPBnVnFFukdZK;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr_FaxDYKiOiLbKbaDgSKQsyfLUaPD;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr_pkbzarsvTGkNCTNGNnfjDNndVNz;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr_qePVktyxBhmaaxMeMhRxeEftTXZn;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr_DthASaHdiiMwCDwPSskGaZFWmIif;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr_fHnXBfObWlBGpqVccHzXEetSqkB;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr_QPwyUMnDblgZagiNvxJIlyjVaauW;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr_qqpveziflpDCMqhzVMsvgajLKBW;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Definition_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_get_buttons_Public_Virtual_Final_New_get_IList_1_Button_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_get_axes_Public_Virtual_Final_New_get_IList_1_Axis_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_get_elements_Public_Virtual_Final_New_get_IList_1_Element_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_get_buttonCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_get_axisCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_add_ButtonStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Boolean_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_remove_ButtonStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Boolean_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_add_AxisValueChangedEvent_Public_Virtual_Final_New_add_Void_Action_2_Int32_Single_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_remove_AxisValueChangedEvent_Public_Virtual_Final_New_rem_Void_Action_2_Int32_Single_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_add_EnabledStateChangedEvent_Public_Virtual_Final_New_add_Void_Action_1_Boolean_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_remove_EnabledStateChangedEvent_Public_Virtual_Final_New_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_Element_Int32_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Internal_get_Player_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_NFTSnGXuZXafcZHIgcYanOLckXY_Private_Void_UpdateLoopType_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Boolean_UpdateLoopType_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFinished_Protected_Virtual_New_Void_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_ClearVars_Protected_Virtual_New_Void_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Private_Void_Element_List_1_Element_List_1_Element_List_1_Button_List_1_Axis_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_DqDqXlkoRPQMtBOZPgBoRoCwpGa_Internal_Static_Int32_IList_1_T_Predicate_1_T_Int32_0;

		// Token: 0x020002A0 RID: 672
		public class Definition : global::Il2CppSystem.Object
		{
			// Token: 0x06003C52 RID: 15442 RVA: 0x00121940 File Offset: 0x0011FB40
			// Note: this type is marked as 'beforefieldinit'.
			static Definition()
			{
				Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Definition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr);
				PlayerController.Definition.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr, "enabled");
				PlayerController.Definition.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr, "playerId");
				PlayerController.Definition.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr, "elements");
				PlayerController.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr, 100666226);
			}

			// Token: 0x06003C53 RID: 15443 RVA: 0x001219BC File Offset: 0x0011FBBC
			[CallerCount(0)]
			public unsafe Definition()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Definition>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C54 RID: 15444 RVA: 0x0001564A File Offset: 0x0001384A
			public Definition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001265 RID: 4709
			// (get) Token: 0x06003C55 RID: 15445 RVA: 0x001219F8 File Offset: 0x0011FBF8
			// (set) Token: 0x06003C56 RID: 15446 RVA: 0x00015653 File Offset: 0x00013853
			public unsafe bool enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_enabled)) = value;
				}
			}

			// Token: 0x17001266 RID: 4710
			// (get) Token: 0x06003C57 RID: 15447 RVA: 0x00121A20 File Offset: 0x0011FC20
			// (set) Token: 0x06003C58 RID: 15448 RVA: 0x0001566E File Offset: 0x0001386E
			public unsafe int playerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_playerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_playerId)) = value;
				}
			}

			// Token: 0x17001267 RID: 4711
			// (get) Token: 0x06003C59 RID: 15449 RVA: 0x00121A48 File Offset: 0x0011FC48
			// (set) Token: 0x06003C5A RID: 15450 RVA: 0x00015689 File Offset: 0x00013889
			public unsafe ICollection<PlayerController.Element.Definition> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<PlayerController.Element.Definition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Definition.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003260 RID: 12896
			private static readonly IntPtr NativeFieldInfoPtr_enabled;

			// Token: 0x04003261 RID: 12897
			private static readonly IntPtr NativeFieldInfoPtr_playerId;

			// Token: 0x04003262 RID: 12898
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x04003263 RID: 12899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002A1 RID: 673
		public static class Factory : global::Il2CppSystem.Object
		{
			// Token: 0x06003C5B RID: 15451 RVA: 0x000156A8 File Offset: 0x000138A8
			// Note: this type is marked as 'beforefieldinit'.
			static Factory()
			{
				Il2CppClassPointerStore<PlayerController.Factory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Factory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Factory>.NativeClassPtr);
				PlayerController.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Factory>.NativeClassPtr, 100666227);
			}

			// Token: 0x06003C5C RID: 15452 RVA: 0x00121A78 File Offset: 0x0011FC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260637, XrefRangeEnd = 260641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerController Create(PlayerController.Definition definition)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Factory.NativeMethodInfoPtr_Create_Public_Static_PlayerController_Definition_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController>(intPtr3) : null;
				}
			}

			// Token: 0x06003C5D RID: 15453 RVA: 0x000156DC File Offset: 0x000138DC
			public Factory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003264 RID: 12900
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayerController_Definition_0;
		}

		// Token: 0x020002A2 RID: 674
		public class Element : global::Il2CppSystem.Object
		{
			// Token: 0x06003C5E RID: 15454 RVA: 0x00121ABC File Offset: 0x0011FCBC
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr);
				PlayerController.Element.NativeFieldInfoPtr_defaultEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "defaultEnabled");
				PlayerController.Element.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "mcZTbbPGwEArYoSxgzyGmeIyAph");
				PlayerController.Element.NativeFieldInfoPtr_RsWSUMsvryjIITGEKdtRyoCPWDZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "RsWSUMsvryjIITGEKdtRyoCPWDZ");
				PlayerController.Element.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
				PlayerController.Element.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "dBMfgEzHekDWhMsmrRiTWJogtDs");
				PlayerController.Element.NativeFieldInfoPtr_aCwJbrGgPCcLHjBshrOTSlnllbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "aCwJbrGgPCcLHjBshrOTSlnllbJ");
				PlayerController.Element.NativeFieldInfoPtr_iPsqmEvQtBqmixAgQbSZqigDekiK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "iPsqmEvQtBqmixAgQbSZqigDekiK");
				PlayerController.Element.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666228);
				PlayerController.Element.NativeMethodInfoPtr_get_player_Protected_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666229);
				PlayerController.Element.NativeMethodInfoPtr_get_selfAndParentEnabled_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666230);
				PlayerController.Element.NativeMethodInfoPtr_get_isMemberElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666231);
				PlayerController.Element.NativeMethodInfoPtr_set_isMemberElement_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666232);
				PlayerController.Element.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666233);
				PlayerController.Element.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666234);
				PlayerController.Element.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666235);
				PlayerController.Element.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666236);
				PlayerController.Element.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666237);
				PlayerController.Element.NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666238);
				PlayerController.Element.NativeMethodInfoPtr_IsTypeWithSource_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666239);
				PlayerController.Element.NativeMethodInfoPtr_IsCompoundType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666240);
				PlayerController.Element.NativeMethodInfoPtr_GetMaxElementCount_Internal_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666241);
				PlayerController.Element.NativeMethodInfoPtr_GetElementTitle_Internal_Static_String_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666242);
				PlayerController.Element.NativeMethodInfoPtr_CreateDefinition_Internal_Static_Definition_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, 100666243);
			}

			// Token: 0x06003C5F RID: 15455 RVA: 0x00121CB4 File Offset: 0x0011FEB4
			[CallerCount(0)]
			public unsafe Element(PlayerController parent, PlayerController.Element.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700126F RID: 4719
			// (get) Token: 0x06003C60 RID: 15456 RVA: 0x00121D14 File Offset: 0x0011FF14
			public unsafe Player player
			{
				[CallerCount(27)]
				[CachedScanResults(RefRangeStart = 260651, RefRangeEnd = 260678, XrefRangeStart = 260643, XrefRangeEnd = 260651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_get_player_Protected_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
				}
			}

			// Token: 0x17001270 RID: 4720
			// (get) Token: 0x06003C61 RID: 15457 RVA: 0x00121D54 File Offset: 0x0011FF54
			public unsafe bool selfAndParentEnabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_get_selfAndParentEnabled_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001271 RID: 4721
			// (get) Token: 0x06003C62 RID: 15458 RVA: 0x00121D90 File Offset: 0x0011FF90
			// (set) Token: 0x06003C63 RID: 15459 RVA: 0x00121DCC File Offset: 0x0011FFCC
			public unsafe bool isMemberElement
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_get_isMemberElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_set_isMemberElement_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001272 RID: 4722
			// (get) Token: 0x06003C64 RID: 15460 RVA: 0x00121E0C File Offset: 0x0012000C
			// (set) Token: 0x06003C65 RID: 15461 RVA: 0x00121E48 File Offset: 0x00120048
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001273 RID: 4723
			// (get) Token: 0x06003C66 RID: 15462 RVA: 0x00121E88 File Offset: 0x00120088
			// (set) Token: 0x06003C67 RID: 15463 RVA: 0x00121EC0 File Offset: 0x001200C0
			public unsafe string name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003C68 RID: 15464 RVA: 0x00121F04 File Offset: 0x00120104
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Element.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C69 RID: 15465 RVA: 0x00121F40 File Offset: 0x00120140
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void EnabledStateChanged(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Element.NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003C6A RID: 15466 RVA: 0x00121F8C File Offset: 0x0012018C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260706, RefRangeEnd = 260709, XrefRangeStart = 260678, XrefRangeEnd = 260706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsTypeWithSource(PlayerController.Element.Type type)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_IsTypeWithSource_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C6B RID: 15467 RVA: 0x00121FCC File Offset: 0x001201CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260737, RefRangeEnd = 260740, XrefRangeStart = 260709, XrefRangeEnd = 260737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsCompoundType(PlayerController.Element.Type type)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_IsCompoundType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C6C RID: 15468 RVA: 0x0012200C File Offset: 0x0012020C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260740, XrefRangeEnd = 260742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetMaxElementCount(PlayerController.Element.Type type)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_GetMaxElementCount_Internal_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C6D RID: 15469 RVA: 0x0012204C File Offset: 0x0012024C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260742, XrefRangeEnd = 260751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetElementTitle(PlayerController.Element.Type type, int index)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_GetElementTitle_Internal_Static_String_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003C6E RID: 15470 RVA: 0x00122094 File Offset: 0x00120294
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260761, RefRangeEnd = 260763, XrefRangeStart = 260751, XrefRangeEnd = 260761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerController.Element.Definition CreateDefinition(PlayerController.Element.Type type)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.NativeMethodInfoPtr_CreateDefinition_Internal_Static_Definition_Type_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element.Definition>(intPtr3) : null;
				}
			}

			// Token: 0x06003C6F RID: 15471 RVA: 0x000156E5 File Offset: 0x000138E5
			public Element(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001268 RID: 4712
			// (get) Token: 0x06003C70 RID: 15472 RVA: 0x001220D4 File Offset: 0x001202D4
			// (set) Token: 0x06003C71 RID: 15473 RVA: 0x000156EE File Offset: 0x000138EE
			public unsafe static bool defaultEnabled
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Element.NativeFieldInfoPtr_defaultEnabled, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Element.NativeFieldInfoPtr_defaultEnabled, (void*)(&value));
				}
			}

			// Token: 0x17001269 RID: 4713
			// (get) Token: 0x06003C72 RID: 15474 RVA: 0x001220F0 File Offset: 0x001202F0
			// (set) Token: 0x06003C73 RID: 15475 RVA: 0x000156FC File Offset: 0x000138FC
			public unsafe PlayerController mcZTbbPGwEArYoSxgzyGmeIyAph
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126A RID: 4714
			// (get) Token: 0x06003C74 RID: 15476 RVA: 0x00122120 File Offset: 0x00120320
			// (set) Token: 0x06003C75 RID: 15477 RVA: 0x0001571B File Offset: 0x0001391B
			public unsafe bool RsWSUMsvryjIITGEKdtRyoCPWDZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_RsWSUMsvryjIITGEKdtRyoCPWDZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_RsWSUMsvryjIITGEKdtRyoCPWDZ)) = value;
				}
			}

			// Token: 0x1700126B RID: 4715
			// (get) Token: 0x06003C76 RID: 15478 RVA: 0x00122148 File Offset: 0x00120348
			// (set) Token: 0x06003C77 RID: 15479 RVA: 0x00015736 File Offset: 0x00013936
			public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
				}
			}

			// Token: 0x1700126C RID: 4716
			// (get) Token: 0x06003C78 RID: 15480 RVA: 0x00122170 File Offset: 0x00120370
			// (set) Token: 0x06003C79 RID: 15481 RVA: 0x00015751 File Offset: 0x00013951
			public unsafe string dBMfgEzHekDWhMsmrRiTWJogtDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700126D RID: 4717
			// (get) Token: 0x06003C7A RID: 15482 RVA: 0x00122198 File Offset: 0x00120398
			// (set) Token: 0x06003C7B RID: 15483 RVA: 0x00015770 File Offset: 0x00013970
			public unsafe static Il2CppStructArray<int> aCwJbrGgPCcLHjBshrOTSlnllbJ
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Element.NativeFieldInfoPtr_aCwJbrGgPCcLHjBshrOTSlnllbJ, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Element.NativeFieldInfoPtr_aCwJbrGgPCcLHjBshrOTSlnllbJ, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700126E RID: 4718
			// (get) Token: 0x06003C7C RID: 15484 RVA: 0x001221C0 File Offset: 0x001203C0
			// (set) Token: 0x06003C7D RID: 15485 RVA: 0x00015782 File Offset: 0x00013982
			public unsafe static Il2CppStructArray<int> iPsqmEvQtBqmixAgQbSZqigDekiK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Element.NativeFieldInfoPtr_iPsqmEvQtBqmixAgQbSZqigDekiK, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Element.NativeFieldInfoPtr_iPsqmEvQtBqmixAgQbSZqigDekiK, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003265 RID: 12901
			private static readonly IntPtr NativeFieldInfoPtr_defaultEnabled;

			// Token: 0x04003266 RID: 12902
			private static readonly IntPtr NativeFieldInfoPtr_mcZTbbPGwEArYoSxgzyGmeIyAph;

			// Token: 0x04003267 RID: 12903
			private static readonly IntPtr NativeFieldInfoPtr_RsWSUMsvryjIITGEKdtRyoCPWDZ;

			// Token: 0x04003268 RID: 12904
			private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

			// Token: 0x04003269 RID: 12905
			private static readonly IntPtr NativeFieldInfoPtr_dBMfgEzHekDWhMsmrRiTWJogtDs;

			// Token: 0x0400326A RID: 12906
			private static readonly IntPtr NativeFieldInfoPtr_aCwJbrGgPCcLHjBshrOTSlnllbJ;

			// Token: 0x0400326B RID: 12907
			private static readonly IntPtr NativeFieldInfoPtr_iPsqmEvQtBqmixAgQbSZqigDekiK;

			// Token: 0x0400326C RID: 12908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x0400326D RID: 12909
			private static readonly IntPtr NativeMethodInfoPtr_get_player_Protected_get_Player_0;

			// Token: 0x0400326E RID: 12910
			private static readonly IntPtr NativeMethodInfoPtr_get_selfAndParentEnabled_Protected_get_Boolean_0;

			// Token: 0x0400326F RID: 12911
			private static readonly IntPtr NativeMethodInfoPtr_get_isMemberElement_Internal_get_Boolean_0;

			// Token: 0x04003270 RID: 12912
			private static readonly IntPtr NativeMethodInfoPtr_set_isMemberElement_Internal_set_Void_Boolean_0;

			// Token: 0x04003271 RID: 12913
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003272 RID: 12914
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04003273 RID: 12915
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04003274 RID: 12916
			private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

			// Token: 0x04003275 RID: 12917
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_New_Void_0;

			// Token: 0x04003276 RID: 12918
			private static readonly IntPtr NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_New_Void_Boolean_0;

			// Token: 0x04003277 RID: 12919
			private static readonly IntPtr NativeMethodInfoPtr_IsTypeWithSource_Internal_Static_Boolean_Type_0;

			// Token: 0x04003278 RID: 12920
			private static readonly IntPtr NativeMethodInfoPtr_IsCompoundType_Internal_Static_Boolean_Type_0;

			// Token: 0x04003279 RID: 12921
			private static readonly IntPtr NativeMethodInfoPtr_GetMaxElementCount_Internal_Static_Int32_Type_0;

			// Token: 0x0400327A RID: 12922
			private static readonly IntPtr NativeMethodInfoPtr_GetElementTitle_Internal_Static_String_Type_Int32_0;

			// Token: 0x0400327B RID: 12923
			private static readonly IntPtr NativeMethodInfoPtr_CreateDefinition_Internal_Static_Definition_Type_0;

			// Token: 0x020004CB RID: 1227
			[OriginalName("Rewired_Core.dll", "", "Type")]
			public enum Type
			{
				// Token: 0x04004543 RID: 17731
				Button,
				// Token: 0x04004544 RID: 17732
				Axis,
				// Token: 0x04004545 RID: 17733
				MouseAxis,
				// Token: 0x04004546 RID: 17734
				MouseWheelAxis,
				// Token: 0x04004547 RID: 17735
				Axis2D = 100,
				// Token: 0x04004548 RID: 17736
				MouseAxis2D,
				// Token: 0x04004549 RID: 17737
				MouseWheel
			}

			// Token: 0x020004CC RID: 1228
			[OriginalName("Rewired_Core.dll", "", "TypeWithSource")]
			public enum TypeWithSource
			{
				// Token: 0x0400454B RID: 17739
				Button,
				// Token: 0x0400454C RID: 17740
				Axis,
				// Token: 0x0400454D RID: 17741
				MouseAxis,
				// Token: 0x0400454E RID: 17742
				MouseWheelAxis
			}

			// Token: 0x020004CD RID: 1229
			[OriginalName("Rewired_Core.dll", "", "CompoundTypes")]
			public enum CompoundTypes
			{
				// Token: 0x04004550 RID: 17744
				Axis2D = 100,
				// Token: 0x04004551 RID: 17745
				MouseAxis2D,
				// Token: 0x04004552 RID: 17746
				MouseWheel
			}

			// Token: 0x020004CE RID: 1230
			public class Definition : global::Il2CppSystem.Object
			{
				// Token: 0x060052A4 RID: 21156 RVA: 0x00176838 File Offset: 0x00174A38
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr);
					PlayerController.Element.Definition.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr, "enabled");
					PlayerController.Element.Definition.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr, "name");
					PlayerController.Element.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr, 100666244);
					PlayerController.Element.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Abstract_Virtual_New_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr, 100666245);
				}

				// Token: 0x060052A5 RID: 21157 RVA: 0x001768B4 File Offset: 0x00174AB4
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260641, RefRangeEnd = 260643, XrefRangeStart = 260641, XrefRangeEnd = 260641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Element.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052A6 RID: 21158 RVA: 0x001768F0 File Offset: 0x00174AF0
				[CallerCount(0)]
				public unsafe virtual PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Element.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Abstract_Virtual_New_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052A7 RID: 21159 RVA: 0x0001DDFF File Offset: 0x0001BFFF
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001957 RID: 6487
				// (get) Token: 0x060052A8 RID: 21160 RVA: 0x0017694C File Offset: 0x00174B4C
				// (set) Token: 0x060052A9 RID: 21161 RVA: 0x0001DE08 File Offset: 0x0001C008
				public unsafe bool enabled
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.Definition.NativeFieldInfoPtr_enabled);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.Definition.NativeFieldInfoPtr_enabled)) = value;
					}
				}

				// Token: 0x17001958 RID: 6488
				// (get) Token: 0x060052AA RID: 21162 RVA: 0x00176974 File Offset: 0x00174B74
				// (set) Token: 0x060052AB RID: 21163 RVA: 0x0001DE23 File Offset: 0x0001C023
				public unsafe string name
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.Definition.NativeFieldInfoPtr_name);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Element.Definition.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04004553 RID: 17747
				private static readonly IntPtr NativeFieldInfoPtr_enabled;

				// Token: 0x04004554 RID: 17748
				private static readonly IntPtr NativeFieldInfoPtr_name;

				// Token: 0x04004555 RID: 17749
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004556 RID: 17750
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Abstract_Virtual_New_Element_PlayerController_0;
			}

			// Token: 0x020004CF RID: 1231
			[StructLayout(2)]
			public struct xJqaGQGRranoVpqxOGfDPJdALfA
			{
				// Token: 0x060052AC RID: 21164 RVA: 0x0017699C File Offset: 0x00174B9C
				// Note: this type is marked as 'beforefieldinit'.
				static xJqaGQGRranoVpqxOGfDPJdALfA()
				{
					Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.Element>.NativeClassPtr, "xJqaGQGRranoVpqxOGfDPJdALfA");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr);
					PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA.NativeFieldInfoPtr_CHaEJkIgFdQGmISJDTXBVBdlFsSx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr, "CHaEJkIgFdQGmISJDTXBVBdlFsSx");
					PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA.NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr, "DvCDMNCBudLHkpnvfpAAHNGzbZYB");
					PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA.NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr, "wvNaDPcNUyHJKWogdKCZCqbNISpy");
					PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementType_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr, 100666246);
				}

				// Token: 0x060052AD RID: 21165 RVA: 0x00176A18 File Offset: 0x00174C18
				[CallerCount(0)]
				public unsafe xJqaGQGRranoVpqxOGfDPJdALfA(ControllerElementType elementType, int index, float value)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref elementType;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA.NativeMethodInfoPtr__ctor_Public_Void_ControllerElementType_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052AE RID: 21166 RVA: 0x0001DE42 File Offset: 0x0001C042
				public global::Il2CppSystem.Object BoxIl2CppObject()
				{
					return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerController.Element.xJqaGQGRranoVpqxOGfDPJdALfA>.NativeClassPtr, ref this));
				}

				// Token: 0x04004557 RID: 17751
				private static readonly IntPtr NativeFieldInfoPtr_CHaEJkIgFdQGmISJDTXBVBdlFsSx;

				// Token: 0x04004558 RID: 17752
				private static readonly IntPtr NativeFieldInfoPtr_DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x04004559 RID: 17753
				private static readonly IntPtr NativeFieldInfoPtr_wvNaDPcNUyHJKWogdKCZCqbNISpy;

				// Token: 0x0400455A RID: 17754
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerElementType_Int32_Single_0;

				// Token: 0x0400455B RID: 17755
				[FieldOffset(0)]
				public ControllerElementType CHaEJkIgFdQGmISJDTXBVBdlFsSx;

				// Token: 0x0400455C RID: 17756
				[FieldOffset(4)]
				public int DvCDMNCBudLHkpnvfpAAHNGzbZYB;

				// Token: 0x0400455D RID: 17757
				[FieldOffset(8)]
				public float wvNaDPcNUyHJKWogdKCZCqbNISpy;
			}
		}

		// Token: 0x020002A3 RID: 675
		public class ElementWithSource : PlayerController.Element
		{
			// Token: 0x06003C7E RID: 15486 RVA: 0x001221E8 File Offset: 0x001203E8
			// Note: this type is marked as 'beforefieldinit'.
			static ElementWithSource()
			{
				Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "ElementWithSource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr);
				PlayerController.ElementWithSource.NativeFieldInfoPtr_defaultActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, "defaultActionId");
				PlayerController.ElementWithSource.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, "HSNQHCcXgyznRFxfZdJonabrHRG");
				PlayerController.ElementWithSource.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, 100666247);
				PlayerController.ElementWithSource.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, 100666248);
				PlayerController.ElementWithSource.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, 100666249);
				PlayerController.ElementWithSource.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, 100666250);
				PlayerController.ElementWithSource.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, 100666251);
			}

			// Token: 0x06003C7F RID: 15487 RVA: 0x001222A0 File Offset: 0x001204A0
			[CallerCount(0)]
			public unsafe ElementWithSource(PlayerController parent, PlayerController.ElementWithSource.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001276 RID: 4726
			// (get) Token: 0x06003C80 RID: 15488 RVA: 0x00122300 File Offset: 0x00120500
			// (set) Token: 0x06003C81 RID: 15489 RVA: 0x0012233C File Offset: 0x0012053C
			public unsafe int actionId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001277 RID: 4727
			// (get) Token: 0x06003C82 RID: 15490 RVA: 0x0012237C File Offset: 0x0012057C
			// (set) Token: 0x06003C83 RID: 15491 RVA: 0x001223B4 File Offset: 0x001205B4
			public unsafe string actionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260780, XrefRangeEnd = 260788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 260796, RefRangeEnd = 260802, XrefRangeStart = 260788, XrefRangeEnd = 260796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003C84 RID: 15492 RVA: 0x00015794 File Offset: 0x00013994
			public ElementWithSource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001274 RID: 4724
			// (get) Token: 0x06003C85 RID: 15493 RVA: 0x001223F8 File Offset: 0x001205F8
			// (set) Token: 0x06003C86 RID: 15494 RVA: 0x0001579D File Offset: 0x0001399D
			public unsafe static int defaultActionId
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.ElementWithSource.NativeFieldInfoPtr_defaultActionId, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.ElementWithSource.NativeFieldInfoPtr_defaultActionId, (void*)(&value));
				}
			}

			// Token: 0x17001275 RID: 4725
			// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00122414 File Offset: 0x00120614
			// (set) Token: 0x06003C88 RID: 15496 RVA: 0x000157AB File Offset: 0x000139AB
			public unsafe int HSNQHCcXgyznRFxfZdJonabrHRG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSource.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSource.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG)) = value;
				}
			}

			// Token: 0x0400327C RID: 12924
			private static readonly IntPtr NativeFieldInfoPtr_defaultActionId;

			// Token: 0x0400327D RID: 12925
			private static readonly IntPtr NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG;

			// Token: 0x0400327E RID: 12926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x0400327F RID: 12927
			private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

			// Token: 0x04003280 RID: 12928
			private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

			// Token: 0x04003281 RID: 12929
			private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

			// Token: 0x04003282 RID: 12930
			private static readonly IntPtr NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0;

			// Token: 0x020004D0 RID: 1232
			public new class Definition : PlayerController.Element.Definition
			{
				// Token: 0x060052AF RID: 21167 RVA: 0x00176A68 File Offset: 0x00174C68
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.ElementWithSource>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr);
					PlayerController.ElementWithSource.Definition.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, "HSNQHCcXgyznRFxfZdJonabrHRG");
					PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, 100666252);
					PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, 100666253);
					PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, 100666254);
					PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, 100666255);
					PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr, 100666256);
				}

				// Token: 0x060052B0 RID: 21168 RVA: 0x00176B0C File Offset: 0x00174D0C
				[CallerCount(0)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.ElementWithSource.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700195A RID: 6490
				// (get) Token: 0x060052B1 RID: 21169 RVA: 0x00176B48 File Offset: 0x00174D48
				// (set) Token: 0x060052B2 RID: 21170 RVA: 0x00176B84 File Offset: 0x00174D84
				public unsafe int actionId
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700195B RID: 6491
				// (get) Token: 0x060052B3 RID: 21171 RVA: 0x00176BC4 File Offset: 0x00174DC4
				// (set) Token: 0x060052B4 RID: 21172 RVA: 0x00176BFC File Offset: 0x00174DFC
				public unsafe string actionName
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260763, XrefRangeEnd = 260771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260771, XrefRangeEnd = 260780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.ElementWithSource.Definition.NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060052B5 RID: 21173 RVA: 0x0001DE54 File Offset: 0x0001C054
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001959 RID: 6489
				// (get) Token: 0x060052B6 RID: 21174 RVA: 0x00176C40 File Offset: 0x00174E40
				// (set) Token: 0x060052B7 RID: 21175 RVA: 0x0001DE5D File Offset: 0x0001C05D
				public unsafe int HSNQHCcXgyznRFxfZdJonabrHRG
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSource.Definition.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.ElementWithSource.Definition.NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG)) = value;
					}
				}

				// Token: 0x0400455E RID: 17758
				private static readonly IntPtr NativeFieldInfoPtr_HSNQHCcXgyznRFxfZdJonabrHRG;

				// Token: 0x0400455F RID: 17759
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004560 RID: 17760
				private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

				// Token: 0x04004561 RID: 17761
				private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

				// Token: 0x04004562 RID: 17762
				private static readonly IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

				// Token: 0x04004563 RID: 17763
				private static readonly IntPtr NativeMethodInfoPtr_set_actionName_Public_set_Void_String_0;
			}
		}

		// Token: 0x020002A4 RID: 676
		public class Axis : PlayerController.ElementWithSource
		{
			// Token: 0x06003C89 RID: 15497 RVA: 0x0012243C File Offset: 0x0012063C
			// Note: this type is marked as 'beforefieldinit'.
			static Axis()
			{
				Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Axis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr);
				PlayerController.Axis.NativeFieldInfoPtr_vokcwfJDAvMpWtAVMTzPhnSBlMv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, "vokcwfJDAvMpWtAVMTzPhnSBlMv");
				PlayerController.Axis.NativeFieldInfoPtr_defaultAxisCoordinateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, "defaultAxisCoordinateMode");
				PlayerController.Axis.NativeFieldInfoPtr_wvLANtiJUwzTqIddYKaFtcNtfac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, "wvLANtiJUwzTqIddYKaFtcNtfac");
				PlayerController.Axis.NativeFieldInfoPtr_GQMeVWhyPmginjVfWRjBeuTHkYEu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, "GQMeVWhyPmginjVfWRjBeuTHkYEu");
				PlayerController.Axis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666257);
				PlayerController.Axis.NativeMethodInfoPtr_get_absoluteToRelativeSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666258);
				PlayerController.Axis.NativeMethodInfoPtr_set_absoluteToRelativeSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666259);
				PlayerController.Axis.NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666260);
				PlayerController.Axis.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666261);
				PlayerController.Axis.NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, 100666262);
			}

			// Token: 0x06003C8A RID: 15498 RVA: 0x00122530 File Offset: 0x00120730
			[CallerCount(0)]
			public unsafe Axis(PlayerController parent, PlayerController.Axis.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700127C RID: 4732
			// (get) Token: 0x06003C8B RID: 15499 RVA: 0x00122590 File Offset: 0x00120790
			// (set) Token: 0x06003C8C RID: 15500 RVA: 0x001225CC File Offset: 0x001207CC
			public unsafe float absoluteToRelativeSensitivity
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis.NativeMethodInfoPtr_get_absoluteToRelativeSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis.NativeMethodInfoPtr_set_absoluteToRelativeSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700127D RID: 4733
			// (get) Token: 0x06003C8D RID: 15501 RVA: 0x0012260C File Offset: 0x0012080C
			public unsafe AxisCoordinateMode coordinateMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis.NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700127E RID: 4734
			// (get) Token: 0x06003C8E RID: 15502 RVA: 0x00122648 File Offset: 0x00120848
			public unsafe virtual float value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260820, XrefRangeEnd = 260826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700127F RID: 4735
			// (get) Token: 0x06003C8F RID: 15503 RVA: 0x00122690 File Offset: 0x00120890
			public unsafe virtual float valueRaw
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260826, XrefRangeEnd = 260829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis.NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C90 RID: 15504 RVA: 0x000157C6 File Offset: 0x000139C6
			public Axis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001278 RID: 4728
			// (get) Token: 0x06003C91 RID: 15505 RVA: 0x001226D8 File Offset: 0x001208D8
			// (set) Token: 0x06003C92 RID: 15506 RVA: 0x000157CF File Offset: 0x000139CF
			public unsafe static float vokcwfJDAvMpWtAVMTzPhnSBlMv
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Axis.NativeFieldInfoPtr_vokcwfJDAvMpWtAVMTzPhnSBlMv, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Axis.NativeFieldInfoPtr_vokcwfJDAvMpWtAVMTzPhnSBlMv, (void*)(&value));
				}
			}

			// Token: 0x17001279 RID: 4729
			// (get) Token: 0x06003C93 RID: 15507 RVA: 0x001226F4 File Offset: 0x001208F4
			// (set) Token: 0x06003C94 RID: 15508 RVA: 0x000157DD File Offset: 0x000139DD
			public unsafe static AxisCoordinateMode defaultAxisCoordinateMode
			{
				get
				{
					AxisCoordinateMode axisCoordinateMode;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Axis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&axisCoordinateMode));
					return axisCoordinateMode;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Axis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&value));
				}
			}

			// Token: 0x1700127A RID: 4730
			// (get) Token: 0x06003C95 RID: 15509 RVA: 0x00122710 File Offset: 0x00120910
			// (set) Token: 0x06003C96 RID: 15510 RVA: 0x000157EB File Offset: 0x000139EB
			public unsafe float wvLANtiJUwzTqIddYKaFtcNtfac
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.NativeFieldInfoPtr_wvLANtiJUwzTqIddYKaFtcNtfac);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.NativeFieldInfoPtr_wvLANtiJUwzTqIddYKaFtcNtfac)) = value;
				}
			}

			// Token: 0x1700127B RID: 4731
			// (get) Token: 0x06003C97 RID: 15511 RVA: 0x00122738 File Offset: 0x00120938
			// (set) Token: 0x06003C98 RID: 15512 RVA: 0x00015806 File Offset: 0x00013A06
			public unsafe AxisCoordinateMode GQMeVWhyPmginjVfWRjBeuTHkYEu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.NativeFieldInfoPtr_GQMeVWhyPmginjVfWRjBeuTHkYEu);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.NativeFieldInfoPtr_GQMeVWhyPmginjVfWRjBeuTHkYEu)) = value;
				}
			}

			// Token: 0x04003283 RID: 12931
			private static readonly IntPtr NativeFieldInfoPtr_vokcwfJDAvMpWtAVMTzPhnSBlMv;

			// Token: 0x04003284 RID: 12932
			private static readonly IntPtr NativeFieldInfoPtr_defaultAxisCoordinateMode;

			// Token: 0x04003285 RID: 12933
			private static readonly IntPtr NativeFieldInfoPtr_wvLANtiJUwzTqIddYKaFtcNtfac;

			// Token: 0x04003286 RID: 12934
			private static readonly IntPtr NativeFieldInfoPtr_GQMeVWhyPmginjVfWRjBeuTHkYEu;

			// Token: 0x04003287 RID: 12935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x04003288 RID: 12936
			private static readonly IntPtr NativeMethodInfoPtr_get_absoluteToRelativeSensitivity_Public_get_Single_0;

			// Token: 0x04003289 RID: 12937
			private static readonly IntPtr NativeMethodInfoPtr_set_absoluteToRelativeSensitivity_Public_set_Void_Single_0;

			// Token: 0x0400328A RID: 12938
			private static readonly IntPtr NativeMethodInfoPtr_get_coordinateMode_Public_get_AxisCoordinateMode_0;

			// Token: 0x0400328B RID: 12939
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0;

			// Token: 0x0400328C RID: 12940
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Single_0;

			// Token: 0x020004D1 RID: 1233
			public new class Definition : PlayerController.ElementWithSource.Definition
			{
				// Token: 0x060052B8 RID: 21176 RVA: 0x00176C68 File Offset: 0x00174E68
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.Axis>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr);
					PlayerController.Axis.Definition.NativeFieldInfoPtr_coordinateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr, "coordinateMode");
					PlayerController.Axis.Definition.NativeFieldInfoPtr_absoluteToRelativeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr, "absoluteToRelativeSensitivity");
					PlayerController.Axis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr, 100666263);
					PlayerController.Axis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr, 100666264);
				}

				// Token: 0x060052B9 RID: 21177 RVA: 0x00176CE4 File Offset: 0x00174EE4
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 260802, RefRangeEnd = 260817, XrefRangeStart = 260802, XrefRangeEnd = 260802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Axis.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052BA RID: 21178 RVA: 0x00176D20 File Offset: 0x00174F20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260817, XrefRangeEnd = 260820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052BB RID: 21179 RVA: 0x0001DE78 File Offset: 0x0001C078
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700195C RID: 6492
				// (get) Token: 0x060052BC RID: 21180 RVA: 0x00176D7C File Offset: 0x00174F7C
				// (set) Token: 0x060052BD RID: 21181 RVA: 0x0001DE81 File Offset: 0x0001C081
				public unsafe AxisCoordinateMode coordinateMode
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.Definition.NativeFieldInfoPtr_coordinateMode);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.Definition.NativeFieldInfoPtr_coordinateMode)) = value;
					}
				}

				// Token: 0x1700195D RID: 6493
				// (get) Token: 0x060052BE RID: 21182 RVA: 0x00176DA4 File Offset: 0x00174FA4
				// (set) Token: 0x060052BF RID: 21183 RVA: 0x0001DE9C File Offset: 0x0001C09C
				public unsafe float absoluteToRelativeSensitivity
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.Definition.NativeFieldInfoPtr_absoluteToRelativeSensitivity);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis.Definition.NativeFieldInfoPtr_absoluteToRelativeSensitivity)) = value;
					}
				}

				// Token: 0x04004564 RID: 17764
				private static readonly IntPtr NativeFieldInfoPtr_coordinateMode;

				// Token: 0x04004565 RID: 17765
				private static readonly IntPtr NativeFieldInfoPtr_absoluteToRelativeSensitivity;

				// Token: 0x04004566 RID: 17766
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004567 RID: 17767
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002A5 RID: 677
		public class MouseAxis : PlayerController.Axis
		{
			// Token: 0x06003C99 RID: 15513 RVA: 0x00122760 File Offset: 0x00120960
			// Note: this type is marked as 'beforefieldinit'.
			static MouseAxis()
			{
				Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "MouseAxis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr);
				PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr, "defaultAxisCoordinateMode");
				PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAbsoluteToRelativeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr, "defaultAbsoluteToRelativeSensitivity");
				PlayerController.MouseAxis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr, 100666265);
				PlayerController.MouseAxis.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr, 100666266);
			}

			// Token: 0x06003C9A RID: 15514 RVA: 0x001227DC File Offset: 0x001209DC
			[CallerCount(0)]
			public unsafe MouseAxis(PlayerController parent, PlayerController.MouseAxis.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001282 RID: 4738
			// (get) Token: 0x06003C9B RID: 15515 RVA: 0x0012283C File Offset: 0x00120A3C
			public unsafe override float value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260833, XrefRangeEnd = 260839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.MouseAxis.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C9C RID: 15516 RVA: 0x00015821 File Offset: 0x00013A21
			public MouseAxis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001280 RID: 4736
			// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00122884 File Offset: 0x00120A84
			// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0001582A File Offset: 0x00013A2A
			public new unsafe static AxisCoordinateMode defaultAxisCoordinateMode
			{
				get
				{
					AxisCoordinateMode axisCoordinateMode;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&axisCoordinateMode));
					return axisCoordinateMode;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&value));
				}
			}

			// Token: 0x17001281 RID: 4737
			// (get) Token: 0x06003C9F RID: 15519 RVA: 0x001228A0 File Offset: 0x00120AA0
			// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x00015838 File Offset: 0x00013A38
			public unsafe static float defaultAbsoluteToRelativeSensitivity
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAbsoluteToRelativeSensitivity, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.MouseAxis.NativeFieldInfoPtr_defaultAbsoluteToRelativeSensitivity, (void*)(&value));
				}
			}

			// Token: 0x0400328D RID: 12941
			private static readonly IntPtr NativeFieldInfoPtr_defaultAxisCoordinateMode;

			// Token: 0x0400328E RID: 12942
			private static readonly IntPtr NativeFieldInfoPtr_defaultAbsoluteToRelativeSensitivity;

			// Token: 0x0400328F RID: 12943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x04003290 RID: 12944
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

			// Token: 0x020004D2 RID: 1234
			public new class Definition : PlayerController.Axis.Definition
			{
				// Token: 0x060052C0 RID: 21184 RVA: 0x00176DCC File Offset: 0x00174FCC
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.MouseAxis.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.MouseAxis>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseAxis.Definition>.NativeClassPtr);
					PlayerController.MouseAxis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis.Definition>.NativeClassPtr, 100666267);
					PlayerController.MouseAxis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis.Definition>.NativeClassPtr, 100666268);
				}

				// Token: 0x060052C1 RID: 21185 RVA: 0x00176E20 File Offset: 0x00175020
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260829, XrefRangeEnd = 260830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseAxis.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052C2 RID: 21186 RVA: 0x00176E5C File Offset: 0x0017505C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260830, XrefRangeEnd = 260833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.MouseAxis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052C3 RID: 21187 RVA: 0x0001DEB7 File Offset: 0x0001C0B7
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004568 RID: 17768
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004569 RID: 17769
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002A6 RID: 678
		public class CompoundElement : PlayerController.Element
		{
			// Token: 0x06003CA1 RID: 15521 RVA: 0x001228BC File Offset: 0x00120ABC
			// Note: this type is marked as 'beforefieldinit'.
			static CompoundElement()
			{
				Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "CompoundElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr);
				PlayerController.CompoundElement.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, "xQkGABJRsmzTPSmeXgqJmJTMBma");
				PlayerController.CompoundElement.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, 100666269);
				PlayerController.CompoundElement.NativeMethodInfoPtr_get_elementCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, 100666270);
				PlayerController.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, 100666271);
				PlayerController.CompoundElement.NativeMethodInfoPtr_adeHnMDLgtCltiGaagpPzVusrDmG_Internal_Void_List_1_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, 100666272);
				PlayerController.CompoundElement.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, 100666273);
			}

			// Token: 0x06003CA2 RID: 15522 RVA: 0x00122960 File Offset: 0x00120B60
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260849, RefRangeEnd = 260854, XrefRangeStart = 260839, XrefRangeEnd = 260849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompoundElement(PlayerController parent, PlayerController.CompoundElement.Definition definition, Il2CppReferenceArray<PlayerController.Element.Definition> elementDefinitions)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementDefinitions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001284 RID: 4740
			// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x001229D0 File Offset: 0x00120BD0
			public unsafe int elementCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260854, XrefRangeEnd = 260855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.NativeMethodInfoPtr_get_elementCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CA4 RID: 15524 RVA: 0x00122A0C File Offset: 0x00120C0C
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 260862, RefRangeEnd = 260875, XrefRangeStart = 260855, XrefRangeEnd = 260862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T ffDeAbKJpVsIgLYjXxEUfwosxXOK<T>(int A_1) where T : PlayerController.Element
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.MethodInfoStoreGeneric_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06003CA5 RID: 15525 RVA: 0x00122A54 File Offset: 0x00120C54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260885, RefRangeEnd = 260886, XrefRangeStart = 260875, XrefRangeEnd = 260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void adeHnMDLgtCltiGaagpPzVusrDmG(List<PlayerController.Element> A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.NativeMethodInfoPtr_adeHnMDLgtCltiGaagpPzVusrDmG_Internal_Void_List_1_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003CA6 RID: 15526 RVA: 0x00122A98 File Offset: 0x00120C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260886, XrefRangeEnd = 260889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FtpfwMCKfMCnbBBezixohHaJHAGb(PlayerController.Element A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003CA7 RID: 15527 RVA: 0x00015846 File Offset: 0x00013A46
			public CompoundElement(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001283 RID: 4739
			// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x00122ADC File Offset: 0x00120CDC
			// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x0001584F File Offset: 0x00013A4F
			public unsafe List<PlayerController.Element> xQkGABJRsmzTPSmeXgqJmJTMBma
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.CompoundElement.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerController.Element>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.CompoundElement.NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003291 RID: 12945
			private static readonly IntPtr NativeFieldInfoPtr_xQkGABJRsmzTPSmeXgqJmJTMBma;

			// Token: 0x04003292 RID: 12946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0;

			// Token: 0x04003293 RID: 12947
			private static readonly IntPtr NativeMethodInfoPtr_get_elementCount_Internal_get_Int32_0;

			// Token: 0x04003294 RID: 12948
			private static readonly IntPtr NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0;

			// Token: 0x04003295 RID: 12949
			private static readonly IntPtr NativeMethodInfoPtr_adeHnMDLgtCltiGaagpPzVusrDmG_Internal_Void_List_1_Element_0;

			// Token: 0x04003296 RID: 12950
			private static readonly IntPtr NativeMethodInfoPtr_FtpfwMCKfMCnbBBezixohHaJHAGb_Internal_Void_Element_0;

			// Token: 0x020004D3 RID: 1235
			public new class Definition : PlayerController.Element.Definition
			{
				// Token: 0x060052C4 RID: 21188 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.CompoundElement.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.CompoundElement.Definition>.NativeClassPtr);
					PlayerController.CompoundElement.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.CompoundElement.Definition>.NativeClassPtr, 100666274);
				}

				// Token: 0x060052C5 RID: 21189 RVA: 0x00176EB8 File Offset: 0x001750B8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260641, RefRangeEnd = 260643, XrefRangeStart = 260641, XrefRangeEnd = 260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.CompoundElement.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.CompoundElement.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052C6 RID: 21190 RVA: 0x0001DEF4 File Offset: 0x0001C0F4
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400456A RID: 17770
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x020004D4 RID: 1236
			private sealed class MethodInfoStoreGeneric_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0<T>
			{
				// Token: 0x0400456B RID: 17771
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayerController.CompoundElement.NativeMethodInfoPtr_ffDeAbKJpVsIgLYjXxEUfwosxXOK_Internal_T_Int32_0, Il2CppClassPointerStore<PlayerController.CompoundElement>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x020002A7 RID: 679
		public class Axis2D : PlayerController.CompoundElement
		{
			// Token: 0x06003CAA RID: 15530 RVA: 0x00122B0C File Offset: 0x00120D0C
			// Note: this type is marked as 'beforefieldinit'.
			static Axis2D()
			{
				Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Axis2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr);
				PlayerController.Axis2D.NativeFieldInfoPtr_OOrAfwUCZCrWnpZnCijlWzrqdQB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, "OOrAfwUCZCrWnpZnCijlWzrqdQB");
				PlayerController.Axis2D.NativeFieldInfoPtr_UVysAttwQtPkOroxeRYXMboCikZf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, "UVysAttwQtPkOroxeRYXMboCikZf");
				PlayerController.Axis2D.NativeFieldInfoPtr_QhTVpQlvKMBPOhbuxWQwlipvbQl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, "QhTVpQlvKMBPOhbuxWQwlipvbQl");
				PlayerController.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666275);
				PlayerController.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666276);
				PlayerController.Axis2D.NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666277);
				PlayerController.Axis2D.NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666278);
				PlayerController.Axis2D.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666279);
				PlayerController.Axis2D.NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, 100666280);
			}

			// Token: 0x06003CAB RID: 15531 RVA: 0x00122BEC File Offset: 0x00120DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260908, XrefRangeEnd = 260909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis2D(PlayerController parent, PlayerController.Axis2D.Definition definition, Il2CppReferenceArray<PlayerController.Element.Definition> definitions)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definitions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CAC RID: 15532 RVA: 0x00122C5C File Offset: 0x00120E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260909, XrefRangeEnd = 260925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Axis2D(PlayerController parent, PlayerController.Axis2D.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001288 RID: 4744
			// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00122CBC File Offset: 0x00120EBC
			public unsafe PlayerController.Axis xAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260925, XrefRangeEnd = 260928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis>(intPtr3) : null;
				}
			}

			// Token: 0x17001289 RID: 4745
			// (get) Token: 0x06003CAE RID: 15534 RVA: 0x00122CFC File Offset: 0x00120EFC
			public unsafe PlayerController.Axis yAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260928, XrefRangeEnd = 260931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis>(intPtr3) : null;
				}
			}

			// Token: 0x1700128A RID: 4746
			// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00122D3C File Offset: 0x00120F3C
			public unsafe virtual Vector2 value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260931, XrefRangeEnd = 260936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis2D.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700128B RID: 4747
			// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x00122D84 File Offset: 0x00120F84
			public unsafe virtual Vector2 valueRaw
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260936, XrefRangeEnd = 260941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis2D.NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CB1 RID: 15537 RVA: 0x0001586E File Offset: 0x00013A6E
			public Axis2D(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001285 RID: 4741
			// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x00122DCC File Offset: 0x00120FCC
			// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x00015877 File Offset: 0x00013A77
			public unsafe static int OOrAfwUCZCrWnpZnCijlWzrqdQB
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Axis2D.NativeFieldInfoPtr_OOrAfwUCZCrWnpZnCijlWzrqdQB, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Axis2D.NativeFieldInfoPtr_OOrAfwUCZCrWnpZnCijlWzrqdQB, (void*)(&value));
				}
			}

			// Token: 0x17001286 RID: 4742
			// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x00122DE8 File Offset: 0x00120FE8
			// (set) Token: 0x06003CB5 RID: 15541 RVA: 0x00015885 File Offset: 0x00013A85
			public unsafe static int UVysAttwQtPkOroxeRYXMboCikZf
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Axis2D.NativeFieldInfoPtr_UVysAttwQtPkOroxeRYXMboCikZf, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Axis2D.NativeFieldInfoPtr_UVysAttwQtPkOroxeRYXMboCikZf, (void*)(&value));
				}
			}

			// Token: 0x17001287 RID: 4743
			// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x00122E04 File Offset: 0x00121004
			// (set) Token: 0x06003CB7 RID: 15543 RVA: 0x00015893 File Offset: 0x00013A93
			public unsafe static int QhTVpQlvKMBPOhbuxWQwlipvbQl
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.Axis2D.NativeFieldInfoPtr_QhTVpQlvKMBPOhbuxWQwlipvbQl, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.Axis2D.NativeFieldInfoPtr_QhTVpQlvKMBPOhbuxWQwlipvbQl, (void*)(&value));
				}
			}

			// Token: 0x04003297 RID: 12951
			private static readonly IntPtr NativeFieldInfoPtr_OOrAfwUCZCrWnpZnCijlWzrqdQB;

			// Token: 0x04003298 RID: 12952
			private static readonly IntPtr NativeFieldInfoPtr_UVysAttwQtPkOroxeRYXMboCikZf;

			// Token: 0x04003299 RID: 12953
			private static readonly IntPtr NativeFieldInfoPtr_QhTVpQlvKMBPOhbuxWQwlipvbQl;

			// Token: 0x0400329A RID: 12954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_Il2CppReferenceArray_1_Definition_0;

			// Token: 0x0400329B RID: 12955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x0400329C RID: 12956
			private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_Axis_0;

			// Token: 0x0400329D RID: 12957
			private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_Axis_0;

			// Token: 0x0400329E RID: 12958
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Vector2_0;

			// Token: 0x0400329F RID: 12959
			private static readonly IntPtr NativeMethodInfoPtr_get_valueRaw_Public_Virtual_New_get_Vector2_0;

			// Token: 0x020004D5 RID: 1237
			public new class Definition : PlayerController.CompoundElement.Definition
			{
				// Token: 0x060052C8 RID: 21192 RVA: 0x00176F48 File Offset: 0x00175148
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.Axis2D>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr);
					PlayerController.Axis2D.Definition.NativeFieldInfoPtr_knCqmtlDSMPDwUfHUshYbsbYgaJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, "knCqmtlDSMPDwUfHUshYbsbYgaJ");
					PlayerController.Axis2D.Definition.NativeFieldInfoPtr_yuDgMdwLRHyRKekRSRYAGcEhaGN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, "yuDgMdwLRHyRKekRSRYAGcEhaGN");
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666281);
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666282);
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666283);
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666284);
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666285);
					PlayerController.Axis2D.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr, 100666286);
				}

				// Token: 0x060052C9 RID: 21193 RVA: 0x00177014 File Offset: 0x00175214
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260641, RefRangeEnd = 260643, XrefRangeStart = 260641, XrefRangeEnd = 260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Axis2D.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001960 RID: 6496
				// (get) Token: 0x060052CA RID: 21194 RVA: 0x00177050 File Offset: 0x00175250
				// (set) Token: 0x060052CB RID: 21195 RVA: 0x00177090 File Offset: 0x00175290
				public unsafe PlayerController.Axis.Definition xAxis
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis.Definition>(intPtr3) : null;
					}
					[CallerCount(33)]
					[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001961 RID: 6497
				// (get) Token: 0x060052CC RID: 21196 RVA: 0x001770D4 File Offset: 0x001752D4
				// (set) Token: 0x060052CD RID: 21197 RVA: 0x00177114 File Offset: 0x00175314
				public unsafe PlayerController.Axis.Definition yAxis
				{
					[CallerCount(3)]
					[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis.Definition>(intPtr3) : null;
					}
					[CallerCount(38)]
					[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Axis2D.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060052CE RID: 21198 RVA: 0x00177158 File Offset: 0x00175358
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260889, XrefRangeEnd = 260908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Axis2D.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052CF RID: 21199 RVA: 0x0001DEFD File Offset: 0x0001C0FD
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700195E RID: 6494
				// (get) Token: 0x060052D0 RID: 21200 RVA: 0x001771B4 File Offset: 0x001753B4
				// (set) Token: 0x060052D1 RID: 21201 RVA: 0x0001DF06 File Offset: 0x0001C106
				public unsafe PlayerController.Axis.Definition knCqmtlDSMPDwUfHUshYbsbYgaJ
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis2D.Definition.NativeFieldInfoPtr_knCqmtlDSMPDwUfHUshYbsbYgaJ);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis.Definition>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis2D.Definition.NativeFieldInfoPtr_knCqmtlDSMPDwUfHUshYbsbYgaJ), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700195F RID: 6495
				// (get) Token: 0x060052D2 RID: 21202 RVA: 0x001771E4 File Offset: 0x001753E4
				// (set) Token: 0x060052D3 RID: 21203 RVA: 0x0001DF25 File Offset: 0x0001C125
				public unsafe PlayerController.Axis.Definition yuDgMdwLRHyRKekRSRYAGcEhaGN
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis2D.Definition.NativeFieldInfoPtr_yuDgMdwLRHyRKekRSRYAGcEhaGN);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerController.Axis.Definition>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.Axis2D.Definition.NativeFieldInfoPtr_yuDgMdwLRHyRKekRSRYAGcEhaGN), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400456C RID: 17772
				private static readonly IntPtr NativeFieldInfoPtr_knCqmtlDSMPDwUfHUshYbsbYgaJ;

				// Token: 0x0400456D RID: 17773
				private static readonly IntPtr NativeFieldInfoPtr_yuDgMdwLRHyRKekRSRYAGcEhaGN;

				// Token: 0x0400456E RID: 17774
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400456F RID: 17775
				private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0;

				// Token: 0x04004570 RID: 17776
				private static readonly IntPtr NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0;

				// Token: 0x04004571 RID: 17777
				private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0;

				// Token: 0x04004572 RID: 17778
				private static readonly IntPtr NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0;

				// Token: 0x04004573 RID: 17779
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002A8 RID: 680
		public sealed class MouseAxis2D : PlayerController.Axis2D
		{
			// Token: 0x06003CB8 RID: 15544 RVA: 0x00122E20 File Offset: 0x00121020
			// Note: this type is marked as 'beforefieldinit'.
			static MouseAxis2D()
			{
				Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "MouseAxis2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr);
				PlayerController.MouseAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr, 100666287);
				PlayerController.MouseAxis2D.NativeMethodInfoPtr_get_xAxis_Public_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr, 100666288);
				PlayerController.MouseAxis2D.NativeMethodInfoPtr_get_yAxis_Public_get_MouseAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr, 100666289);
			}

			// Token: 0x06003CB9 RID: 15545 RVA: 0x00122E88 File Offset: 0x00121088
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260973, RefRangeEnd = 260974, XrefRangeStart = 260951, XrefRangeEnd = 260973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseAxis2D(PlayerController parent, PlayerController.MouseAxis2D.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700128C RID: 4748
			// (get) Token: 0x06003CBA RID: 15546 RVA: 0x00122EE8 File Offset: 0x001210E8
			public new unsafe PlayerController.MouseAxis xAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260974, XrefRangeEnd = 260977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.NativeMethodInfoPtr_get_xAxis_Public_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
				}
			}

			// Token: 0x1700128D RID: 4749
			// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00122F28 File Offset: 0x00121128
			public new unsafe PlayerController.MouseAxis yAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260977, XrefRangeEnd = 260980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.NativeMethodInfoPtr_get_yAxis_Public_get_MouseAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003CBC RID: 15548 RVA: 0x000158A1 File Offset: 0x00013AA1
			public MouseAxis2D(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040032A0 RID: 12960
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x040032A1 RID: 12961
			private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_MouseAxis_0;

			// Token: 0x040032A2 RID: 12962
			private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_MouseAxis_0;

			// Token: 0x020004D6 RID: 1238
			public new class Definition : PlayerController.Axis2D.Definition
			{
				// Token: 0x060052D4 RID: 21204 RVA: 0x00177214 File Offset: 0x00175414
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.MouseAxis2D>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666290);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666291);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666292);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666293);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666294);
					PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr, 100666295);
				}

				// Token: 0x060052D5 RID: 21205 RVA: 0x001772B8 File Offset: 0x001754B8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260641, RefRangeEnd = 260643, XrefRangeStart = 260641, XrefRangeEnd = 260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseAxis2D.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001962 RID: 6498
				// (get) Token: 0x060052D6 RID: 21206 RVA: 0x001772F4 File Offset: 0x001754F4
				// (set) Token: 0x060052D7 RID: 21207 RVA: 0x00177334 File Offset: 0x00175534
				public new unsafe PlayerController.MouseAxis.Definition xAxis
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 260942, RefRangeEnd = 260944, XrefRangeStart = 260941, XrefRangeEnd = 260942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis.Definition>(intPtr3) : null;
					}
					[CallerCount(33)]
					[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001963 RID: 6499
				// (get) Token: 0x060052D8 RID: 21208 RVA: 0x00177378 File Offset: 0x00175578
				// (set) Token: 0x060052D9 RID: 21209 RVA: 0x001773B8 File Offset: 0x001755B8
				public new unsafe PlayerController.MouseAxis.Definition yAxis
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 260945, RefRangeEnd = 260947, XrefRangeStart = 260944, XrefRangeEnd = 260945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseAxis.Definition>(intPtr3) : null;
					}
					[CallerCount(38)]
					[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060052DA RID: 21210 RVA: 0x001773FC File Offset: 0x001755FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260947, XrefRangeEnd = 260951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.MouseAxis2D.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052DB RID: 21211 RVA: 0x0001DF44 File Offset: 0x0001C144
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04004574 RID: 17780
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004575 RID: 17781
				private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0;

				// Token: 0x04004576 RID: 17782
				private static readonly IntPtr NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0;

				// Token: 0x04004577 RID: 17783
				private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0;

				// Token: 0x04004578 RID: 17784
				private static readonly IntPtr NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0;

				// Token: 0x04004579 RID: 17785
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002A9 RID: 681
		public sealed class Button : PlayerController.ElementWithSource
		{
			// Token: 0x06003CBD RID: 15549 RVA: 0x00122F68 File Offset: 0x00121168
			// Note: this type is marked as 'beforefieldinit'.
			static Button()
			{
				Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "Button");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr);
				PlayerController.Button.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, 100666296);
				PlayerController.Button.NativeMethodInfoPtr_get_value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, 100666297);
				PlayerController.Button.NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, 100666298);
				PlayerController.Button.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, 100666299);
				PlayerController.Button.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, 100666300);
			}

			// Token: 0x06003CBE RID: 15550 RVA: 0x00122FF8 File Offset: 0x001211F8
			[CallerCount(0)]
			public unsafe Button(PlayerController parent, PlayerController.Button.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700128E RID: 4750
			// (get) Token: 0x06003CBF RID: 15551 RVA: 0x00123058 File Offset: 0x00121258
			public unsafe bool value
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 260986, RefRangeEnd = 260989, XrefRangeStart = 260983, XrefRangeEnd = 260986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.NativeMethodInfoPtr_get_value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700128F RID: 4751
			// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x00123094 File Offset: 0x00121294
			public unsafe bool valuePrev
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260989, XrefRangeEnd = 260999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001290 RID: 4752
			// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x001230D0 File Offset: 0x001212D0
			public unsafe bool justPressed
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 261002, RefRangeEnd = 261004, XrefRangeStart = 260999, XrefRangeEnd = 261002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001291 RID: 4753
			// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x0012310C File Offset: 0x0012130C
			public unsafe bool justReleased
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 261014, RefRangeEnd = 261016, XrefRangeStart = 261004, XrefRangeEnd = 261014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CC3 RID: 15555 RVA: 0x000158AA File Offset: 0x00013AAA
			public Button(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040032A3 RID: 12963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x040032A4 RID: 12964
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Boolean_0;

			// Token: 0x040032A5 RID: 12965
			private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Boolean_0;

			// Token: 0x040032A6 RID: 12966
			private static readonly IntPtr NativeMethodInfoPtr_get_justPressed_Public_get_Boolean_0;

			// Token: 0x040032A7 RID: 12967
			private static readonly IntPtr NativeMethodInfoPtr_get_justReleased_Public_get_Boolean_0;

			// Token: 0x020004D7 RID: 1239
			public new class Definition : PlayerController.ElementWithSource.Definition
			{
				// Token: 0x060052DC RID: 21212 RVA: 0x00177458 File Offset: 0x00175658
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.Button.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.Button>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.Button.Definition>.NativeClassPtr);
					PlayerController.Button.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button.Definition>.NativeClassPtr, 100666301);
					PlayerController.Button.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.Button.Definition>.NativeClassPtr, 100666302);
				}

				// Token: 0x060052DD RID: 21213 RVA: 0x001774AC File Offset: 0x001756AC
				[CallerCount(0)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.Button.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.Button.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052DE RID: 21214 RVA: 0x001774E8 File Offset: 0x001756E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260980, XrefRangeEnd = 260983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.Button.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052DF RID: 21215 RVA: 0x0001DF4D File Offset: 0x0001C14D
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400457A RID: 17786
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400457B RID: 17787
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002AA RID: 682
		public sealed class MouseWheel : PlayerController.Axis2D
		{
			// Token: 0x06003CC4 RID: 15556 RVA: 0x00123148 File Offset: 0x00121348
			// Note: this type is marked as 'beforefieldinit'.
			static MouseWheel()
			{
				Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "MouseWheel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr);
				PlayerController.MouseWheel.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr, 100666303);
				PlayerController.MouseWheel.NativeMethodInfoPtr_get_xAxis_Public_get_MouseWheelAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr, 100666304);
				PlayerController.MouseWheel.NativeMethodInfoPtr_get_yAxis_Public_get_MouseWheelAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr, 100666305);
			}

			// Token: 0x06003CC5 RID: 15557 RVA: 0x001231B0 File Offset: 0x001213B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261048, RefRangeEnd = 261050, XrefRangeStart = 261026, XrefRangeEnd = 261048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseWheel(PlayerController parent, PlayerController.MouseWheel.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001292 RID: 4754
			// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x00123210 File Offset: 0x00121410
			public new unsafe PlayerController.MouseWheelAxis xAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261050, XrefRangeEnd = 261053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.NativeMethodInfoPtr_get_xAxis_Public_get_MouseWheelAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheelAxis>(intPtr3) : null;
				}
			}

			// Token: 0x17001293 RID: 4755
			// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00123250 File Offset: 0x00121450
			public new unsafe PlayerController.MouseWheelAxis yAxis
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261053, XrefRangeEnd = 261056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.NativeMethodInfoPtr_get_yAxis_Public_get_MouseWheelAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheelAxis>(intPtr3) : null;
				}
			}

			// Token: 0x06003CC8 RID: 15560 RVA: 0x000158B3 File Offset: 0x00013AB3
			public MouseWheel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040032A8 RID: 12968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x040032A9 RID: 12969
			private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_MouseWheelAxis_0;

			// Token: 0x040032AA RID: 12970
			private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_MouseWheelAxis_0;

			// Token: 0x020004D8 RID: 1240
			public new class Definition : PlayerController.Axis2D.Definition
			{
				// Token: 0x060052E0 RID: 21216 RVA: 0x00177544 File Offset: 0x00175744
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.MouseWheel>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666306);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666307);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666308);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666309);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666310);
					PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr, 100666311);
				}

				// Token: 0x060052E1 RID: 21217 RVA: 0x001775E8 File Offset: 0x001757E8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260641, RefRangeEnd = 260643, XrefRangeStart = 260641, XrefRangeEnd = 260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseWheel.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001964 RID: 6500
				// (get) Token: 0x060052E2 RID: 21218 RVA: 0x00177624 File Offset: 0x00175824
				// (set) Token: 0x060052E3 RID: 21219 RVA: 0x00177664 File Offset: 0x00175864
				public new unsafe PlayerController.MouseWheelAxis.Definition xAxis
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 261017, RefRangeEnd = 261019, XrefRangeStart = 261016, XrefRangeEnd = 261017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheelAxis.Definition>(intPtr3) : null;
					}
					[CallerCount(33)]
					[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001965 RID: 6501
				// (get) Token: 0x060052E4 RID: 21220 RVA: 0x001776A8 File Offset: 0x001758A8
				// (set) Token: 0x060052E5 RID: 21221 RVA: 0x001776E8 File Offset: 0x001758E8
				public new unsafe PlayerController.MouseWheelAxis.Definition yAxis
				{
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 261020, RefRangeEnd = 261022, XrefRangeStart = 261019, XrefRangeEnd = 261020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.MouseWheelAxis.Definition>(intPtr3) : null;
					}
					[CallerCount(38)]
					[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x060052E6 RID: 21222 RVA: 0x0017772C File Offset: 0x0017592C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261022, XrefRangeEnd = 261026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.MouseWheel.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052E7 RID: 21223 RVA: 0x0001DF56 File Offset: 0x0001C156
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400457C RID: 17788
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400457D RID: 17789
				private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_Definition_0;

				// Token: 0x0400457E RID: 17790
				private static readonly IntPtr NativeMethodInfoPtr_set_xAxis_Public_set_Void_Definition_0;

				// Token: 0x0400457F RID: 17791
				private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_Definition_0;

				// Token: 0x04004580 RID: 17792
				private static readonly IntPtr NativeMethodInfoPtr_set_yAxis_Public_set_Void_Definition_0;

				// Token: 0x04004581 RID: 17793
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002AB RID: 683
		public sealed class MouseWheelAxis : PlayerController.Axis
		{
			// Token: 0x06003CC9 RID: 15561 RVA: 0x00123290 File Offset: 0x00121490
			// Note: this type is marked as 'beforefieldinit'.
			static MouseWheelAxis()
			{
				Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "MouseWheelAxis");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr);
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultRepeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "defaultRepeatRate");
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "defaultAxisCoordinateMode");
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_slwuLExHjUcxGdFdhbyiKVNqleI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "slwuLExHjUcxGdFdhbyiKVNqleI");
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_UNppbocqpRHpTngWpWethmnerik = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "UNppbocqpRHpTngWpWethmnerik");
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_gJYFNjcBhrsZRlIMqFenXHmqpqd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "gJYFNjcBhrsZRlIMqFenXHmqpqd");
				PlayerController.MouseWheelAxis.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "cmXEZIVOUSgwaTxmjyvuuJloYvz");
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666312);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666313);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666314);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666315);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666316);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666317);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_spUaYvcJpRpTkOCIhaKdUarKjca_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666318);
				PlayerController.MouseWheelAxis.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, 100666319);
			}

			// Token: 0x06003CCA RID: 15562 RVA: 0x001233D4 File Offset: 0x001215D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 261061, RefRangeEnd = 261063, XrefRangeStart = 261061, XrefRangeEnd = 261061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseWheelAxis(PlayerController parent, PlayerController.MouseWheelAxis.Definition definition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700129A RID: 4762
			// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00123434 File Offset: 0x00121634
			// (set) Token: 0x06003CCC RID: 15564 RVA: 0x00123470 File Offset: 0x00121670
			public unsafe float repeatRate
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700129B RID: 4763
			// (get) Token: 0x06003CCD RID: 15565 RVA: 0x001234B0 File Offset: 0x001216B0
			public unsafe override float value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003CCE RID: 15566 RVA: 0x001234EC File Offset: 0x001216EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261063, XrefRangeEnd = 261064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CCF RID: 15567 RVA: 0x00123520 File Offset: 0x00121720
			[CallerCount(0)]
			public unsafe override void EnabledStateChanged(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003CD0 RID: 15568 RVA: 0x00123560 File Offset: 0x00121760
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 261078, RefRangeEnd = 261079, XrefRangeStart = 261064, XrefRangeEnd = 261078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float spUaYvcJpRpTkOCIhaKdUarKjca()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_spUaYvcJpRpTkOCIhaKdUarKjca_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003CD1 RID: 15569 RVA: 0x0012359C File Offset: 0x0012179C
			[CallerCount(0)]
			public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CD2 RID: 15570 RVA: 0x000158BC File Offset: 0x00013ABC
			public MouseWheelAxis(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x001235D0 File Offset: 0x001217D0
			// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x000158C5 File Offset: 0x00013AC5
			public unsafe static float defaultRepeatRate
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultRepeatRate, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultRepeatRate, (void*)(&value));
				}
			}

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x001235EC File Offset: 0x001217EC
			// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x000158D3 File Offset: 0x00013AD3
			public new unsafe static AxisCoordinateMode defaultAxisCoordinateMode
			{
				get
				{
					AxisCoordinateMode axisCoordinateMode;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&axisCoordinateMode));
					return axisCoordinateMode;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_defaultAxisCoordinateMode, (void*)(&value));
				}
			}

			// Token: 0x17001296 RID: 4758
			// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00123608 File Offset: 0x00121808
			// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x000158E1 File Offset: 0x00013AE1
			public unsafe static float slwuLExHjUcxGdFdhbyiKVNqleI
			{
				get
				{
					float num;
					IL2CPP.il2cpp_field_static_get_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_slwuLExHjUcxGdFdhbyiKVNqleI, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_slwuLExHjUcxGdFdhbyiKVNqleI, (void*)(&value));
				}
			}

			// Token: 0x17001297 RID: 4759
			// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00123624 File Offset: 0x00121824
			// (set) Token: 0x06003CDA RID: 15578 RVA: 0x000158EF File Offset: 0x00013AEF
			public unsafe float UNppbocqpRHpTngWpWethmnerik
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_UNppbocqpRHpTngWpWethmnerik);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_UNppbocqpRHpTngWpWethmnerik)) = value;
				}
			}

			// Token: 0x17001298 RID: 4760
			// (get) Token: 0x06003CDB RID: 15579 RVA: 0x0012364C File Offset: 0x0012184C
			// (set) Token: 0x06003CDC RID: 15580 RVA: 0x0001590A File Offset: 0x00013B0A
			public unsafe double gJYFNjcBhrsZRlIMqFenXHmqpqd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_gJYFNjcBhrsZRlIMqFenXHmqpqd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_gJYFNjcBhrsZRlIMqFenXHmqpqd)) = value;
				}
			}

			// Token: 0x17001299 RID: 4761
			// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00123674 File Offset: 0x00121874
			// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00015925 File Offset: 0x00013B25
			public unsafe float cmXEZIVOUSgwaTxmjyvuuJloYvz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz)) = value;
				}
			}

			// Token: 0x040032AB RID: 12971
			private static readonly IntPtr NativeFieldInfoPtr_defaultRepeatRate;

			// Token: 0x040032AC RID: 12972
			private static readonly IntPtr NativeFieldInfoPtr_defaultAxisCoordinateMode;

			// Token: 0x040032AD RID: 12973
			private static readonly IntPtr NativeFieldInfoPtr_slwuLExHjUcxGdFdhbyiKVNqleI;

			// Token: 0x040032AE RID: 12974
			private static readonly IntPtr NativeFieldInfoPtr_UNppbocqpRHpTngWpWethmnerik;

			// Token: 0x040032AF RID: 12975
			private static readonly IntPtr NativeFieldInfoPtr_gJYFNjcBhrsZRlIMqFenXHmqpqd;

			// Token: 0x040032B0 RID: 12976
			private static readonly IntPtr NativeFieldInfoPtr_cmXEZIVOUSgwaTxmjyvuuJloYvz;

			// Token: 0x040032B1 RID: 12977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerController_Definition_0;

			// Token: 0x040032B2 RID: 12978
			private static readonly IntPtr NativeMethodInfoPtr_get_repeatRate_Public_get_Single_0;

			// Token: 0x040032B3 RID: 12979
			private static readonly IntPtr NativeMethodInfoPtr_set_repeatRate_Public_set_Void_Single_0;

			// Token: 0x040032B4 RID: 12980
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Single_0;

			// Token: 0x040032B5 RID: 12981
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Internal_Virtual_Void_0;

			// Token: 0x040032B6 RID: 12982
			private static readonly IntPtr NativeMethodInfoPtr_EnabledStateChanged_Protected_Virtual_Void_Boolean_0;

			// Token: 0x040032B7 RID: 12983
			private static readonly IntPtr NativeMethodInfoPtr_spUaYvcJpRpTkOCIhaKdUarKjca_Private_Single_0;

			// Token: 0x040032B8 RID: 12984
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Private_Void_0;

			// Token: 0x020004D9 RID: 1241
			public new class Definition : PlayerController.Axis.Definition
			{
				// Token: 0x060052E8 RID: 21224 RVA: 0x00177788 File Offset: 0x00175988
				// Note: this type is marked as 'beforefieldinit'.
				static Definition()
				{
					Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerController.MouseWheelAxis>.NativeClassPtr, "Definition");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr);
					PlayerController.MouseWheelAxis.Definition.NativeFieldInfoPtr_repeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr, "repeatRate");
					PlayerController.MouseWheelAxis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr, 100666320);
					PlayerController.MouseWheelAxis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr, 100666321);
				}

				// Token: 0x060052E9 RID: 21225 RVA: 0x001777F0 File Offset: 0x001759F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261056, XrefRangeEnd = 261057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Definition()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController.MouseWheelAxis.Definition>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.MouseWheelAxis.Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060052EA RID: 21226 RVA: 0x0017782C File Offset: 0x00175A2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261057, XrefRangeEnd = 261061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override PlayerController.Element FTFHtpJqMdYtsjaKaBFuRsIUnug(PlayerController A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerController.MouseWheelAxis.Definition.NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerController.Element>(intPtr3) : null;
					}
				}

				// Token: 0x060052EB RID: 21227 RVA: 0x0001DF5F File Offset: 0x0001C15F
				public Definition(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001966 RID: 6502
				// (get) Token: 0x060052EC RID: 21228 RVA: 0x00177888 File Offset: 0x00175A88
				// (set) Token: 0x060052ED RID: 21229 RVA: 0x0001DF68 File Offset: 0x0001C168
				public unsafe float repeatRate
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.Definition.NativeFieldInfoPtr_repeatRate);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.MouseWheelAxis.Definition.NativeFieldInfoPtr_repeatRate)) = value;
					}
				}

				// Token: 0x04004582 RID: 17794
				private static readonly IntPtr NativeFieldInfoPtr_repeatRate;

				// Token: 0x04004583 RID: 17795
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004584 RID: 17796
				private static readonly IntPtr NativeMethodInfoPtr_FTFHtpJqMdYtsjaKaBFuRsIUnug_Internal_Virtual_Element_PlayerController_0;
			}
		}

		// Token: 0x020002AC RID: 684
		private sealed class MethodInfoStoreGeneric_GetElement_Public_Virtual_Final_New_T_Int32_0<T>
		{
			// Token: 0x040032B9 RID: 12985
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayerController.NativeMethodInfoPtr_GetElement_Public_Virtual_Final_New_T_Int32_0, Il2CppClassPointerStore<PlayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020002AD RID: 685
		private sealed class MethodInfoStoreGeneric_DqDqXlkoRPQMtBOZPgBoRoCwpGa_Internal_Static_Int32_IList_1_T_Predicate_1_T_Int32_0<T>
		{
			// Token: 0x040032BA RID: 12986
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayerController.NativeMethodInfoPtr_DqDqXlkoRPQMtBOZPgBoRoCwpGa_Internal_Static_Int32_IList_1_T_Predicate_1_T_Int32_0, Il2CppClassPointerStore<PlayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<global::Il2CppSystem.Type>(new global::Il2CppSystem.Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
