using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D1 RID: 465
	public sealed class MonoEventInfo : ValueType
	{
		// Token: 0x06001E1C RID: 7708 RVA: 0x000AB7B0 File Offset: 0x000A99B0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoEventInfo()
		{
			Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoEventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr);
			MonoEventInfo.NativeFieldInfoPtr_declaring_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "declaring_type");
			MonoEventInfo.NativeFieldInfoPtr_reflected_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "reflected_type");
			MonoEventInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "name");
			MonoEventInfo.NativeFieldInfoPtr_add_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "add_method");
			MonoEventInfo.NativeFieldInfoPtr_remove_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "remove_method");
			MonoEventInfo.NativeFieldInfoPtr_raise_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "raise_method");
			MonoEventInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "attrs");
			MonoEventInfo.NativeFieldInfoPtr_other_methods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, "other_methods");
			MonoEventInfo.NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, 100668353);
			MonoEventInfo.NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr, 100668354);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187988, XrefRangeEnd = 187999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_event_info(MonoEvent ev, out MonoEventInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ev);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoEventInfo.NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new MonoEventInfo(intPtr4));
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000AB900 File Offset: 0x000A9B00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 188010, RefRangeEnd = 188016, XrefRangeStart = 187999, XrefRangeEnd = 188010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoEventInfo GetEventInfo(MonoEvent ev)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ev);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEventInfo.NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MonoEventInfo(intPtr);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0000A3D1 File Offset: 0x000085D1
		public MonoEventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0000A3DA File Offset: 0x000085DA
		public MonoEventInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoEventInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000AB93C File Offset: 0x000A9B3C
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0000A3EC File Offset: 0x000085EC
		public unsafe Type declaring_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_declaring_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000AB96C File Offset: 0x000A9B6C
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0000A40B File Offset: 0x0000860B
		public unsafe Type reflected_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_reflected_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000AB99C File Offset: 0x000A9B9C
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0000A42A File Offset: 0x0000862A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x000AB9C4 File Offset: 0x000A9BC4
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0000A449 File Offset: 0x00008649
		public unsafe MethodInfo add_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_add_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000AB9F4 File Offset: 0x000A9BF4
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0000A468 File Offset: 0x00008668
		public unsafe MethodInfo remove_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_remove_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x000ABA24 File Offset: 0x000A9C24
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0000A487 File Offset: 0x00008687
		public unsafe MethodInfo raise_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_raise_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x000ABA54 File Offset: 0x000A9C54
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0000A4A6 File Offset: 0x000086A6
		public unsafe EventAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000ABA7C File Offset: 0x000A9C7C
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0000A4C1 File Offset: 0x000086C1
		public unsafe Il2CppReferenceArray<MethodInfo> other_methods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEventInfo.NativeFieldInfoPtr_other_methods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_declaring_type;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_reflected_type;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeFieldInfoPtr_add_method;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeFieldInfoPtr_remove_method;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeFieldInfoPtr_raise_method;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_other_methods;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_get_event_info_Private_Static_Void_MonoEvent_byref_MonoEventInfo_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_GetEventInfo_Internal_Static_MonoEventInfo_MonoEvent_0;
	}
}
