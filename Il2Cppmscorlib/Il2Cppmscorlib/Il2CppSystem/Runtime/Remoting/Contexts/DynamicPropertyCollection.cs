using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B6 RID: 950
	public class DynamicPropertyCollection : Object
	{
		// Token: 0x06003EB9 RID: 16057 RVA: 0x00127C84 File Offset: 0x00125E84
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicPropertyCollection()
		{
			Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "DynamicPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr);
			DynamicPropertyCollection.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "_properties");
			DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672579);
			DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672580);
			DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672581);
			DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672582);
			DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672583);
			DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672584);
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x00127D40 File Offset: 0x00125F40
		public unsafe bool HasProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x00127D7C File Offset: 0x00125F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222504, RefRangeEnd = 222505, XrefRangeStart = 222484, XrefRangeEnd = 222504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00127DCC File Offset: 0x00125FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222509, RefRangeEnd = 222510, XrefRangeStart = 222505, XrefRangeEnd = 222509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterDynamicProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00127E1C File Offset: 0x0012601C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 222528, RefRangeEnd = 222541, XrefRangeStart = 222510, XrefRangeEnd = 222528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x00127E88 File Offset: 0x00126088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222547, RefRangeEnd = 222549, XrefRangeStart = 222541, XrefRangeEnd = 222547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x00127ED8 File Offset: 0x001260D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 222553, RefRangeEnd = 222559, XrefRangeStart = 222549, XrefRangeEnd = 222553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicPropertyCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0001767F File Offset: 0x0001587F
		public DynamicPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x00127F14 File Offset: 0x00126114
		// (set) Token: 0x06003EC2 RID: 16066 RVA: 0x00017688 File Offset: 0x00015888
		public unsafe ArrayList _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0;

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeMethodInfoPtr_FindProperty_Private_Int32_String_0;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000630 RID: 1584
		public class DynamicPropertyReg : Object
		{
			// Token: 0x06005602 RID: 22018 RVA: 0x001802C0 File Offset: 0x0017E4C0
			// Note: this type is marked as 'beforefieldinit'.
			static DynamicPropertyReg()
			{
				Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "DynamicPropertyReg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr);
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Property");
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Sink");
				DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, 100672585);
			}

			// Token: 0x06005603 RID: 22019 RVA: 0x00180328 File Offset: 0x0017E528
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicPropertyReg()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005604 RID: 22020 RVA: 0x00020C31 File Offset: 0x0001EE31
			public DynamicPropertyReg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161E RID: 5662
			// (get) Token: 0x06005605 RID: 22021 RVA: 0x00180364 File Offset: 0x0017E564
			// (set) Token: 0x06005606 RID: 22022 RVA: 0x00020C3A File Offset: 0x0001EE3A
			public unsafe IDynamicProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700161F RID: 5663
			// (get) Token: 0x06005607 RID: 22023 RVA: 0x00180394 File Offset: 0x0017E594
			// (set) Token: 0x06005608 RID: 22024 RVA: 0x00020C59 File Offset: 0x0001EE59
			public unsafe IDynamicMessageSink Sink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004548 RID: 17736
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04004549 RID: 17737
			private static readonly IntPtr NativeFieldInfoPtr_Sink;

			// Token: 0x0400454A RID: 17738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
