using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000346 RID: 838
	public static class SerializationEventsCache : Object
	{
		// Token: 0x060036AD RID: 13997 RVA: 0x0010BED0 File Offset: 0x0010A0D0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventsCache()
		{
			Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEventsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr);
			SerializationEventsCache.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, "cache");
			SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventsCache>.NativeClassPtr, 100671783);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0010BF28 File Offset: 0x0010A128
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 214653, RefRangeEnd = 214661, XrefRangeStart = 214630, XrefRangeEnd = 214653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationEvents GetSerializationEventsForType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventsCache.NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEvents>(intPtr3) : null;
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00013705 File Offset: 0x00011905
		public SerializationEventsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x0010BF6C File Offset: 0x0010A16C
		// (set) Token: 0x060036B1 RID: 14001 RVA: 0x0001370E File Offset: 0x0001190E
		public unsafe static Hashtable cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationEventsCache.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationEventsCache.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationEventsForType_Internal_Static_SerializationEvents_Type_0;
	}
}
