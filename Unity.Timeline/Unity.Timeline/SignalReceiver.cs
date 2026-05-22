using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002C RID: 44
	public class SignalReceiver : MonoBehaviour
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x00013CC8 File Offset: 0x00011EC8
		// Note: this type is marked as 'beforefieldinit'.
		static SignalReceiver()
		{
			Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalReceiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr);
			SignalReceiver.NativeFieldInfoPtr_m_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, "m_Events");
			SignalReceiver.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663956);
			SignalReceiver.NativeMethodInfoPtr_AddReaction_Public_Void_SignalAsset_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663957);
			SignalReceiver.NativeMethodInfoPtr_AddEmptyReaction_Public_Int32_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663958);
			SignalReceiver.NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663959);
			SignalReceiver.NativeMethodInfoPtr_GetRegisteredSignals_Public_IEnumerable_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663960);
			SignalReceiver.NativeMethodInfoPtr_GetReaction_Public_UnityEvent_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663961);
			SignalReceiver.NativeMethodInfoPtr_Count_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663962);
			SignalReceiver.NativeMethodInfoPtr_ChangeSignalAtIndex_Public_Void_Int32_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663963);
			SignalReceiver.NativeMethodInfoPtr_RemoveAtIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663964);
			SignalReceiver.NativeMethodInfoPtr_ChangeReactionAtIndex_Public_Void_Int32_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663965);
			SignalReceiver.NativeMethodInfoPtr_GetReactionAtIndex_Public_UnityEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663966);
			SignalReceiver.NativeMethodInfoPtr_GetSignalAssetAtIndex_Public_SignalAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663967);
			SignalReceiver.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663968);
			SignalReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, 100663969);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00013E24 File Offset: 0x00012024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478125, XrefRangeEnd = 478154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnNotify(Playable origin, INotification notification, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00013E88 File Offset: 0x00012088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478154, XrefRangeEnd = 478183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddReaction(SignalAsset asset, UnityEvent reaction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reaction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_AddReaction_Public_Void_SignalAsset_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00013EDC File Offset: 0x000120DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478183, XrefRangeEnd = 478185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddEmptyReaction(UnityEvent reaction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reaction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_AddEmptyReaction_Public_Int32_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00013F2C File Offset: 0x0001212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478185, XrefRangeEnd = 478196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(SignalAsset asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00013F70 File Offset: 0x00012170
		[CallerCount(0)]
		public unsafe IEnumerable<SignalAsset> GetRegisteredSignals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_GetRegisteredSignals_Public_IEnumerable_1_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SignalAsset>>(intPtr3) : null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00013FB0 File Offset: 0x000121B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478196, XrefRangeEnd = 478197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent GetReaction(SignalAsset key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_GetReaction_Public_UnityEvent_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00014000 File Offset: 0x00012200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478197, XrefRangeEnd = 478198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_Count_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001403C File Offset: 0x0001223C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478198, XrefRangeEnd = 478258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSignalAtIndex(int idx, SignalAsset newKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_ChangeSignalAtIndex_Public_Void_Int32_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001408C File Offset: 0x0001228C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478258, XrefRangeEnd = 478265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAtIndex(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_RemoveAtIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000140CC File Offset: 0x000122CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478265, XrefRangeEnd = 478268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeReactionAtIndex(int idx, UnityEvent reaction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reaction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_ChangeReactionAtIndex_Public_Void_Int32_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001411C File Offset: 0x0001231C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478268, XrefRangeEnd = 478270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent GetReactionAtIndex(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_GetReactionAtIndex_Public_UnityEvent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00014168 File Offset: 0x00012368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478270, XrefRangeEnd = 478272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalAsset GetSignalAssetAtIndex(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_GetSignalAssetAtIndex_Public_SignalAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SignalAsset>(intPtr3) : null;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000141B4 File Offset: 0x000123B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000141E8 File Offset: 0x000123E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478272, XrefRangeEnd = 478290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignalReceiver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003424 File Offset: 0x00001624
		public SignalReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00014224 File Offset: 0x00012424
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000342D File Offset: 0x0000162D
		public unsafe SignalReceiver.EventKeyValue m_Events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.NativeFieldInfoPtr_m_Events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SignalReceiver.EventKeyValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.NativeFieldInfoPtr_m_Events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_m_Events;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_AddReaction_Public_Void_SignalAsset_UnityEvent_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_AddEmptyReaction_Public_Int32_UnityEvent_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredSignals_Public_IEnumerable_1_SignalAsset_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GetReaction_Public_UnityEvent_SignalAsset_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Int32_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSignalAtIndex_Public_Void_Int32_SignalAsset_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtIndex_Public_Void_Int32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_ChangeReactionAtIndex_Public_Void_Int32_UnityEvent_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_GetReactionAtIndex_Public_UnityEvent_Int32_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_GetSignalAssetAtIndex_Public_SignalAsset_Int32_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000072 RID: 114
		[Serializable]
		public class EventKeyValue : Object
		{
			// Token: 0x060005F7 RID: 1527 RVA: 0x0001B4F4 File Offset: 0x000196F4
			// Note: this type is marked as 'beforefieldinit'.
			static EventKeyValue()
			{
				Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignalReceiver>.NativeClassPtr, "EventKeyValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr);
				SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Signals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, "m_Signals");
				SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, "m_Events");
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_TryGetValue_Public_Boolean_SignalAsset_byref_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663970);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Append_Public_Void_SignalAsset_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663971);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Remove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663972);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663973);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_get_signals_Public_get_List_1_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663974);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr_get_events_Public_get_List_1_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663975);
				SignalReceiver.EventKeyValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr, 100663976);
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x0001B5D4 File Offset: 0x000197D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 478088, RefRangeEnd = 478090, XrefRangeStart = 478085, XrefRangeEnd = 478088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryGetValue(SignalAsset key, out UnityEvent value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_TryGetValue_Public_Boolean_SignalAsset_byref_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new UnityEvent(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x0001B644 File Offset: 0x00019844
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 478097, RefRangeEnd = 478099, XrefRangeStart = 478090, XrefRangeEnd = 478097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Append(SignalAsset key, UnityEvent value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Append_Public_Void_SignalAsset_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x0001B698 File Offset: 0x00019898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478099, XrefRangeEnd = 478105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(int idx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref idx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Remove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x0001B6D8 File Offset: 0x000198D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478105, XrefRangeEnd = 478113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(SignalAsset key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001B71C File Offset: 0x0001991C
			public unsafe List<SignalAsset> signals
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_get_signals_Public_get_List_1_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SignalAsset>>(intPtr3) : null;
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001B75C File Offset: 0x0001995C
			public unsafe List<UnityEvent> events
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr_get_events_Public_get_List_1_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UnityEvent>>(intPtr3) : null;
				}
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x0001B79C File Offset: 0x0001999C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478113, XrefRangeEnd = 478125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventKeyValue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalReceiver.EventKeyValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignalReceiver.EventKeyValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x000041CF File Offset: 0x000023CF
			public EventKeyValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001B7D8 File Offset: 0x000199D8
			// (set) Token: 0x06000601 RID: 1537 RVA: 0x000041D8 File Offset: 0x000023D8
			public unsafe List<SignalAsset> m_Signals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Signals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SignalAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Signals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001B808 File Offset: 0x00019A08
			// (set) Token: 0x06000603 RID: 1539 RVA: 0x000041F7 File Offset: 0x000023F7
			public unsafe List<UnityEvent> m_Events
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Events);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEvent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SignalReceiver.EventKeyValue.NativeFieldInfoPtr_m_Events), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400049D RID: 1181
			private static readonly IntPtr NativeFieldInfoPtr_m_Signals;

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeFieldInfoPtr_m_Events;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_SignalAsset_byref_UnityEvent_0;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_SignalAsset_UnityEvent_0;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Int32_0;

			// Token: 0x040004A2 RID: 1186
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_SignalAsset_0;

			// Token: 0x040004A3 RID: 1187
			private static readonly IntPtr NativeMethodInfoPtr_get_signals_Public_get_List_1_SignalAsset_0;

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeMethodInfoPtr_get_events_Public_get_List_1_UnityEvent_0;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
