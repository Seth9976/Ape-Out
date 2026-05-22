using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired
{
	// Token: 0x02000140 RID: 320
	public sealed class ControllerMapEnabler : Object
	{
		// Token: 0x06002322 RID: 8994 RVA: 0x000B31AC File Offset: 0x000B13AC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapEnabler()
		{
			Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerMapEnabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr);
			ControllerMapEnabler.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			ControllerMapEnabler.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "LJLpeqIMXIWQRJmTMPOerYeeqPn");
			ControllerMapEnabler.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "XdWOzpsdmQUGmfcwmkQXSOiMQvy");
			ControllerMapEnabler.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			ControllerMapEnabler.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "OWNfHRylfIrUKTpRxpcGanoVhaZ");
			ControllerMapEnabler.NativeMethodInfoPtr__ctor_Internal_Void_Player_aFwGZiuGrUEoBNtlswFPEqaRBwB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670801);
			ControllerMapEnabler.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670802);
			ControllerMapEnabler.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670803);
			ControllerMapEnabler.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670804);
			ControllerMapEnabler.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670805);
			ControllerMapEnabler.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670806);
			ControllerMapEnabler.NativeMethodInfoPtr_LoadDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670807);
			ControllerMapEnabler.NativeMethodInfoPtr_ToXmlString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670808);
			ControllerMapEnabler.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670809);
			ControllerMapEnabler.NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670810);
			ControllerMapEnabler.NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670811);
			ControllerMapEnabler.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670812);
			ControllerMapEnabler.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670813);
			ControllerMapEnabler.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, 100670814);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000B3358 File Offset: 0x000B1558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288733, XrefRangeEnd = 288737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler(Player player, ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB startingSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startingSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr__ctor_Internal_Void_Player_aFwGZiuGrUEoBNtlswFPEqaRBwB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000B33B8 File Offset: 0x000B15B8
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x000B33F4 File Offset: 0x000B15F4
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288737, XrefRangeEnd = 288738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000B3434 File Offset: 0x000B1634
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x000B3474 File Offset: 0x000B1674
		public unsafe List<ControllerMapEnabler.RuleSet> ruleSets
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler.RuleSet>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288738, XrefRangeEnd = 288744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x000B34B8 File Offset: 0x000B16B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 288771, RefRangeEnd = 288776, XrefRangeStart = 288744, XrefRangeEnd = 288771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x000B34EC File Offset: 0x000B16EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288806, RefRangeEnd = 288808, XrefRangeStart = 288776, XrefRangeEnd = 288806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_LoadDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x000B3520 File Offset: 0x000B1720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288808, XrefRangeEnd = 288822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_ToXmlString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x000B3558 File Offset: 0x000B1758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288822, XrefRangeEnd = 288836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x000B3590 File Offset: 0x000B1790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288836, XrefRangeEnd = 288853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportXml(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000B35E0 File Offset: 0x000B17E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288853, XrefRangeEnd = 288870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportJson(string jsonString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000B3630 File Offset: 0x000B1830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288876, RefRangeEnd = 288878, XrefRangeStart = 288870, XrefRangeEnd = 288876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject TUpbRFbZCQXGnqKfXoSpZTimZpRE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000B3670 File Offset: 0x000B1870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288957, RefRangeEnd = 288958, XrefRangeStart = 288878, XrefRangeEnd = 288957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oNyGkjXkFDvVnHlPrDgpKRwoJAQ(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000B36B4 File Offset: 0x000B18B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288972, RefRangeEnd = 288974, XrefRangeStart = 288958, XrefRangeEnd = 288972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0000E266 File Offset: 0x0000C466
		public ControllerMapEnabler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000B3704 File Offset: 0x000B1904
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000E26F File Offset: 0x0000C46F
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000B372C File Offset: 0x000B192C
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000E28A File Offset: 0x0000C48A
		public unsafe Player LJLpeqIMXIWQRJmTMPOerYeeqPn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000B375C File Offset: 0x000B195C
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000E2A9 File Offset: 0x0000C4A9
		public unsafe ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB XdWOzpsdmQUGmfcwmkQXSOiMQvy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000B378C File Offset: 0x000B198C
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000B37B4 File Offset: 0x000B19B4
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		public unsafe List<ControllerMapEnabler.RuleSet> OWNfHRylfIrUKTpRxpcGanoVhaZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler.RuleSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Player_aFwGZiuGrUEoBNtlswFPEqaRBwB_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaults_Public_Void_0;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0;

		// Token: 0x0200035E RID: 862
		[Serializable]
		public sealed class Rule : Object
		{
			// Token: 0x0600475D RID: 18269 RVA: 0x0014A78C File Offset: 0x0014898C
			// Note: this type is marked as 'beforefieldinit'.
			static Rule()
			{
				Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "Rule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr);
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_tag");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_enable");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__categoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_categoryIds");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__layoutIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_layoutIds");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__controllerSetSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_controllerSetSelector");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitCategoryNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_preInitCategoryNames");
				ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitLayoutNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, "_preInitLayoutNames");
				ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670815);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Public_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670816);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670817);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_appliesToAllLayouts_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670818);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670819);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670820);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_enable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670821);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670822);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670823);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670824);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670825);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670826);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670827);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670828);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670829);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670830);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670831);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670832);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670833);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670834);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670835);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670836);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670837);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670838);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670839);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670840);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670841);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_Matches_Internal_Boolean_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670842);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670843);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_CheckNoControllerTypeError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670844);
				ControllerMapEnabler.Rule.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr, 100670845);
			}

			// Token: 0x0600475E RID: 18270 RVA: 0x0014AAB0 File Offset: 0x00148CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288236, XrefRangeEnd = 288242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rule()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600475F RID: 18271 RVA: 0x0014AAEC File Offset: 0x00148CEC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288256, RefRangeEnd = 288257, XrefRangeStart = 288242, XrefRangeEnd = 288256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rule(ControllerMapEnabler.Rule source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Public_Void_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004760 RID: 18272 RVA: 0x0014AB38 File Offset: 0x00148D38
			[CallerCount(0)]
			public unsafe Rule(string tag, bool enabled, Il2CppStructArray<int> categoryIds, Il2CppStructArray<int> layoutIds, ControllerSetSelector controllerSetSelector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.Rule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categoryIds);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layoutIds);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerSetSelector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700163E RID: 5694
			// (get) Token: 0x06004761 RID: 18273 RVA: 0x0014ABCC File Offset: 0x00148DCC
			public unsafe bool appliesToAllLayouts
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_appliesToAllLayouts_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700163F RID: 5695
			// (get) Token: 0x06004762 RID: 18274 RVA: 0x0014AC08 File Offset: 0x00148E08
			// (set) Token: 0x06004763 RID: 18275 RVA: 0x0014AC40 File Offset: 0x00148E40
			public unsafe string tag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001640 RID: 5696
			// (get) Token: 0x06004764 RID: 18276 RVA: 0x0014AC84 File Offset: 0x00148E84
			// (set) Token: 0x06004765 RID: 18277 RVA: 0x0014ACC0 File Offset: 0x00148EC0
			public unsafe bool enable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_enable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001641 RID: 5697
			// (get) Token: 0x06004766 RID: 18278 RVA: 0x0014AD00 File Offset: 0x00148F00
			// (set) Token: 0x06004767 RID: 18279 RVA: 0x0014AD40 File Offset: 0x00148F40
			public unsafe ControllerSetSelector controllerSetSelector
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 288260, RefRangeEnd = 288269, XrefRangeStart = 288257, XrefRangeEnd = 288260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288269, XrefRangeEnd = 288272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001642 RID: 5698
			// (get) Token: 0x06004768 RID: 18280 RVA: 0x0014AD84 File Offset: 0x00148F84
			// (set) Token: 0x06004769 RID: 18281 RVA: 0x0014ADC4 File Offset: 0x00148FC4
			public unsafe Il2CppStructArray<int> categoryIds
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 288275, RefRangeEnd = 288277, XrefRangeStart = 288272, XrefRangeEnd = 288275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288277, XrefRangeEnd = 288279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001643 RID: 5699
			// (get) Token: 0x0600476A RID: 18282 RVA: 0x0014AE08 File Offset: 0x00149008
			// (set) Token: 0x0600476B RID: 18283 RVA: 0x0014AE48 File Offset: 0x00149048
			public unsafe Il2CppStructArray<int> layoutIds
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 288282, RefRangeEnd = 288284, XrefRangeStart = 288279, XrefRangeEnd = 288282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288284, XrefRangeEnd = 288287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001644 RID: 5700
			// (get) Token: 0x0600476C RID: 18284 RVA: 0x0014AE8C File Offset: 0x0014908C
			// (set) Token: 0x0600476D RID: 18285 RVA: 0x0014AEC8 File Offset: 0x001490C8
			public unsafe int categoryId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288287, XrefRangeEnd = 288289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288289, XrefRangeEnd = 288296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001645 RID: 5701
			// (get) Token: 0x0600476E RID: 18286 RVA: 0x0014AF08 File Offset: 0x00149108
			// (set) Token: 0x0600476F RID: 18287 RVA: 0x0014AF44 File Offset: 0x00149144
			public unsafe int layoutId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288296, XrefRangeEnd = 288298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288298, XrefRangeEnd = 288306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001646 RID: 5702
			// (get) Token: 0x06004770 RID: 18288 RVA: 0x0014AF84 File Offset: 0x00149184
			// (set) Token: 0x06004771 RID: 18289 RVA: 0x0014AFC4 File Offset: 0x001491C4
			public unsafe Il2CppStringArray categoryNames
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288306, XrefRangeEnd = 288325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288325, XrefRangeEnd = 288353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001647 RID: 5703
			// (get) Token: 0x06004772 RID: 18290 RVA: 0x0014B008 File Offset: 0x00149208
			// (set) Token: 0x06004773 RID: 18291 RVA: 0x0014B048 File Offset: 0x00149248
			public unsafe Il2CppStringArray layoutNames
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288353, XrefRangeEnd = 288373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288373, XrefRangeEnd = 288403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutNames_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001648 RID: 5704
			// (get) Token: 0x06004774 RID: 18292 RVA: 0x0014B08C File Offset: 0x0014928C
			// (set) Token: 0x06004775 RID: 18293 RVA: 0x0014B0C4 File Offset: 0x001492C4
			public unsafe string categoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288403, XrefRangeEnd = 288413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_categoryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288413, XrefRangeEnd = 288429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001649 RID: 5705
			// (get) Token: 0x06004776 RID: 18294 RVA: 0x0014B108 File Offset: 0x00149308
			// (set) Token: 0x06004777 RID: 18295 RVA: 0x0014B140 File Offset: 0x00149340
			public unsafe string layoutName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288429, XrefRangeEnd = 288440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_layoutName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288440, XrefRangeEnd = 288458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700164A RID: 5706
			// (get) Token: 0x06004778 RID: 18296 RVA: 0x0014B184 File Offset: 0x00149384
			public unsafe bool isValid
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 288475, RefRangeEnd = 288476, XrefRangeStart = 288458, XrefRangeEnd = 288475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004779 RID: 18297 RVA: 0x0014B1C0 File Offset: 0x001493C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288484, RefRangeEnd = 288485, XrefRangeStart = 288476, XrefRangeEnd = 288484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Matches(ControllerMap map)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_Matches_Internal_Boolean_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600477A RID: 18298 RVA: 0x0014B210 File Offset: 0x00149410
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 288536, RefRangeEnd = 288545, XrefRangeStart = 288485, XrefRangeEnd = 288536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600477B RID: 18299 RVA: 0x0014B244 File Offset: 0x00149444
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 288578, RefRangeEnd = 288583, XrefRangeStart = 288545, XrefRangeEnd = 288578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckNoControllerTypeError()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_CheckNoControllerTypeError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600477C RID: 18300 RVA: 0x0014B278 File Offset: 0x00149478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288583, XrefRangeEnd = 288587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.Rule.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x0600477D RID: 18301 RVA: 0x00019DCD File Offset: 0x00017FCD
			public Rule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001637 RID: 5687
			// (get) Token: 0x0600477E RID: 18302 RVA: 0x0014B2B8 File Offset: 0x001494B8
			// (set) Token: 0x0600477F RID: 18303 RVA: 0x00019DD6 File Offset: 0x00017FD6
			public unsafe string _tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__tag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001638 RID: 5688
			// (get) Token: 0x06004780 RID: 18304 RVA: 0x0014B2E0 File Offset: 0x001494E0
			// (set) Token: 0x06004781 RID: 18305 RVA: 0x00019DF5 File Offset: 0x00017FF5
			public unsafe bool _enable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__enable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__enable)) = value;
				}
			}

			// Token: 0x17001639 RID: 5689
			// (get) Token: 0x06004782 RID: 18306 RVA: 0x0014B308 File Offset: 0x00149508
			// (set) Token: 0x06004783 RID: 18307 RVA: 0x00019E10 File Offset: 0x00018010
			public unsafe Il2CppStructArray<int> _categoryIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__categoryIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__categoryIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163A RID: 5690
			// (get) Token: 0x06004784 RID: 18308 RVA: 0x0014B338 File Offset: 0x00149538
			// (set) Token: 0x06004785 RID: 18309 RVA: 0x00019E2F File Offset: 0x0001802F
			public unsafe Il2CppStructArray<int> _layoutIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__layoutIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__layoutIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163B RID: 5691
			// (get) Token: 0x06004786 RID: 18310 RVA: 0x0014B368 File Offset: 0x00149568
			// (set) Token: 0x06004787 RID: 18311 RVA: 0x00019E4E File Offset: 0x0001804E
			public unsafe ControllerSetSelector _controllerSetSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__controllerSetSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__controllerSetSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163C RID: 5692
			// (get) Token: 0x06004788 RID: 18312 RVA: 0x0014B398 File Offset: 0x00149598
			// (set) Token: 0x06004789 RID: 18313 RVA: 0x00019E6D File Offset: 0x0001806D
			public unsafe Il2CppStringArray _preInitCategoryNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitCategoryNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitCategoryNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163D RID: 5693
			// (get) Token: 0x0600478A RID: 18314 RVA: 0x0014B3C8 File Offset: 0x001495C8
			// (set) Token: 0x0600478B RID: 18315 RVA: 0x00019E8C File Offset: 0x0001808C
			public unsafe Il2CppStringArray _preInitLayoutNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitLayoutNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.Rule.NativeFieldInfoPtr__preInitLayoutNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A26 RID: 14886
			private static readonly IntPtr NativeFieldInfoPtr__tag;

			// Token: 0x04003A27 RID: 14887
			private static readonly IntPtr NativeFieldInfoPtr__enable;

			// Token: 0x04003A28 RID: 14888
			private static readonly IntPtr NativeFieldInfoPtr__categoryIds;

			// Token: 0x04003A29 RID: 14889
			private static readonly IntPtr NativeFieldInfoPtr__layoutIds;

			// Token: 0x04003A2A RID: 14890
			private static readonly IntPtr NativeFieldInfoPtr__controllerSetSelector;

			// Token: 0x04003A2B RID: 14891
			private static readonly IntPtr NativeFieldInfoPtr__preInitCategoryNames;

			// Token: 0x04003A2C RID: 14892
			private static readonly IntPtr NativeFieldInfoPtr__preInitLayoutNames;

			// Token: 0x04003A2D RID: 14893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A2E RID: 14894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rule_0;

			// Token: 0x04003A2F RID: 14895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_ControllerSetSelector_0;

			// Token: 0x04003A30 RID: 14896
			private static readonly IntPtr NativeMethodInfoPtr_get_appliesToAllLayouts_Internal_get_Boolean_0;

			// Token: 0x04003A31 RID: 14897
			private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

			// Token: 0x04003A32 RID: 14898
			private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

			// Token: 0x04003A33 RID: 14899
			private static readonly IntPtr NativeMethodInfoPtr_get_enable_Public_get_Boolean_0;

			// Token: 0x04003A34 RID: 14900
			private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0;

			// Token: 0x04003A35 RID: 14901
			private static readonly IntPtr NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0;

			// Token: 0x04003A36 RID: 14902
			private static readonly IntPtr NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0;

			// Token: 0x04003A37 RID: 14903
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A38 RID: 14904
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A39 RID: 14905
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutIds_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A3A RID: 14906
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A3B RID: 14907
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

			// Token: 0x04003A3C RID: 14908
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0;

			// Token: 0x04003A3D RID: 14909
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

			// Token: 0x04003A3E RID: 14910
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0;

			// Token: 0x04003A3F RID: 14911
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0;

			// Token: 0x04003A40 RID: 14912
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0;

			// Token: 0x04003A41 RID: 14913
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutNames_Public_get_Il2CppStringArray_0;

			// Token: 0x04003A42 RID: 14914
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutNames_Public_set_Void_Il2CppStringArray_0;

			// Token: 0x04003A43 RID: 14915
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryName_Public_get_String_0;

			// Token: 0x04003A44 RID: 14916
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0;

			// Token: 0x04003A45 RID: 14917
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutName_Public_get_String_0;

			// Token: 0x04003A46 RID: 14918
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0;

			// Token: 0x04003A47 RID: 14919
			private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0;

			// Token: 0x04003A48 RID: 14920
			private static readonly IntPtr NativeMethodInfoPtr_Matches_Internal_Boolean_ControllerMap_0;

			// Token: 0x04003A49 RID: 14921
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

			// Token: 0x04003A4A RID: 14922
			private static readonly IntPtr NativeMethodInfoPtr_CheckNoControllerTypeError_Private_Void_0;

			// Token: 0x04003A4B RID: 14923
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x0200035F RID: 863
		[Serializable]
		public sealed class RuleSet : Object
		{
			// Token: 0x0600478C RID: 18316 RVA: 0x0014B3F8 File Offset: 0x001495F8
			// Note: this type is marked as 'beforefieldinit'.
			static RuleSet()
			{
				Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "RuleSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr);
				ControllerMapEnabler.RuleSet.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, "className");
				ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, "_enabled");
				ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, "_tag");
				ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, "_rules");
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670846);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670847);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670848);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670849);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670850);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670851);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670852);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670853);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670854);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670855);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670856);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670857);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670858);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670859);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670860);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670861);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670862);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670863);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670864);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670865);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670866);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670867);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670868);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapEnabler_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670869);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670870);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670871);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670872);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670873);
				ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_CheckList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr, 100670874);
			}

			// Token: 0x1700164F RID: 5711
			// (get) Token: 0x0600478D RID: 18317 RVA: 0x0014B6B8 File Offset: 0x001498B8
			// (set) Token: 0x0600478E RID: 18318 RVA: 0x0014B6F4 File Offset: 0x001498F4
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001650 RID: 5712
			// (get) Token: 0x0600478F RID: 18319 RVA: 0x0014B734 File Offset: 0x00149934
			// (set) Token: 0x06004790 RID: 18320 RVA: 0x0014B76C File Offset: 0x0014996C
			public unsafe string tag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001651 RID: 5713
			// (get) Token: 0x06004791 RID: 18321 RVA: 0x0014B7B0 File Offset: 0x001499B0
			// (set) Token: 0x06004792 RID: 18322 RVA: 0x0014B7F0 File Offset: 0x001499F0
			public unsafe List<ControllerMapEnabler.Rule> rules
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler.Rule>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288587, XrefRangeEnd = 288588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004793 RID: 18323 RVA: 0x0014B834 File Offset: 0x00149A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288588, XrefRangeEnd = 288595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet(bool enabled, string tag, List<ControllerMapEnabler.Rule> rules)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004794 RID: 18324 RVA: 0x0014B8A0 File Offset: 0x00149AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288595, XrefRangeEnd = 288601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004795 RID: 18325 RVA: 0x0014B8DC File Offset: 0x00149ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288601, XrefRangeEnd = 288614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet(ControllerMapEnabler.RuleSet source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.RuleSet>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004796 RID: 18326 RVA: 0x0014B928 File Offset: 0x00149B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288614, XrefRangeEnd = 288621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapEnabler.Rule Find(Predicate<ControllerMapEnabler.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.Rule>(intPtr3) : null;
				}
			}

			// Token: 0x06004797 RID: 18327 RVA: 0x0014B978 File Offset: 0x00149B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288621, XrefRangeEnd = 288627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapEnabler.Rule FindLast(Predicate<ControllerMapEnabler.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.Rule>(intPtr3) : null;
				}
			}

			// Token: 0x06004798 RID: 18328 RVA: 0x0014B9C8 File Offset: 0x00149BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288627, XrefRangeEnd = 288634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindIndex(Predicate<ControllerMapEnabler.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004799 RID: 18329 RVA: 0x0014BA18 File Offset: 0x00149C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288634, XrefRangeEnd = 288640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindLastIndex(Predicate<ControllerMapEnabler.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600479A RID: 18330 RVA: 0x0014BA68 File Offset: 0x00149C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288640, XrefRangeEnd = 288642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOf(ControllerMapEnabler.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600479B RID: 18331 RVA: 0x0014BAB8 File Offset: 0x00149CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288642, XrefRangeEnd = 288647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Insert(int index, ControllerMapEnabler.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600479C RID: 18332 RVA: 0x0014BB08 File Offset: 0x00149D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288647, XrefRangeEnd = 288652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001652 RID: 5714
			public unsafe ControllerMapEnabler.Rule this[int index]
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 288654, RefRangeEnd = 288656, XrefRangeStart = 288652, XrefRangeEnd = 288654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.Rule>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288656, XrefRangeEnd = 288659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600479F RID: 18335 RVA: 0x0014BBE4 File Offset: 0x00149DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288659, XrefRangeEnd = 288664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(ControllerMapEnabler.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047A0 RID: 18336 RVA: 0x0014BC28 File Offset: 0x00149E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288664, XrefRangeEnd = 288667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047A1 RID: 18337 RVA: 0x0014BC5C File Offset: 0x00149E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288667, XrefRangeEnd = 288672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Contains(ControllerMapEnabler.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047A2 RID: 18338 RVA: 0x0014BCAC File Offset: 0x00149EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288672, XrefRangeEnd = 288675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppReferenceArray<ControllerMapEnabler.Rule> array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001653 RID: 5715
			// (get) Token: 0x060047A3 RID: 18339 RVA: 0x0014BCFC File Offset: 0x00149EFC
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 288677, RefRangeEnd = 288678, XrefRangeStart = 288675, XrefRangeEnd = 288677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001654 RID: 5716
			// (get) Token: 0x060047A4 RID: 18340 RVA: 0x0014BD38 File Offset: 0x00149F38
			public unsafe bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288678, XrefRangeEnd = 288683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapEnabler_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047A5 RID: 18341 RVA: 0x0014BD74 File Offset: 0x00149F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288683, XrefRangeEnd = 288686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Remove(ControllerMapEnabler.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047A6 RID: 18342 RVA: 0x0014BDC4 File Offset: 0x00149FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288686, XrefRangeEnd = 288691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerMapEnabler.Rule> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerMapEnabler.Rule>>(intPtr3) : null;
			}

			// Token: 0x060047A7 RID: 18343 RVA: 0x0014BE04 File Offset: 0x0014A004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288691, XrefRangeEnd = 288696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060047A8 RID: 18344 RVA: 0x0014BE44 File Offset: 0x0014A044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288696, XrefRangeEnd = 288706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060047A9 RID: 18345 RVA: 0x0014BE84 File Offset: 0x0014A084
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 288712, RefRangeEnd = 288733, XrefRangeStart = 288706, XrefRangeEnd = 288712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.RuleSet.NativeMethodInfoPtr_CheckList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047AA RID: 18346 RVA: 0x00019EAB File Offset: 0x000180AB
			public RuleSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700164B RID: 5707
			// (get) Token: 0x060047AB RID: 18347 RVA: 0x0014BEB8 File Offset: 0x0014A0B8
			// (set) Token: 0x060047AC RID: 18348 RVA: 0x00019EB4 File Offset: 0x000180B4
			public unsafe static string className
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr_className, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr_className, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700164C RID: 5708
			// (get) Token: 0x060047AD RID: 18349 RVA: 0x0014BED8 File Offset: 0x0014A0D8
			// (set) Token: 0x060047AE RID: 18350 RVA: 0x00019EC6 File Offset: 0x000180C6
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x1700164D RID: 5709
			// (get) Token: 0x060047AF RID: 18351 RVA: 0x0014BF00 File Offset: 0x0014A100
			// (set) Token: 0x060047B0 RID: 18352 RVA: 0x00019EE1 File Offset: 0x000180E1
			public unsafe string _tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__tag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700164E RID: 5710
			// (get) Token: 0x060047B1 RID: 18353 RVA: 0x0014BF28 File Offset: 0x0014A128
			// (set) Token: 0x060047B2 RID: 18354 RVA: 0x00019F00 File Offset: 0x00018100
			public unsafe List<ControllerMapEnabler.Rule> _rules
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__rules);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapEnabler.Rule>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.RuleSet.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A4C RID: 14924
			private static readonly IntPtr NativeFieldInfoPtr_className;

			// Token: 0x04003A4D RID: 14925
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x04003A4E RID: 14926
			private static readonly IntPtr NativeFieldInfoPtr__tag;

			// Token: 0x04003A4F RID: 14927
			private static readonly IntPtr NativeFieldInfoPtr__rules;

			// Token: 0x04003A50 RID: 14928
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003A51 RID: 14929
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04003A52 RID: 14930
			private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

			// Token: 0x04003A53 RID: 14931
			private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

			// Token: 0x04003A54 RID: 14932
			private static readonly IntPtr NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0;

			// Token: 0x04003A55 RID: 14933
			private static readonly IntPtr NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0;

			// Token: 0x04003A56 RID: 14934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0;

			// Token: 0x04003A57 RID: 14935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A58 RID: 14936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0;

			// Token: 0x04003A59 RID: 14937
			private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0;

			// Token: 0x04003A5A RID: 14938
			private static readonly IntPtr NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0;

			// Token: 0x04003A5B RID: 14939
			private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0;

			// Token: 0x04003A5C RID: 14940
			private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0;

			// Token: 0x04003A5D RID: 14941
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0;

			// Token: 0x04003A5E RID: 14942
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0;

			// Token: 0x04003A5F RID: 14943
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04003A60 RID: 14944
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0;

			// Token: 0x04003A61 RID: 14945
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0;

			// Token: 0x04003A62 RID: 14946
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0;

			// Token: 0x04003A63 RID: 14947
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003A64 RID: 14948
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0;

			// Token: 0x04003A65 RID: 14949
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0;

			// Token: 0x04003A66 RID: 14950
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003A67 RID: 14951
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapEnabler_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04003A68 RID: 14952
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0;

			// Token: 0x04003A69 RID: 14953
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0;

			// Token: 0x04003A6A RID: 14954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003A6B RID: 14955
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;

			// Token: 0x04003A6C RID: 14956
			private static readonly IntPtr NativeMethodInfoPtr_CheckList_Private_Void_0;
		}

		// Token: 0x02000360 RID: 864
		public class aFwGZiuGrUEoBNtlswFPEqaRBwB : Object
		{
			// Token: 0x060047B3 RID: 18355 RVA: 0x0014BF58 File Offset: 0x0014A158
			// Note: this type is marked as 'beforefieldinit'.
			static aFwGZiuGrUEoBNtlswFPEqaRBwB()
			{
				Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapEnabler>.NativeClassPtr, "aFwGZiuGrUEoBNtlswFPEqaRBwB");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr);
				ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr, "yBWkcJugFdvDjCdGYaZAHUEYmYX");
				ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr, "sgICyBnveYENQlXQnsfPeXuGgEm");
				ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr, 100670875);
			}

			// Token: 0x060047B4 RID: 18356 RVA: 0x0014BFC0 File Offset: 0x0014A1C0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 126351, RefRangeEnd = 126356, XrefRangeStart = 126351, XrefRangeEnd = 126356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe aFwGZiuGrUEoBNtlswFPEqaRBwB(bool enabled, Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> startingRuleSets)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startingRuleSets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047B5 RID: 18357 RVA: 0x00019F1F File Offset: 0x0001811F
			public aFwGZiuGrUEoBNtlswFPEqaRBwB(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001655 RID: 5717
			// (get) Token: 0x060047B6 RID: 18358 RVA: 0x0014C01C File Offset: 0x0014A21C
			// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00019F28 File Offset: 0x00018128
			public unsafe bool yBWkcJugFdvDjCdGYaZAHUEYmYX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX)) = value;
				}
			}

			// Token: 0x17001656 RID: 5718
			// (get) Token: 0x060047B8 RID: 18360 RVA: 0x0014C044 File Offset: 0x0014A244
			// (set) Token: 0x060047B9 RID: 18361 RVA: 0x00019F43 File Offset: 0x00018143
			public unsafe Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> sgICyBnveYENQlXQnsfPeXuGgEm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A6D RID: 14957
			private static readonly IntPtr NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX;

			// Token: 0x04003A6E RID: 14958
			private static readonly IntPtr NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm;

			// Token: 0x04003A6F RID: 14959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0;
		}
	}
}
