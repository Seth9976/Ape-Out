using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000386 RID: 902
	public sealed class NameCache : Object
	{
		// Token: 0x06003BB2 RID: 15282 RVA: 0x0011CF50 File Offset: 0x0011B150
		// Note: this type is marked as 'beforefieldinit'.
		static NameCache()
		{
			Il2CppClassPointerStore<NameCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "NameCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameCache>.NativeClassPtr);
			NameCache.NativeFieldInfoPtr_ht = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "ht");
			NameCache.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameCache>.NativeClassPtr, "name");
			NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672229);
			NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672230);
			NameCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameCache>.NativeClassPtr, 100672231);
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x0011CFE4 File Offset: 0x0011B1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218980, RefRangeEnd = 218981, XrefRangeStart = 218968, XrefRangeEnd = 218980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetCachedValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x0011D034 File Offset: 0x0011B234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218993, RefRangeEnd = 218994, XrefRangeStart = 218981, XrefRangeEnd = 218993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCachedValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0011D078 File Offset: 0x0011B278
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x000161E6 File Offset: 0x000143E6
		public NameCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x0011D0B4 File Offset: 0x0011B2B4
		// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x000161EF File Offset: 0x000143EF
		public unsafe static ConcurrentDictionary<string, Object> ht
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameCache.NativeFieldInfoPtr_ht, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameCache.NativeFieldInfoPtr_ht, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x0011D0DC File Offset: 0x0011B2DC
		// (set) Token: 0x06003BBA RID: 15290 RVA: 0x00016201 File Offset: 0x00014401
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameCache.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr_ht;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValue_Internal_Object_String_0;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeMethodInfoPtr_SetCachedValue_Internal_Void_Object_0;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
