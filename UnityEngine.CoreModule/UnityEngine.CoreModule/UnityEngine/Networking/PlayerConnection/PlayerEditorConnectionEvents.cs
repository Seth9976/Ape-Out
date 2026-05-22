using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x0200014E RID: 334
	[Serializable]
	public class PlayerEditorConnectionEvents : Object
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x00062608 File Offset: 0x00060808
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEditorConnectionEvents()
		{
			Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerEditorConnectionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "messageTypeSubscribers");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "connectionEvent");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "disconnectionEvent");
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665671);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665672);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665673);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665674);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000626C4 File Offset: 0x000608C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502260, RefRangeEnd = 502261, XrefRangeStart = 502213, XrefRangeEnd = 502260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeMessageIdSubscribers(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00062724 File Offset: 0x00060924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502290, RefRangeEnd = 502291, XrefRangeStart = 502261, XrefRangeEnd = 502290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Events.UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<MessageEventArgs>>(intPtr3) : null;
			}
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00062770 File Offset: 0x00060970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502307, RefRangeEnd = 502308, XrefRangeStart = 502291, XrefRangeEnd = 502307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000627C0 File Offset: 0x000609C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502323, RefRangeEnd = 502324, XrefRangeStart = 502308, XrefRangeEnd = 502323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEditorConnectionEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0000D7A7 File Offset: 0x0000B9A7
		public PlayerEditorConnectionEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x000627FC File Offset: 0x000609FC
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		public unsafe List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0006282C File Offset: 0x00060A2C
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0000D7CF File Offset: 0x0000B9CF
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0006285C File Offset: 0x00060A5C
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr_messageTypeSubscribers;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_connectionEvent;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_disconnectionEvent;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200093E RID: 2366
		[Serializable]
		public class MessageEvent : UnityEngine.Events.UnityEvent<MessageEventArgs>
		{
			// Token: 0x060030FF RID: 12543 RVA: 0x0001555C File Offset: 0x0001375C
			// Note: this type is marked as 'beforefieldinit'.
			static MessageEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr, 100665675);
			}

			// Token: 0x06003100 RID: 12544 RVA: 0x0007EF68 File Offset: 0x0007D168
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 502185, RefRangeEnd = 502188, XrefRangeStart = 502183, XrefRangeEnd = 502185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003101 RID: 12545 RVA: 0x00015590 File Offset: 0x00013790
			public MessageEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FB1 RID: 8113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200093F RID: 2367
		[Serializable]
		public class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
		{
			// Token: 0x06003102 RID: 12546 RVA: 0x00015599 File Offset: 0x00013799
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChangeEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "ConnectionChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr, 100665676);
			}

			// Token: 0x06003103 RID: 12547 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502188, XrefRangeEnd = 502190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000155CD File Offset: 0x000137CD
			public ConnectionChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FB2 RID: 8114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000940 RID: 2368
		[Serializable]
		public class MessageTypeSubscribers : Object
		{
			// Token: 0x06003105 RID: 12549 RVA: 0x0007EFE0 File Offset: 0x0007D1E0
			// Note: this type is marked as 'beforefieldinit'.
			static MessageTypeSubscribers()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageTypeSubscribers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "m_messageTypeId");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "subscriberCount");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "messageCallback");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665677);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665678);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665679);
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06003106 RID: 12550 RVA: 0x0007F084 File Offset: 0x0007D284
			// (set) Token: 0x06003107 RID: 12551 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
			public unsafe Guid MessageTypeId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502190, XrefRangeEnd = 502191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502191, XrefRangeEnd = 502194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003108 RID: 12552 RVA: 0x0007F100 File Offset: 0x0007D300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502194, XrefRangeEnd = 502198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageTypeSubscribers()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003109 RID: 12553 RVA: 0x000155D6 File Offset: 0x000137D6
			public MessageTypeSubscribers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x0600310A RID: 12554 RVA: 0x0007F13C File Offset: 0x0007D33C
			// (set) Token: 0x0600310B RID: 12555 RVA: 0x000155DF File Offset: 0x000137DF
			public unsafe string m_messageTypeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x0600310C RID: 12556 RVA: 0x0007F164 File Offset: 0x0007D364
			// (set) Token: 0x0600310D RID: 12557 RVA: 0x000155FE File Offset: 0x000137FE
			public unsafe int subscriberCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount)) = value;
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x0600310E RID: 12558 RVA: 0x0007F18C File Offset: 0x0007D38C
			// (set) Token: 0x0600310F RID: 12559 RVA: 0x00015619 File Offset: 0x00013819
			public unsafe PlayerEditorConnectionEvents.MessageEvent messageCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.MessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FB3 RID: 8115
			private static readonly IntPtr NativeFieldInfoPtr_m_messageTypeId;

			// Token: 0x04001FB4 RID: 8116
			private static readonly IntPtr NativeFieldInfoPtr_subscriberCount;

			// Token: 0x04001FB5 RID: 8117
			private static readonly IntPtr NativeFieldInfoPtr_messageCallback;

			// Token: 0x04001FB6 RID: 8118
			private static readonly IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;

			// Token: 0x04001FB7 RID: 8119
			private static readonly IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;

			// Token: 0x04001FB8 RID: 8120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000941 RID: 2369
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06003110 RID: 12560 RVA: 0x0007F1BC File Offset: 0x0007D3BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100665680);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100665681);
			}

			// Token: 0x06003111 RID: 12561 RVA: 0x0007F224 File Offset: 0x0007D424
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003112 RID: 12562 RVA: 0x0007F260 File Offset: 0x0007D460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502198, XrefRangeEnd = 502203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InvokeMessageIdSubscribers_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003113 RID: 12563 RVA: 0x00015638 File Offset: 0x00013838
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06003114 RID: 12564 RVA: 0x0007F2B0 File Offset: 0x0007D4B0
			// (set) Token: 0x06003115 RID: 12565 RVA: 0x00015641 File Offset: 0x00013841
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001FB9 RID: 8121
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001FBA RID: 8122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FBB RID: 8123
			private static readonly IntPtr NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000942 RID: 2370
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06003116 RID: 12566 RVA: 0x0007F2D8 File Offset: 0x0007D4D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100665682);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100665683);
			}

			// Token: 0x06003117 RID: 12567 RVA: 0x0007F340 File Offset: 0x0007D540
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003118 RID: 12568 RVA: 0x0007F37C File Offset: 0x0007D57C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502203, XrefRangeEnd = 502208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAndCreate_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003119 RID: 12569 RVA: 0x0001565C File Offset: 0x0001385C
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x0600311A RID: 12570 RVA: 0x0007F3CC File Offset: 0x0007D5CC
			// (set) Token: 0x0600311B RID: 12571 RVA: 0x00015665 File Offset: 0x00013865
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001FBC RID: 8124
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001FBD RID: 8125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FBE RID: 8126
			private static readonly IntPtr NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000943 RID: 2371
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600311C RID: 12572 RVA: 0x0007F3F4 File Offset: 0x0007D5F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100665684);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100665685);
			}

			// Token: 0x0600311D RID: 12573 RVA: 0x0007F45C File Offset: 0x0007D65C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600311E RID: 12574 RVA: 0x0007F498 File Offset: 0x0007D698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502208, XrefRangeEnd = 502213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnregisterManagedCallback_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600311F RID: 12575 RVA: 0x00015680 File Offset: 0x00013880
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06003120 RID: 12576 RVA: 0x0007F4E8 File Offset: 0x0007D6E8
			// (set) Token: 0x06003121 RID: 12577 RVA: 0x00015689 File Offset: 0x00013889
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001FBF RID: 8127
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001FC0 RID: 8128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FC1 RID: 8129
			private static readonly IntPtr NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000944 RID: 2372
		public sealed class <>c__DisplayClass6_0
		{
		}

		// Token: 0x02000945 RID: 2373
		public sealed class <>c__DisplayClass7_0
		{
		}

		// Token: 0x02000946 RID: 2374
		public sealed class <>c__DisplayClass8_0
		{
		}
	}
}
