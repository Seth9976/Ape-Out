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
	// Token: 0x02000143 RID: 323
	public sealed class ControllerMapLayoutManager : Object
	{
		// Token: 0x0600236C RID: 9068 RVA: 0x000B4314 File Offset: 0x000B2514
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapLayoutManager()
		{
			Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerMapLayoutManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr);
			ControllerMapLayoutManager.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
			ControllerMapLayoutManager.NativeFieldInfoPtr_cDEZcYoTFtYfbBIAIjPYesqoaHw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "cDEZcYoTFtYfbBIAIjPYesqoaHw");
			ControllerMapLayoutManager.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "LJLpeqIMXIWQRJmTMPOerYeeqPn");
			ControllerMapLayoutManager.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "XdWOzpsdmQUGmfcwmkQXSOiMQvy");
			ControllerMapLayoutManager.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "SBmxkshsppDFZPZvftqYxbMuemu");
			ControllerMapLayoutManager.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "OWNfHRylfIrUKTpRxpcGanoVhaZ");
			ControllerMapLayoutManager.NativeFieldInfoPtr_ECquLjjyxWLqzMJEovptwOiZVrO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "ECquLjjyxWLqzMJEovptwOiZVrO");
			ControllerMapLayoutManager.NativeMethodInfoPtr_add_ApplyCalledEvent_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670902);
			ControllerMapLayoutManager.NativeMethodInfoPtr_remove_ApplyCalledEvent_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670903);
			ControllerMapLayoutManager.NativeMethodInfoPtr__ctor_Internal_Void_Player_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670904);
			ControllerMapLayoutManager.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670905);
			ControllerMapLayoutManager.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670906);
			ControllerMapLayoutManager.NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670907);
			ControllerMapLayoutManager.NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670908);
			ControllerMapLayoutManager.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670909);
			ControllerMapLayoutManager.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670910);
			ControllerMapLayoutManager.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670911);
			ControllerMapLayoutManager.NativeMethodInfoPtr_LoadDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670912);
			ControllerMapLayoutManager.NativeMethodInfoPtr_ToXmlString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670913);
			ControllerMapLayoutManager.NativeMethodInfoPtr_ToJsonString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670914);
			ControllerMapLayoutManager.NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670915);
			ControllerMapLayoutManager.NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670916);
			ControllerMapLayoutManager.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670917);
			ControllerMapLayoutManager.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670918);
			ControllerMapLayoutManager.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, 100670919);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000B4538 File Offset: 0x000B2738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289453, XrefRangeEnd = 289456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ApplyCalledEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_add_ApplyCalledEvent_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x000B457C File Offset: 0x000B277C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289456, XrefRangeEnd = 289459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ApplyCalledEvent(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_remove_ApplyCalledEvent_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x000B45C0 File Offset: 0x000B27C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289463, RefRangeEnd = 289464, XrefRangeStart = 289459, XrefRangeEnd = 289463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapLayoutManager(Player player, ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd startingSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startingSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr__ctor_Internal_Void_Player_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000B4620 File Offset: 0x000B2820
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x000B465C File Offset: 0x000B285C
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289464, XrefRangeEnd = 289465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000B469C File Offset: 0x000B289C
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x000B46D8 File Offset: 0x000B28D8
		public unsafe bool loadFromUserDataStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000B4718 File Offset: 0x000B2918
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x000B4758 File Offset: 0x000B2958
		public unsafe List<ControllerMapLayoutManager.RuleSet> ruleSets
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager.RuleSet>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289465, XrefRangeEnd = 289471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000B479C File Offset: 0x000B299C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 289595, RefRangeEnd = 289606, XrefRangeStart = 289471, XrefRangeEnd = 289595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000B47D0 File Offset: 0x000B29D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289636, RefRangeEnd = 289638, XrefRangeStart = 289606, XrefRangeEnd = 289636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_LoadDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000B4804 File Offset: 0x000B2A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289638, XrefRangeEnd = 289652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXmlString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_ToXmlString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x000B483C File Offset: 0x000B2A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289652, XrefRangeEnd = 289666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToJsonString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_ToJsonString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000B4874 File Offset: 0x000B2A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289666, XrefRangeEnd = 289683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportXml(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x000B48C4 File Offset: 0x000B2AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289683, XrefRangeEnd = 289700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ImportJson(string jsonString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000B4914 File Offset: 0x000B2B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289706, RefRangeEnd = 289708, XrefRangeStart = 289700, XrefRangeEnd = 289706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedObject TUpbRFbZCQXGnqKfXoSpZTimZpRE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedObject>(intPtr3) : null;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000B4954 File Offset: 0x000B2B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289790, RefRangeEnd = 289791, XrefRangeStart = 289708, XrefRangeEnd = 289790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void oNyGkjXkFDvVnHlPrDgpKRwoJAQ(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000B4998 File Offset: 0x000B2B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289808, RefRangeEnd = 289810, XrefRangeStart = 289791, XrefRangeEnd = 289808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool qMMTpeQwXdHPjVTnNgIqFdgetDa(SerializedObject A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0000E423 File Offset: 0x0000C623
		public ControllerMapLayoutManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000B49E8 File Offset: 0x000B2BE8
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0000E42C File Offset: 0x0000C62C
		public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000B4A10 File Offset: 0x000B2C10
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000E447 File Offset: 0x0000C647
		public unsafe bool cDEZcYoTFtYfbBIAIjPYesqoaHw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_cDEZcYoTFtYfbBIAIjPYesqoaHw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_cDEZcYoTFtYfbBIAIjPYesqoaHw)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000B4A38 File Offset: 0x000B2C38
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0000E462 File Offset: 0x0000C662
		public unsafe Player LJLpeqIMXIWQRJmTMPOerYeeqPn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000B4A68 File Offset: 0x000B2C68
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0000E481 File Offset: 0x0000C681
		public unsafe ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd XdWOzpsdmQUGmfcwmkQXSOiMQvy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000B4A98 File Offset: 0x000B2C98
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x0000E4A0 File Offset: 0x0000C6A0
		public unsafe int SBmxkshsppDFZPZvftqYxbMuemu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000B4AC0 File Offset: 0x000B2CC0
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x0000E4BB File Offset: 0x0000C6BB
		public unsafe List<ControllerMapLayoutManager.RuleSet> OWNfHRylfIrUKTpRxpcGanoVhaZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager.RuleSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000B4AF0 File Offset: 0x000B2CF0
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0000E4DA File Offset: 0x0000C6DA
		public unsafe Action ECquLjjyxWLqzMJEovptwOiZVrO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_ECquLjjyxWLqzMJEovptwOiZVrO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.NativeFieldInfoPtr_ECquLjjyxWLqzMJEovptwOiZVrO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_cDEZcYoTFtYfbBIAIjPYesqoaHw;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_LJLpeqIMXIWQRJmTMPOerYeeqPn;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_XdWOzpsdmQUGmfcwmkQXSOiMQvy;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_SBmxkshsppDFZPZvftqYxbMuemu;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeFieldInfoPtr_OWNfHRylfIrUKTpRxpcGanoVhaZ;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeFieldInfoPtr_ECquLjjyxWLqzMJEovptwOiZVrO;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_add_ApplyCalledEvent_Internal_add_Void_Action_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_remove_ApplyCalledEvent_Internal_rem_Void_Action_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Player_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSet_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSet_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaults_Public_Void_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_String_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonString_Public_String_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_ImportXml_Public_Boolean_String_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_ImportJson_Public_Boolean_String_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_TUpbRFbZCQXGnqKfXoSpZTimZpRE_Private_SerializedObject_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_oNyGkjXkFDvVnHlPrDgpKRwoJAQ_Private_Void_SerializedObject_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_qMMTpeQwXdHPjVTnNgIqFdgetDa_Private_Boolean_SerializedObject_0;

		// Token: 0x02000361 RID: 865
		public class sxAMvsNcBoaqKdJiNlPgecwsqKZd : Object
		{
			// Token: 0x060047BA RID: 18362 RVA: 0x0014C074 File Offset: 0x0014A274
			// Note: this type is marked as 'beforefieldinit'.
			static sxAMvsNcBoaqKdJiNlPgecwsqKZd()
			{
				Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "sxAMvsNcBoaqKdJiNlPgecwsqKZd");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr);
				ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr, "yBWkcJugFdvDjCdGYaZAHUEYmYX");
				ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_FUygBpgXeyrTmaAWcOKboCchonWc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr, "FUygBpgXeyrTmaAWcOKboCchonWc");
				ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr, "sgICyBnveYENQlXQnsfPeXuGgEm");
				ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr, 100670920);
			}

			// Token: 0x060047BB RID: 18363 RVA: 0x0014C0F0 File Offset: 0x0014A2F0
			[CallerCount(0)]
			public unsafe sxAMvsNcBoaqKdJiNlPgecwsqKZd(bool enabled, bool loadFromUserDataStore, Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> startingRuleSets)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFromUserDataStore;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startingRuleSets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047BC RID: 18364 RVA: 0x00019F62 File Offset: 0x00018162
			public sxAMvsNcBoaqKdJiNlPgecwsqKZd(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001657 RID: 5719
			// (get) Token: 0x060047BD RID: 18365 RVA: 0x0014C158 File Offset: 0x0014A358
			// (set) Token: 0x060047BE RID: 18366 RVA: 0x00019F6B File Offset: 0x0001816B
			public unsafe bool yBWkcJugFdvDjCdGYaZAHUEYmYX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX)) = value;
				}
			}

			// Token: 0x17001658 RID: 5720
			// (get) Token: 0x060047BF RID: 18367 RVA: 0x0014C180 File Offset: 0x0014A380
			// (set) Token: 0x060047C0 RID: 18368 RVA: 0x00019F86 File Offset: 0x00018186
			public unsafe bool FUygBpgXeyrTmaAWcOKboCchonWc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_FUygBpgXeyrTmaAWcOKboCchonWc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_FUygBpgXeyrTmaAWcOKboCchonWc)) = value;
				}
			}

			// Token: 0x17001659 RID: 5721
			// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0014C1A8 File Offset: 0x0014A3A8
			// (set) Token: 0x060047C2 RID: 18370 RVA: 0x00019FA1 File Offset: 0x000181A1
			public unsafe Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> sgICyBnveYENQlXQnsfPeXuGgEm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd.NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A70 RID: 14960
			private static readonly IntPtr NativeFieldInfoPtr_yBWkcJugFdvDjCdGYaZAHUEYmYX;

			// Token: 0x04003A71 RID: 14961
			private static readonly IntPtr NativeFieldInfoPtr_FUygBpgXeyrTmaAWcOKboCchonWc;

			// Token: 0x04003A72 RID: 14962
			private static readonly IntPtr NativeFieldInfoPtr_sgICyBnveYENQlXQnsfPeXuGgEm;

			// Token: 0x04003A73 RID: 14963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0;
		}

		// Token: 0x02000362 RID: 866
		[Serializable]
		public sealed class Rule : Object
		{
			// Token: 0x060047C3 RID: 18371 RVA: 0x0014C1D8 File Offset: 0x0014A3D8
			// Note: this type is marked as 'beforefieldinit'.
			static Rule()
			{
				Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "Rule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr);
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_tag");
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__categoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_categoryIds");
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__layoutId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_layoutId");
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__controllerSetSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_controllerSetSelector");
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitCategoryNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_preInitCategoryNames");
				ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitLayoutName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, "_preInitLayoutName");
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670921);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Public_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670922);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670923);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670924);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670925);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670926);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670927);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670928);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670929);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670930);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670931);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670932);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670933);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670934);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670935);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670936);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670937);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_layoutName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670938);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670939);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670940);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670941);
				ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr, 100670942);
			}

			// Token: 0x060047C4 RID: 18372 RVA: 0x0014C434 File Offset: 0x0014A634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289059, XrefRangeEnd = 289064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rule()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047C5 RID: 18373 RVA: 0x0014C470 File Offset: 0x0014A670
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289075, RefRangeEnd = 289076, XrefRangeStart = 289064, XrefRangeEnd = 289075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Rule(ControllerMapLayoutManager.Rule source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Public_Void_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047C6 RID: 18374 RVA: 0x0014C4BC File Offset: 0x0014A6BC
			[CallerCount(0)]
			public unsafe Rule(string tag, Il2CppStructArray<int> categoryIds, int layoutId, ControllerSetSelector controllerSetSelector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.Rule>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categoryIds);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controllerSetSelector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001660 RID: 5728
			// (get) Token: 0x060047C7 RID: 18375 RVA: 0x0014C53C File Offset: 0x0014A73C
			// (set) Token: 0x060047C8 RID: 18376 RVA: 0x0014C574 File Offset: 0x0014A774
			public unsafe string tag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001661 RID: 5729
			// (get) Token: 0x060047C9 RID: 18377 RVA: 0x0014C5B8 File Offset: 0x0014A7B8
			// (set) Token: 0x060047CA RID: 18378 RVA: 0x0014C5F8 File Offset: 0x0014A7F8
			public unsafe ControllerSetSelector controllerSetSelector
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 289079, RefRangeEnd = 289087, XrefRangeStart = 289076, XrefRangeEnd = 289079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289087, XrefRangeEnd = 289105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001662 RID: 5730
			// (get) Token: 0x060047CB RID: 18379 RVA: 0x0014C63C File Offset: 0x0014A83C
			// (set) Token: 0x060047CC RID: 18380 RVA: 0x0014C678 File Offset: 0x0014A878
			public unsafe int categoryId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289105, XrefRangeEnd = 289107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289107, XrefRangeEnd = 289114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x060047CD RID: 18381 RVA: 0x0014C6B8 File Offset: 0x0014A8B8
			// (set) Token: 0x060047CE RID: 18382 RVA: 0x0014C6F8 File Offset: 0x0014A8F8
			public unsafe Il2CppStructArray<int> categoryIds
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 289117, RefRangeEnd = 289121, XrefRangeStart = 289114, XrefRangeEnd = 289117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289121, XrefRangeEnd = 289123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x060047CF RID: 18383 RVA: 0x0014C73C File Offset: 0x0014A93C
			// (set) Token: 0x060047D0 RID: 18384 RVA: 0x0014C778 File Offset: 0x0014A978
			public unsafe int layoutId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289123, XrefRangeEnd = 289124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x060047D1 RID: 18385 RVA: 0x0014C7B8 File Offset: 0x0014A9B8
			// (set) Token: 0x060047D2 RID: 18386 RVA: 0x0014C7F0 File Offset: 0x0014A9F0
			public unsafe string categoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289124, XrefRangeEnd = 289134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289134, XrefRangeEnd = 289150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0014C834 File Offset: 0x0014AA34
			// (set) Token: 0x060047D4 RID: 18388 RVA: 0x0014C874 File Offset: 0x0014AA74
			public unsafe Il2CppStringArray categoryNames
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289150, XrefRangeEnd = 289169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289169, XrefRangeEnd = 289197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001667 RID: 5735
			// (get) Token: 0x060047D5 RID: 18389 RVA: 0x0014C8B8 File Offset: 0x0014AAB8
			// (set) Token: 0x060047D6 RID: 18390 RVA: 0x0014C8F0 File Offset: 0x0014AAF0
			public unsafe string layoutName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289197, XrefRangeEnd = 289208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_layoutName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 289240, RefRangeEnd = 289241, XrefRangeStart = 289208, XrefRangeEnd = 289240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001668 RID: 5736
			// (get) Token: 0x060047D7 RID: 18391 RVA: 0x0014C934 File Offset: 0x0014AB34
			public unsafe bool isValid
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 289257, RefRangeEnd = 289258, XrefRangeStart = 289241, XrefRangeEnd = 289257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047D8 RID: 18392 RVA: 0x0014C970 File Offset: 0x0014AB70
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 289291, RefRangeEnd = 289303, XrefRangeStart = 289258, XrefRangeEnd = 289291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047D9 RID: 18393 RVA: 0x0014C9A4 File Offset: 0x0014ABA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289303, XrefRangeEnd = 289307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.Rule.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060047DA RID: 18394 RVA: 0x00019FC0 File Offset: 0x000181C0
			public Rule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700165A RID: 5722
			// (get) Token: 0x060047DB RID: 18395 RVA: 0x0014C9E4 File Offset: 0x0014ABE4
			// (set) Token: 0x060047DC RID: 18396 RVA: 0x00019FC9 File Offset: 0x000181C9
			public unsafe string _tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__tag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700165B RID: 5723
			// (get) Token: 0x060047DD RID: 18397 RVA: 0x0014CA0C File Offset: 0x0014AC0C
			// (set) Token: 0x060047DE RID: 18398 RVA: 0x00019FE8 File Offset: 0x000181E8
			public unsafe Il2CppStructArray<int> _categoryIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__categoryIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__categoryIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700165C RID: 5724
			// (get) Token: 0x060047DF RID: 18399 RVA: 0x0014CA3C File Offset: 0x0014AC3C
			// (set) Token: 0x060047E0 RID: 18400 RVA: 0x0001A007 File Offset: 0x00018207
			public unsafe int _layoutId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__layoutId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__layoutId)) = value;
				}
			}

			// Token: 0x1700165D RID: 5725
			// (get) Token: 0x060047E1 RID: 18401 RVA: 0x0014CA64 File Offset: 0x0014AC64
			// (set) Token: 0x060047E2 RID: 18402 RVA: 0x0001A022 File Offset: 0x00018222
			public unsafe ControllerSetSelector _controllerSetSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__controllerSetSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__controllerSetSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700165E RID: 5726
			// (get) Token: 0x060047E3 RID: 18403 RVA: 0x0014CA94 File Offset: 0x0014AC94
			// (set) Token: 0x060047E4 RID: 18404 RVA: 0x0001A041 File Offset: 0x00018241
			public unsafe Il2CppStringArray _preInitCategoryNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitCategoryNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitCategoryNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700165F RID: 5727
			// (get) Token: 0x060047E5 RID: 18405 RVA: 0x0014CAC4 File Offset: 0x0014ACC4
			// (set) Token: 0x060047E6 RID: 18406 RVA: 0x0001A060 File Offset: 0x00018260
			public unsafe string _preInitLayoutName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitLayoutName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.Rule.NativeFieldInfoPtr__preInitLayoutName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003A74 RID: 14964
			private static readonly IntPtr NativeFieldInfoPtr__tag;

			// Token: 0x04003A75 RID: 14965
			private static readonly IntPtr NativeFieldInfoPtr__categoryIds;

			// Token: 0x04003A76 RID: 14966
			private static readonly IntPtr NativeFieldInfoPtr__layoutId;

			// Token: 0x04003A77 RID: 14967
			private static readonly IntPtr NativeFieldInfoPtr__controllerSetSelector;

			// Token: 0x04003A78 RID: 14968
			private static readonly IntPtr NativeFieldInfoPtr__preInitCategoryNames;

			// Token: 0x04003A79 RID: 14969
			private static readonly IntPtr NativeFieldInfoPtr__preInitLayoutName;

			// Token: 0x04003A7A RID: 14970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A7B RID: 14971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rule_0;

			// Token: 0x04003A7C RID: 14972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStructArray_1_Int32_Int32_ControllerSetSelector_0;

			// Token: 0x04003A7D RID: 14973
			private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

			// Token: 0x04003A7E RID: 14974
			private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

			// Token: 0x04003A7F RID: 14975
			private static readonly IntPtr NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_0;

			// Token: 0x04003A80 RID: 14976
			private static readonly IntPtr NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_0;

			// Token: 0x04003A81 RID: 14977
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

			// Token: 0x04003A82 RID: 14978
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryId_Public_set_Void_Int32_0;

			// Token: 0x04003A83 RID: 14979
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryIds_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A84 RID: 14980
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x04003A85 RID: 14981
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

			// Token: 0x04003A86 RID: 14982
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutId_Public_set_Void_Int32_0;

			// Token: 0x04003A87 RID: 14983
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryName_Public_get_String_0;

			// Token: 0x04003A88 RID: 14984
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryName_Public_set_Void_String_0;

			// Token: 0x04003A89 RID: 14985
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryNames_Public_get_Il2CppStringArray_0;

			// Token: 0x04003A8A RID: 14986
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryNames_Public_set_Void_Il2CppStringArray_0;

			// Token: 0x04003A8B RID: 14987
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutName_Public_get_String_0;

			// Token: 0x04003A8C RID: 14988
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutName_Public_set_Void_String_0;

			// Token: 0x04003A8D RID: 14989
			private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0;

			// Token: 0x04003A8E RID: 14990
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

			// Token: 0x04003A8F RID: 14991
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x02000363 RID: 867
		[Serializable]
		public sealed class RuleSet : Object
		{
			// Token: 0x060047E7 RID: 18407 RVA: 0x0014CAEC File Offset: 0x0014ACEC
			// Note: this type is marked as 'beforefieldinit'.
			static RuleSet()
			{
				Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerMapLayoutManager>.NativeClassPtr, "RuleSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr);
				ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, "className");
				ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, "_enabled");
				ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, "_tag");
				ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, "_rules");
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670943);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670944);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670945);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670946);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670947);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670948);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670949);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670950);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670951);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670952);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670953);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670954);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670955);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670956);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670957);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670958);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670959);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670960);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670961);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670962);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670963);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670964);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670965);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapLayoutManager_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670966);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670967);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670968);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670969);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670970);
				ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_CheckList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr, 100670971);
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x060047E8 RID: 18408 RVA: 0x0014CDAC File Offset: 0x0014AFAC
			// (set) Token: 0x060047E9 RID: 18409 RVA: 0x0014CDE8 File Offset: 0x0014AFE8
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x060047EA RID: 18410 RVA: 0x0014CE28 File Offset: 0x0014B028
			// (set) Token: 0x060047EB RID: 18411 RVA: 0x0014CE60 File Offset: 0x0014B060
			public unsafe string tag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x060047EC RID: 18412 RVA: 0x0014CEA4 File Offset: 0x0014B0A4
			// (set) Token: 0x060047ED RID: 18413 RVA: 0x0014CEE4 File Offset: 0x0014B0E4
			public unsafe List<ControllerMapLayoutManager.Rule> rules
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager.Rule>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289307, XrefRangeEnd = 289308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060047EE RID: 18414 RVA: 0x0014CF28 File Offset: 0x0014B128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289308, XrefRangeEnd = 289315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet(bool enabled, string tag, List<ControllerMapLayoutManager.Rule> rules)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr))
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047EF RID: 18415 RVA: 0x0014CF94 File Offset: 0x0014B194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289315, XrefRangeEnd = 289321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047F0 RID: 18416 RVA: 0x0014CFD0 File Offset: 0x0014B1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289321, XrefRangeEnd = 289334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuleSet(ControllerMapLayoutManager.RuleSet source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapLayoutManager.RuleSet>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047F1 RID: 18417 RVA: 0x0014D01C File Offset: 0x0014B21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289334, XrefRangeEnd = 289341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapLayoutManager.Rule Find(Predicate<ControllerMapLayoutManager.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.Rule>(intPtr3) : null;
				}
			}

			// Token: 0x060047F2 RID: 18418 RVA: 0x0014D06C File Offset: 0x0014B26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289341, XrefRangeEnd = 289347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapLayoutManager.Rule FindLast(Predicate<ControllerMapLayoutManager.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.Rule>(intPtr3) : null;
				}
			}

			// Token: 0x060047F3 RID: 18419 RVA: 0x0014D0BC File Offset: 0x0014B2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289347, XrefRangeEnd = 289354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindIndex(Predicate<ControllerMapLayoutManager.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047F4 RID: 18420 RVA: 0x0014D10C File Offset: 0x0014B30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289354, XrefRangeEnd = 289360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindLastIndex(Predicate<ControllerMapLayoutManager.Rule> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047F5 RID: 18421 RVA: 0x0014D15C File Offset: 0x0014B35C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289360, XrefRangeEnd = 289362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOf(ControllerMapLayoutManager.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047F6 RID: 18422 RVA: 0x0014D1AC File Offset: 0x0014B3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289362, XrefRangeEnd = 289367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Insert(int index, ControllerMapLayoutManager.Rule item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047F7 RID: 18423 RVA: 0x0014D1FC File Offset: 0x0014B3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289367, XrefRangeEnd = 289372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001670 RID: 5744
			public unsafe ControllerMapLayoutManager.Rule this[int index]
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 289374, RefRangeEnd = 289376, XrefRangeStart = 289372, XrefRangeEnd = 289374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.Rule>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289376, XrefRangeEnd = 289379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047FA RID: 18426 RVA: 0x0014D2D8 File Offset: 0x0014B4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289379, XrefRangeEnd = 289384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(ControllerMapLayoutManager.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060047FB RID: 18427 RVA: 0x0014D31C File Offset: 0x0014B51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289384, XrefRangeEnd = 289387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060047FC RID: 18428 RVA: 0x0014D350 File Offset: 0x0014B550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289387, XrefRangeEnd = 289392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Contains(ControllerMapLayoutManager.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060047FD RID: 18429 RVA: 0x0014D3A0 File Offset: 0x0014B5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289392, XrefRangeEnd = 289395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppReferenceArray<ControllerMapLayoutManager.Rule> array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001671 RID: 5745
			// (get) Token: 0x060047FE RID: 18430 RVA: 0x0014D3F0 File Offset: 0x0014B5F0
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 289397, RefRangeEnd = 289398, XrefRangeStart = 289395, XrefRangeEnd = 289397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001672 RID: 5746
			// (get) Token: 0x060047FF RID: 18431 RVA: 0x0014D42C File Offset: 0x0014B62C
			public unsafe bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289398, XrefRangeEnd = 289403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapLayoutManager_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004800 RID: 18432 RVA: 0x0014D468 File Offset: 0x0014B668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289403, XrefRangeEnd = 289406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Remove(ControllerMapLayoutManager.Rule item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004801 RID: 18433 RVA: 0x0014D4B8 File Offset: 0x0014B6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289406, XrefRangeEnd = 289411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ControllerMapLayoutManager.Rule> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ControllerMapLayoutManager.Rule>>(intPtr3) : null;
			}

			// Token: 0x06004802 RID: 18434 RVA: 0x0014D4F8 File Offset: 0x0014B6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289411, XrefRangeEnd = 289416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004803 RID: 18435 RVA: 0x0014D538 File Offset: 0x0014B738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289416, XrefRangeEnd = 289426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06004804 RID: 18436 RVA: 0x0014D578 File Offset: 0x0014B778
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 289432, RefRangeEnd = 289453, XrefRangeStart = 289426, XrefRangeEnd = 289432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapLayoutManager.RuleSet.NativeMethodInfoPtr_CheckList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004805 RID: 18437 RVA: 0x0001A07F File Offset: 0x0001827F
			public RuleSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001669 RID: 5737
			// (get) Token: 0x06004806 RID: 18438 RVA: 0x0014D5AC File Offset: 0x0014B7AC
			// (set) Token: 0x06004807 RID: 18439 RVA: 0x0001A088 File Offset: 0x00018288
			public unsafe static string className
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr_className, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr_className, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700166A RID: 5738
			// (get) Token: 0x06004808 RID: 18440 RVA: 0x0014D5CC File Offset: 0x0014B7CC
			// (set) Token: 0x06004809 RID: 18441 RVA: 0x0001A09A File Offset: 0x0001829A
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x1700166B RID: 5739
			// (get) Token: 0x0600480A RID: 18442 RVA: 0x0014D5F4 File Offset: 0x0014B7F4
			// (set) Token: 0x0600480B RID: 18443 RVA: 0x0001A0B5 File Offset: 0x000182B5
			public unsafe string _tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__tag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x0600480C RID: 18444 RVA: 0x0014D61C File Offset: 0x0014B81C
			// (set) Token: 0x0600480D RID: 18445 RVA: 0x0001A0D4 File Offset: 0x000182D4
			public unsafe List<ControllerMapLayoutManager.Rule> _rules
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__rules);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControllerMapLayoutManager.Rule>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapLayoutManager.RuleSet.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A90 RID: 14992
			private static readonly IntPtr NativeFieldInfoPtr_className;

			// Token: 0x04003A91 RID: 14993
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x04003A92 RID: 14994
			private static readonly IntPtr NativeFieldInfoPtr__tag;

			// Token: 0x04003A93 RID: 14995
			private static readonly IntPtr NativeFieldInfoPtr__rules;

			// Token: 0x04003A94 RID: 14996
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003A95 RID: 14997
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04003A96 RID: 14998
			private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

			// Token: 0x04003A97 RID: 14999
			private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

			// Token: 0x04003A98 RID: 15000
			private static readonly IntPtr NativeMethodInfoPtr_get_rules_Public_get_List_1_Rule_0;

			// Token: 0x04003A99 RID: 15001
			private static readonly IntPtr NativeMethodInfoPtr_set_rules_Public_set_Void_List_1_Rule_0;

			// Token: 0x04003A9A RID: 15002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_String_List_1_Rule_0;

			// Token: 0x04003A9B RID: 15003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003A9C RID: 15004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuleSet_0;

			// Token: 0x04003A9D RID: 15005
			private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Rule_Predicate_1_Rule_0;

			// Token: 0x04003A9E RID: 15006
			private static readonly IntPtr NativeMethodInfoPtr_FindLast_Public_Rule_Predicate_1_Rule_0;

			// Token: 0x04003A9F RID: 15007
			private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_Rule_0;

			// Token: 0x04003AA0 RID: 15008
			private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_Rule_0;

			// Token: 0x04003AA1 RID: 15009
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_Rule_0;

			// Token: 0x04003AA2 RID: 15010
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_Rule_0;

			// Token: 0x04003AA3 RID: 15011
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04003AA4 RID: 15012
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Rule_Int32_0;

			// Token: 0x04003AA5 RID: 15013
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_Rule_0;

			// Token: 0x04003AA6 RID: 15014
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Rule_0;

			// Token: 0x04003AA7 RID: 15015
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

			// Token: 0x04003AA8 RID: 15016
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Rule_0;

			// Token: 0x04003AA9 RID: 15017
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Rule_Int32_0;

			// Token: 0x04003AAA RID: 15018
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003AAB RID: 15019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Rewired_ControllerMapLayoutManager_Rule__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04003AAC RID: 15020
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Rule_0;

			// Token: 0x04003AAD RID: 15021
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Rule_0;

			// Token: 0x04003AAE RID: 15022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04003AAF RID: 15023
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;

			// Token: 0x04003AB0 RID: 15024
			private static readonly IntPtr NativeMethodInfoPtr_CheckList_Private_Void_0;
		}
	}
}
