using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000085 RID: 133
	public sealed class EventHandlerList : Object
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00030C94 File Offset: 0x0002EE94
		// Note: this type is marked as 'beforefieldinit'.
		static EventHandlerList()
		{
			Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EventHandlerList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr);
			EventHandlerList.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "head");
			EventHandlerList.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "parent");
			EventHandlerList.NativeMethodInfoPtr__ctor_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664529);
			EventHandlerList.NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664530);
			EventHandlerList.NativeMethodInfoPtr_AddHandler_Public_Void_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664531);
			EventHandlerList.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664532);
			EventHandlerList.NativeMethodInfoPtr_Find_Private_ListEntry_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664533);
			EventHandlerList.NativeMethodInfoPtr_RemoveHandler_Public_Void_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, 100664534);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00030D64 File Offset: 0x0002EF64
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventHandlerList(Component parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr__ctor_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000283 RID: 643
		public unsafe Delegate this[Object key]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 372837, RefRangeEnd = 372838, XrefRangeStart = 372837, XrefRangeEnd = 372837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00030E00 File Offset: 0x0002F000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372841, RefRangeEnd = 372844, XrefRangeStart = 372838, XrefRangeEnd = 372841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddHandler(Object key, Delegate value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_AddHandler_Public_Void_Object_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00030E54 File Offset: 0x0002F054
		[CallerCount(0)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00030E88 File Offset: 0x0002F088
		[CallerCount(0)]
		public unsafe EventHandlerList.ListEntry Find(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_Find_Private_ListEntry_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00030ED8 File Offset: 0x0002F0D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 372844, RefRangeEnd = 372847, XrefRangeStart = 372844, XrefRangeEnd = 372844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveHandler(Object key, Delegate value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.NativeMethodInfoPtr_RemoveHandler_Public_Void_Object_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00005684 File Offset: 0x00003884
		public EventHandlerList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00030F2C File Offset: 0x0002F12C
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x0000568D File Offset: 0x0000388D
		public unsafe EventHandlerList.ListEntry head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00030F5C File Offset: 0x0002F15C
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x000056AC File Offset: 0x000038AC
		public unsafe Component parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Component_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Delegate_Object_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Public_Void_Object_Delegate_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_Find_Private_ListEntry_Object_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHandler_Public_Void_Object_Delegate_0;

		// Token: 0x020001BB RID: 443
		public sealed class ListEntry : Object
		{
			// Token: 0x06001912 RID: 6418 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
			// Note: this type is marked as 'beforefieldinit'.
			static ListEntry()
			{
				Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventHandlerList>.NativeClassPtr, "ListEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr);
				EventHandlerList.ListEntry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "next");
				EventHandlerList.ListEntry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "key");
				EventHandlerList.ListEntry.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, "handler");
				EventHandlerList.ListEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_ListEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr, 100664535);
			}

			// Token: 0x06001913 RID: 6419 RVA: 0x0006C270 File Offset: 0x0006A470
			[CallerCount(0)]
			public unsafe ListEntry(Object key, Delegate handler, EventHandlerList.ListEntry next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandlerList.ListEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlerList.ListEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_ListEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001914 RID: 6420 RVA: 0x0000CEE3 File Offset: 0x0000B0E3
			public ListEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06001915 RID: 6421 RVA: 0x0006C2E0 File Offset: 0x0006A4E0
			// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000CEEC File Offset: 0x0000B0EC
			public unsafe EventHandlerList.ListEntry next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandlerList.ListEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x06001917 RID: 6423 RVA: 0x0006C310 File Offset: 0x0006A510
			// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000CF0B File Offset: 0x0000B10B
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x06001919 RID: 6425 RVA: 0x0006C340 File Offset: 0x0006A540
			// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000CF2A File Offset: 0x0000B12A
			public unsafe Delegate handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlerList.ListEntry.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013E9 RID: 5097
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040013EA RID: 5098
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040013EB RID: 5099
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x040013EC RID: 5100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Delegate_ListEntry_0;
		}
	}
}
